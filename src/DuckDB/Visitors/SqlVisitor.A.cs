
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
    /// Visit the alter_database rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Alter_databaseContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, Alter_databaseContext context)
    {
        logger.TraceEntry();
        return new AlterDatabaseVisitor(logger).VisitAlter_database(context);
    }

    /// <summary>
    /// Visit the alter rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="AlterContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, AlterContext context)
    {
        logger.TraceEntry();
        return new AlterVisitor(logger).VisitAlter(context);
    }

    /// <summary>
    /// Visit the analyze rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="AnalyzeContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, AnalyzeContext context)
    {
        logger.TraceEntry();
        return new AnalyzeVisitor(logger).VisitAnalyze(context);
    }
}