// <copyright file="SchemaNameVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the schema_name rule.
/// </summary>
internal sealed class SchemaNameVisitor : SqlVisitor<SchemaName>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="SchemaNameVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public SchemaNameVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override SchemaName VisitSchema_name(Schema_nameContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));
        Identifier value = Visit(Logger, context.identifier());

        Logger.NestEnd();

        return new SchemaName(value.Value, context.Source())
        {
            IsQuoted = value.IsQuoted,
        };
    }
}