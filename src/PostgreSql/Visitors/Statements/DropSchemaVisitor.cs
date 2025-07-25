// <copyright file="DropSchemaVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static PostgreSql.PostgresParser;

namespace PostgreSql.Visitors;

internal sealed class DropSchemaVisitor : PostgresVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DropSchemaVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DropSchemaVisitor(ILogger logger)
        : base(logger)
    {
    }

    /// <inheritdoc/>
    public override ParseResult VisitDrop_schema(Drop_schemaContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();

        ParseResult result = new();

        DropSchemaStatement statement = new(context.Source());

        if (context.if_exists().IsNotEmpty())
            statement.IfExists = true;

        if (context.cascade_restrict().IsNotEmpty())
            // TODO: result.Errors.Add()
            //statement.Options.Add(Visit(Logger, context.cascade_restrict()));


        result.Statements.Add(statement);

        Logger.NestEnd();
        return result;
    }
}