// <copyright file="SequenceNameVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the sequence_name rule.
/// </summary>
internal sealed class SequenceNameVisitor : SqlVisitor<SequenceName>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="SequenceNameVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public SequenceNameVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override SequenceName VisitSequence_name(Sequence_nameContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));
        Identifier value = Visit(Logger, context.identifier());

        Logger.NestEnd();

        return new SequenceName(value.Value, context.Source())
        {
            IsQuoted = value.IsQuoted,
        };
    }
}