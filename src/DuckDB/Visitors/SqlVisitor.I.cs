// <copyright file="SqlVisitor{T}.cs" company="Usher Incorporated">
//     Copyright Usher, Inc. All rights reserved.
// </copyright>
// <author>Matt Usher</author>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

internal partial class SqlVisitor<T>
{
    /// <summary>
    /// Visit the identifier rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="IdentifierContext"/>.</param>
    /// <returns>A <see cref="Identifier"/>.</returns>
    internal static Identifier Visit(ILogger logger, IdentifierContext context)
    {
        logger.TraceEntry();
        return new IdentifierVisitor(logger).VisitIdentifier(context);
    }

    /// <summary>
    /// Visit the index_name rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Index_nameContext"/>.</param>
    /// <returns>A <see cref="IndexName"/>.</returns>
    internal static IndexName Visit(ILogger logger, Index_nameContext context)
    {
        logger.TraceEntry();
        return new IndexNameVisitor(logger).VisitIndex_name(context);
    }
}