// <copyright file="StatementVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the statement rule.
/// </summary>
internal sealed class StatementVisitor : SqlVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="StatementVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public StatementVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override ParseResult VisitStatement(StatementContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));
        Logger.NestEnd();

        return context.GetChild(0) switch
        {
            DropContext => Visit(Logger, context.drop()),
            OtherContext => Visit(Logger, context.other()),

            _ => throw new NotImplementedException()
        };
    }
}