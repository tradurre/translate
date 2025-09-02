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
    /// Visit the drop rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="DropContext"/>.</param>
    /// <returns>A <see cref="Statement"/>.</returns>
    internal static Statement Visit(ILogger logger, DropContext context)
    {
        logger.TraceEntry();
        return new DropVisitor(logger).VisitDrop(context);
    }
}