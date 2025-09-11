// <copyright file="DropTableVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the drop_table rule.
/// </summary>
internal sealed class DropTableVisitor : SqlVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DropTableVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DropTableVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override ParseResult VisitDrop_table(Drop_tableContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        ParseResult result = new();

        DropTableStatement statement = new(
            Visit(Logger, context.table_name()),
            context.Source());

        if (context.if_exists() is not null)
            statement.IfExists = true;

        if (context.cascade_restrict() is not null)
            statement.Option = Visit(Logger, context.cascade_restrict());

        result.Statements.Add(statement);

        Logger.NestEnd();
        return result;
    }
}