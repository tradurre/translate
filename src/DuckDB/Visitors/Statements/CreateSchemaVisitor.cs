// <copyright file="CreateSchemaVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the create_schema rule.
/// </summary>
internal sealed class CreateSchemaVisitor : SqlVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="CreateSchemaVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public CreateSchemaVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override ParseResult VisitCreate_schema(Create_schemaContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        ParseResult result = new();

        CreateSchemaStatement statement = new(
            Visit(Logger, context.schema_name()),
            context.Source());

        if (context.or_replace() is not null)
            statement.OrReplace = true;

        if (context.if_not_exists() is not null)
            statement.IfNotExists = true;

        result.Statements.Add(statement);

        Logger.NestEnd();
        return result;
    }
}