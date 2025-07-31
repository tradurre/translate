// <copyright file="StatementVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static PostgreSql.PostgresParser;

namespace PostgreSql.Visitors;

internal sealed class StatementVisitor : PostgresVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="StatementVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public StatementVisitor(ILogger logger)
        : base(logger)
    {
    }

    /// <inheritdoc/>
    public override ParseResult VisitStatement(StatementContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();

        ParseResult result = new();

        if (context.ddl_clause().IsNotEmpty())
            result.Add(Visit(Logger, context.ddl_clause()));

        Logger.NestEnd();
        return result;
    }
}