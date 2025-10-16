// <copyright file="UseVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the use rule.
/// </summary>
internal sealed class UseVisitor : SqlVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="UseVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public UseVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override ParseResult VisitUse(UseContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        ParseResult result = new();

        SchemaName name;

        if (context.schema_name() is not null)
        {
            name = Visit(Logger, context.schema_name());
            name.Database = Visit(Logger, context.database_name());
        }
        else
        {
            DatabaseName d_name = Visit(Logger, context.database_name());

            name = new(d_name.Value, context.Source())
            {
                IsQuoted = d_name.IsQuoted
            };
        }

        UseStatement statement = new(name, context.Source());

        result.Statements.Add(statement);

        Logger.NestEnd();
        return result;
    }
}