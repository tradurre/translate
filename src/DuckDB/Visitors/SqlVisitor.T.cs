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
    ///// <summary>
    ///// Visit the table_name rule.
    ///// </summary>
    ///// <param name="logger">An <see cref="ILogger"/>.</param>
    ///// <param name="context">The <see cref="Table_nameContext"/>.</param>
    ///// <returns>A <see cref="TableName"/>.</returns>
    //internal static TableName Visit(ILogger logger, Table_nameContext context)
    //{
    //    logger.TraceEntry();
    //    return new TableNameVisitor(logger).VisitTable_name(context);
    //}

    ///// <summary>
    ///// Visit the type_name rule.
    ///// </summary>
    ///// <param name="logger">An <see cref="ILogger"/>.</param>
    ///// <param name="context">The <see cref="Type_nameContext"/>.</param>
    ///// <returns>A <see cref="TypeName"/>.</returns>
    //internal static TypeName Visit(ILogger logger, Type_nameContext context)
    //{
    //    logger.TraceEntry();
    //    return new TypeNameVisitor(logger).VisitType_name(context);
    //}
}