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

        Statement statement = context.GetChild(0) switch
        {
            Drop_functionContext => Visit(Logger, context.drop_function()),
            Drop_indexContext => Visit(Logger, context.drop_index()),
            Drop_schemaContext => Visit(Logger, context.drop_schema()),
            Drop_sequenceContext => Visit(Logger, context.drop_sequence()),
            Drop_tableContext => Visit(Logger, context.drop_table()),
            Drop_typeContext => Visit(Logger, context.drop_type()),
            Drop_viewContext => Visit(Logger, context.drop_view()),

            _ => throw new NotImplementedException()
        };

        Logger.NestEnd();
        return statement;
    }
}