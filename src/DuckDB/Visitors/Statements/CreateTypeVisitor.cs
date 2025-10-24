// <copyright file="CreateTypeVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the create_type rule.
/// </summary>
internal sealed class CreateTypeVisitor : SqlVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="CreateTypeVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public CreateTypeVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override ParseResult VisitCreate_type(Create_typeContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        ParseResult result = new();

        if (context.dt is not null)
        {
            CreateTypeAsDataTypeStatement statement = new(
                Visit(Logger, context.name),
                Visit(Logger, context.dt),
                context.Source());

            result.Statements.Add(statement);
        }

        else
            throw new NotImplementedException();

        Logger.NestEnd();
        return result;
    }
}