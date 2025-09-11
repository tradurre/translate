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
    /// Visit the other rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="OtherContext"/>.</param>
    /// <returns>A <see cref="Statement"/>.</returns>
    internal static ParseResult Visit(ILogger logger, OtherContext context)
    {
        logger.TraceEntry();
        return new OtherVisitor(logger).VisitOther(context);
    }
}