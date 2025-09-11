// <copyright file="DropSchemaVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the drop_schema rule.
/// </summary>
internal sealed class DropSchemaVisitor : SqlVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DropSchemaVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DropSchemaVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override ParseResult VisitDrop_schema(Drop_schemaContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        ParseResult result = new();

        DropSchemaStatement statement = new(
            Visit(Logger, context.schema_name()),
            context.Source());

        if (context.if_exists() is not null)
            statement.IfExists = true;

        if (context.cascade_restrict() is not null)
            statement.Option = Visit(Logger, context.cascade_restrict());

        result.Statements.Add(statement);

        Logger.NestEnd();
        return result;
    }
}