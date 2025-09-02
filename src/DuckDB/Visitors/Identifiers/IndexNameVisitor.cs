// <copyright file="IndexNameVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the index_name rule.
/// </summary>
internal sealed class IndexNameVisitor : SqlVisitor<IndexName>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="IndexNameVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public IndexNameVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override IndexName VisitIndex_name(Index_nameContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        Identifier value = Visit(context.identifier());

        Logger.NestEnd();
        return (IndexName)value;
    }
}