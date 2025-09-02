// <copyright file="ViewNameVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the view_name rule.
/// </summary>
internal sealed class ViewNameVisitor : SqlVisitor<ViewName>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="ViewNameVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public ViewNameVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override ViewName VisitView_name(View_nameContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        ViewName name = (ViewName)Visit(Logger, context.name);

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