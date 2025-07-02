// <copyright file="SqlVisitor{T}.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static Microsoft.SqlServer.TSqlParser;

namespace Microsoft.SqlServer.Visitors;

internal partial class SqlVisitor<T>
{
    /// <summary>
    /// Visit the statement rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="StatementContext"/>.</param>
    /// <returns>A <see cref="Statement"/>.</returns>
    internal static Statement Visit(ILogger logger, StatementContext context)
    {
        logger.TraceEntry();
        return new StatementVisitor(logger).VisitStatement(context);
    }
}