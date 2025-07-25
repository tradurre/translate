// <copyright file="BatchVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static PostgreSql.PostgresParser;

namespace PostgreSql.Visitors;

internal sealed class BatchVisitor : PostgresVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="BatchVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public BatchVisitor(ILogger logger)
        : base(logger)
    {
    }

    /// <inheritdoc/>
    public override ParseResult VisitBatch(BatchContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();

        ParseResult result = new();

        foreach(StatementContext statement in context.statement())
        {
            Logger.LogTrace(statement.GetText());
            result.Add(Visit(Logger, statement));
        }

        Logger.NestEnd();
        return result;
    }
}