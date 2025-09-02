// <copyright file="DropVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the drop_clause rule.
/// </summary>
internal sealed class DropVisitor : SqlVisitor<Statement>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DropVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DropVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override Statement VisitDrop(DropContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        Statement statement;
        throw new NotImplementedException(context.Source().Value);

        Logger.NestEnd();
        return statement;
    }
}