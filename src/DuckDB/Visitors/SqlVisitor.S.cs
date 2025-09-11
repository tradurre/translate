// <copyright file="SqlVisitor{T}.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

internal partial class SqlVisitor<T>
{
    /// <summary>
    /// Visit the schema_name rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Schema_nameContext"/>.</param>
    /// <returns>A <see cref="SchemaName"/>.</returns>
    internal static SchemaName Visit(ILogger logger, Schema_nameContext context)
    {
        logger.TraceEntry();
        return new SchemaNameVisitor(logger).VisitSchema_name(context);
    }

    /// <summary>
    /// Visit the sequence_name rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Sequence_nameContext"/>.</param>
    /// <returns>A <see cref="SequenceName"/>.</returns>
    internal static SequenceName Visit(ILogger logger, Sequence_nameContext context)
    {
        logger.TraceEntry();
        return new SequenceNameVisitor(logger).VisitSequence_name(context);
    }

    /// <summary>
    /// Visit the statement rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="StatementContext"/>.</param>
    /// <returns>A <see cref="Statement"/>.</returns>
    internal static ParseResult Visit(ILogger logger, StatementContext context)
    {
        logger.TraceEntry();
        return new StatementVisitor(logger).VisitStatement(context);
    }

    /// <summary>
    /// Visit the statement_termination rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Statement_terminationContext"/>.</param>
    /// <returns>A <see cref="TerminationStatement"/>.</returns>
    internal static ParseResult Visit(ILogger logger, Statement_terminationContext context)
    {
        logger.TraceEntry();
        return new StatementTerminationVisitor(logger).VisitStatement_termination(context);
    }
}