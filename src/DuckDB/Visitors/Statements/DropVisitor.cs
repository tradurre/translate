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
internal sealed class DropVisitor : SqlVisitor<ParseResult>
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
    public override ParseResult VisitDrop(DropContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));
        Logger.NestEnd();

        return context.GetChild(0) switch
        {
            Drop_functionContext => Visit(Logger, context.drop_function()),
            Drop_indexContext => Visit(Logger, context.drop_index()),
            Drop_schemaContext => Visit(Logger, context.drop_schema()),
            Drop_sequenceContext => Visit(Logger, context.drop_sequence()),
            //TODO: Drop_tableContext => Visit(Logger, context.drop_table()),
            //TODO: Drop_typeContext => Visit(Logger, context.drop_type()),
            //TODO: Drop_viewContext => Visit(Logger, context.drop_view()),

            _ => throw new NotImplementedException()
        };
    }
}