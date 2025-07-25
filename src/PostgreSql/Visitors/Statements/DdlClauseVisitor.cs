// <copyright file="DdlClauseVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static PostgreSql.PostgresParser;

namespace PostgreSql.Visitors;

internal sealed class DdlClauseVisitor : PostgresVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DdlClauseVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DdlClauseVisitor(ILogger logger)
        : base(logger)
    {
    }

    /// <inheritdoc/>
    public override ParseResult VisitDdl_clause(Ddl_clauseContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();

        ParseResult result = new();

        if (context.drop_clause().IsNotEmpty())
            result.Add(Visit(Logger, context.drop_clause()));

        Logger.NestEnd();
        return result;
    }
}