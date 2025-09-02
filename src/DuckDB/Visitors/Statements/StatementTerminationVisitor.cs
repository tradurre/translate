// <copyright file="StatementTerminationVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the statement_termination rule.
/// </summary>
internal sealed class StatementTerminationVisitor : SqlVisitor<TerminationStatement>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="StatementTerminationVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public StatementTerminationVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override TerminationStatement VisitStatement_termination(Statement_terminationContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        Logger.NestEnd();
        return new TerminationStatement(context.Source());
    }
}