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
    /// Visit the function_name rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Function_nameContext"/>.</param>
    /// <returns>A <see cref="FunctionName"/>.</returns>
    internal static FunctionName Visit(ILogger logger, Function_nameContext context)
    {
        logger.TraceEntry();
        return new FunctionNameVisitor(logger).VisitFunction_name(context);
    }
}