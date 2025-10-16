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
    /// Visit the vacuum rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="VacuumContext"/>.</param>
    /// <returns>A <see cref="ViewName"/>.</returns>
    internal static ParseResult Visit(ILogger logger, VacuumContext context)
    {
        logger.TraceEntry();
        return new VacuumVisitor(logger).VisitVacuum(context);
    }

    /// <summary>
    /// Visit the view_name rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="View_nameContext"/>.</param>
    /// <returns>A <see cref="ViewName"/>.</returns>
    internal static ViewName Visit(ILogger logger, View_nameContext context)
    {
        logger.TraceEntry();
        return new ViewNameVisitor(logger).VisitView_name(context);
    }
}