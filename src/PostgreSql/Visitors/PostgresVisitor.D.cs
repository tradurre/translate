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
    /// <param name="context">The <see cref="Ddl_clauseContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, Ddl_clauseContext context)
    {
        logger.TraceEntry();
        return new DdlClauseVisitor(logger).VisitDdl_clause(context);
    }

    /// <summary>
    /// Visit the drop_clause rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Drop_clauseContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, Drop_clauseContext context)
    {
        logger.TraceEntry();
        return new DropClauseVisitor(logger).VisitDrop_clause(context);
    }

    /// <summary>
    /// Visit the drop_schema rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Drop_schemaContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, Drop_schemaContext context)
    {
        logger.TraceEntry();
        return new DropSchemaVisitor(logger).VisitDrop_schema(context);
    }

    /// <summary>
    /// Visit the drop_view rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Drop_viewContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, Drop_viewContext context)
    {
        logger.TraceEntry();
        return new DropViewVisitor(logger).VisitDrop_view(context);
    }
}