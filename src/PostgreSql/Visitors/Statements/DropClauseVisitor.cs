// <copyright file="DropClauseVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static PostgreSql.PostgresParser;

namespace PostgreSql.Visitors;

internal sealed class DropClauseVisitor : PostgresVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DropClauseVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DropClauseVisitor(ILogger logger)
        : base(logger)
    {
    }

    /// <inheritdoc/>
    public override ParseResult VisitDrop_clause(Drop_clauseContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();

        ParseResult result = new();

        if (context.drop_schema().IsNotEmpty())
            result.Add(Visit(Logger, context.drop_schema()));
        else if (context.drop_view().IsNotEmpty())
            result.Add(Visit(Logger, context.drop_view()));

        Logger.NestEnd();
        return result;
    }
}