
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

    /// <summary>
    /// Visit the column_name rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Column_nameContext"/>.</param>
    /// <returns>A <see cref="ColumnName"/>.</returns>
    internal static ColumnName Visit(ILogger logger, Column_nameContext context)
    {
        logger.TraceEntry();
        return new ColumnNameVisitor(logger).VisitColumn_name(context);
    }

    /// <summary>
    /// Visit the create_schema rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="Create_schemaContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, Create_schemaContext context)
    {
        logger.TraceEntry();
        return new CreateSchemaVisitor(logger).VisitCreate_schema(context);
    }

    /// <summary>
    /// Visit the create rule.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    /// <param name="context">The <see cref="CreateContext"/>.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    internal static ParseResult Visit(ILogger logger, CreateContext context)
    {
        logger.TraceEntry();
        return new CreateVisitor(logger).VisitCreate(context);
    }
}