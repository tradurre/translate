// <copyright file="SqlVisitor{T}.cs" company="Usher Incorporated">
//     Copyright Usher, Inc. All rights reserved.
// </copyright>
// <author>Matt Usher</author>

using Microsoft.Extensions.Logging;
using Tradurre;
using static Microsoft.SqlServer.TSqlParser;

namespace Microsoft.SqlServer.Visitors;

internal partial class SqlVisitor<T>
{
    /// <summary>
    /// Visit the ddl_clause rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Ddl_clauseContext"/>.</param>
    /// <returns>A <see cref="Statement"/>.</returns>
    internal static Statement Visit(ILogger logger, Ddl_clauseContext context)
    {
        logger.TraceEntry();
        return new DdlClauseVisitor(logger).VisitDdl_clause(context);
    }

    /// <summary>
    /// Visit the drop_clause rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Drop_clauseContext"/>.</param>
    /// <returns>A <see cref="Statement"/>.</returns>
    internal static Statement Visit(ILogger logger, Drop_clauseContext context)
    {
        logger.TraceEntry();
        return new DropClauseVisitor(logger).VisitDrop_clause(context);
    }
}