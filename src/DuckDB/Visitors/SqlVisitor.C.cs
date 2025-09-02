
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
    /// Visit the cascade_restrict rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Cascade_restrictContext"/>.</param>
    /// <returns>A <see cref="DropOption"/>.</returns>
    internal static DropOption Visit(ILogger logger, Cascade_restrictContext context)
    {
        logger.TraceEntry();
        return new CascadeRestrictVisitor(logger).VisitCascade_restrict(context);
    }
}