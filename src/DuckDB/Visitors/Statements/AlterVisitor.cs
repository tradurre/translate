// <copyright file="AlterVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the alter rule.
/// </summary>
internal sealed class AlterVisitor : SqlVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="AlterVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public AlterVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override ParseResult VisitAlter(AlterContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));
        Logger.NestEnd();

        return context.GetChild(0) switch
        {
            Alter_databaseContext => Visit(Logger, context.alter_database()),
            //Alter_tableContext => Visit(Logger, context.Alter_tableContext()),
            //Alter_viewContext => Visit(Logger, context.Alter_viewContext()),

            _ => throw new NotImplementedException()
        };
    }
}