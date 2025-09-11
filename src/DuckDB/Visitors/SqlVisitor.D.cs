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
    /// Visit the drop_function rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Drop_functionContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, Drop_functionContext context)
    {
        logger.TraceEntry();
        return new DropFunctionVisitor(logger).VisitDrop_function(context);
    }

    /// <summary>
    /// Visit the drop_index rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Drop_indexContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, Drop_indexContext context)
    {
        logger.TraceEntry();
        return new DropIndexVisitor(logger).VisitDrop_index(context);
    }

    /// <summary>
    /// Visit the drop rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="DropContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, DropContext context)
    {
        logger.TraceEntry();
        return new DropVisitor(logger).VisitDrop(context);
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

    /*
     *

    /// <summary>
    /// Visit the drop_sequence rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Drop_sequenceContext"/>.</param>
    /// <returns>A <see cref="DropSequenceStatement"/>.</returns>
    internal static DropSequenceStatement Visit(ILogger logger, Drop_sequenceContext context)
    {
        logger.TraceEntry();
        return new DropSequenceVisitor(logger).VisitDrop_sequence(context);
    }

    /// <summary>
    /// Visit the drop_table rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Drop_tableContext"/>.</param>
    /// <returns>A <see cref="DropTableStatement"/>.</returns>
    internal static DropTableStatement Visit(ILogger logger, Drop_tableContext context)
    {
        logger.TraceEntry();
        return new DropTableVisitor(logger).VisitDrop_table(context);
    }

    /// <summary>
    /// Visit the drop_type rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Drop_typeContext"/>.</param>
    /// <returns>A <see cref="DropTypeStatement"/>.</returns>
    internal static DropTypeStatement Visit(ILogger logger, Drop_typeContext context)
    {
        logger.TraceEntry();
        return new DropTypeVisitor(logger).VisitDrop_type(context);
    }

    /// <summary>
    /// Visit the drop_view rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Drop_viewContext"/>.</param>
    /// <returns>A <see cref="DropViewStatement"/>.</returns>
    internal static DropViewStatement Visit(ILogger logger, Drop_viewContext context)
    {
        logger.TraceEntry();
        return new DropViewVisitor(logger).VisitDrop_view(context);
    }
    */
}