// <copyright file="ColumnNameVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the column_name rule.
/// </summary>
internal sealed class ColumnNameVisitor : SqlVisitor<ColumnName>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="ColumnNameVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public ColumnNameVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override ColumnName VisitColumn_name(Column_nameContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));
        Identifier value = Visit(Logger, context.identifier());

        Logger.NestEnd();

        return new ColumnName(value.Value, context.Source())
        {
            IsQuoted = value.IsQuoted,
        };
    }
}