// <copyright file="FunctionNameVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the function_name rule.
/// </summary>
internal sealed class FunctionNameVisitor : SqlVisitor<FunctionName>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="FunctionNameVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public FunctionNameVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override FunctionName VisitFunction_name(Function_nameContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));
        Identifier value = Visit(Logger, context.identifier());

        Logger.NestEnd();

        return new FunctionName(value.Value, context.Source())
        {
            IsQuoted = value.IsQuoted,
        };
    }
}