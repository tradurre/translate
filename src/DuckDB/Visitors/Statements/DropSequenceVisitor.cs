// <copyright file="DropSequenceVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the drop_sequence rule.
/// </summary>
internal sealed class DropSequenceVisitor : SqlVisitor<DropSequenceStatement>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DropSequenceVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DropSequenceVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override DropSequenceStatement VisitDrop_sequence(Drop_sequenceContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        DropSequenceStatement statement = new(
            Visit(Logger, context.sequence_name()),
            context.Source());

        if (context.if_exists() is not null)
            statement.IfExists = true;

        if (context.cascade_restrict() is not null)
            statement.Option = Visit(Logger, context.cascade_restrict());

        Logger.NestEnd();
        return statement;
    }
}