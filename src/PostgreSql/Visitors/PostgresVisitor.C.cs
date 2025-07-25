// <copyright file="PostgresVisitor{T}.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static PostgreSql.PostgresParser;

namespace PostgreSql.Visitors;

/// <summary>
/// Base visitor for all PostgreSQL specific visitors.
/// </summary>
internal partial class PostgresVisitor<T>
{
    /// <summary>
    /// Visit the ddl_clause rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Cascade_restrictContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, Cascade_restrictContext context)
    {
        logger.TraceEntry();
        return new CascadeRestrictVisitor(logger).VisitCascade_restrict(context);
    }
}