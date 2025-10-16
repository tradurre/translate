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
    /// Visit the use rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="UseContext"/>.</param>
    /// <returns>A <see cref="TableName"/>.</returns>
    internal static ParseResult Visit(ILogger logger, UseContext context)
    {
        logger.TraceEntry();
        return new UseVisitor(logger).VisitUse(context);
    }
}