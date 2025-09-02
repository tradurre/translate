// <copyright file="DropIndexVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the drop_index rule.
/// </summary>
internal sealed class DropIndexVisitor : SqlVisitor<DropIndexStatement>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DropIndexVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DropIndexVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override DropIndexStatement VisitDrop_index(Drop_indexContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        DropIndexStatement statement = new(
            Visit(Logger, context.index_name()),
            context.Source());

        if (context.if_exists() is not null)
            statement.IfExists = true;

        if (context.cascade_restrict() is not null)
            statement.Option = Visit(Logger, context.cascade_restrict());

        Logger.NestEnd();
        return statement;
    }
}