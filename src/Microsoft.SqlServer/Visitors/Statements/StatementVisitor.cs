// <copyright file="StatementVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static Microsoft.SqlServer.TSqlParser;

namespace Microsoft.SqlServer.Visitors;

/// <summary>
/// Handles the statement rule.
/// </summary>
internal sealed class StatementVisitor : SqlVisitor<Statement>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="StatementVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public StatementVisitor(ILogger logger)
        : base(logger)
    {
    }

    /// <inheritdoc/>
    public override Statement VisitStatement(StatementContext context)
    {
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));        

        Statement statement;

        if (context.ddl_clause() is not null)
            statement = Visit(Logger, context.ddl_clause());

        else
            throw new NotImplementedException(context.Info().Value);

        Logger.NestEnd();
        return statement;
    }
}