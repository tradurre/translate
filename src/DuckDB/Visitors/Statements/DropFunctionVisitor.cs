// <copyright file="DropFunctionVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the drop_function rule.
/// </summary>
internal sealed class DropFunctionVisitor : SqlVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DropFunctionVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DropFunctionVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override ParseResult VisitDrop_function(Drop_functionContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        ParseResult result = new();

        DropFunctionStatement statement = new(
            Visit(Logger, context.function_name()),
            context.Source());

        if (context.if_exists() is not null)
            statement.IfExists = true;

        if (context.cascade_restrict() is not null)
            statement.Option = Visit(Logger, context.cascade_restrict());

        Logger.NestEnd();
        return result;
    }
}