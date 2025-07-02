// <copyright file="BatchVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static Microsoft.SqlServer.TSqlParser;

namespace Microsoft.SqlServer.Visitors;

/// <summary>
/// Handles the batch rule.
/// </summary>
internal sealed class BatchVisitor : SqlVisitor<List<Statement>>
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
    public override List<Statement> VisitBatch(BatchContext context)
    {
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        List<Statement> results = [];

        context.statement().ToList<StatementContext>().ForEach(f => results.Add(Visit(Logger, f)));

        Logger.NestEnd();
        return results;
    }
}