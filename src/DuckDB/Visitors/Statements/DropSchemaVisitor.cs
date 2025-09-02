// <copyright file="DropSchemaVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the drop_clause rule.
/// </summary>
internal sealed class DropSchemaVisitor : SqlVisitor<Statement>
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
    public override Statement VisitDrop_schema(Drop_schemaContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        var schema = Visit(context.schema_name());

        DropSchemaStatement statement = new(
            Visit(Logger, context.schema_name()),
            context.Source());

        Logger.NestEnd();
        return statement;
    }
}