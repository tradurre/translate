// <copyright file="CreateVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the create rule.
/// </summary>
internal sealed class CreateVisitor : SqlVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="CreateVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public CreateVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override ParseResult VisitCreate(CreateContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));
        Logger.NestEnd();

        return context.GetChild(0) switch
        {
            //Create_indexContext => Visit(Logger, context.create_index()),
            //Create_macroContext => Visit(Logger, context.create_macro()),
            Create_schemaContext => Visit(Logger, context.create_schema()),
            //Create_secretContext => Visit(Logger, context.create_secret()),
            //Create_sequenceContext => Visit(Logger, context.create_sequence()),
            //Create_tableContext => Visit(Logger, context.create_table()),
            Create_typeContext => Visit(Logger, context.create_type()),

            _ => throw new NotImplementedException()
        };
    }
}