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
    /// Visit the statement rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="StatementContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, StatementContext context)
    {
        logger.TraceEntry();
        return new StatementVisitor(logger).VisitStatement(context);
    }
}