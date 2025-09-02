// <copyright file="TableNameVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the table_name rule.
/// </summary>
internal sealed class TableNameVisitor : SqlVisitor<TableName>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="TableNameVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public TableNameVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override TableName VisitTable_name(Table_nameContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        TableName name = (TableName)Visit(Logger, context.name);

        if (context.schema is not null)
        {
            name.Schema = (SchemaName)Visit(Logger, context.schema);

            if (context.catalog is not null)
                name.Schema.Database = (DatabaseName)Visit(Logger, context.catalog);
        }

        Logger.NestEnd();
        return name;
    }
}