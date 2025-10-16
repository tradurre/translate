// <copyright file="VacuumVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the vacuum rule.
/// </summary>
internal sealed class VacuumVisitor : SqlVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="VacuumVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public VacuumVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override ParseResult VisitVacuum(VacuumContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        ParseResult result = new();

        VacuumStatement statement = new(context.Source());

        if (context.ANALYZE() is not null)
            statement.Analyze = true;


        if (context.table_name() is not null)
        {
            Table t = new(Visit(Logger, context.table_name()), context.Source());

            if (context.column_name() is not null
                && context.column_name().Length > 0)
            {
                foreach(Column_nameContext c_context in context.column_name())
                {
                    t.Columns.Add(new Column(Visit(Logger, c_context), context.Source()));
                }
            }
        }

        result.Statements.Add(statement);

        Logger.NestEnd();
        return result;
    }
}