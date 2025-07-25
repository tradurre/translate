// <copyright file="DdlClauseVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static Microsoft.SqlServer.TSqlParser;

namespace Microsoft.SqlServer.Visitors;

/// <summary>
/// Handles the ddl_clause rule.
/// </summary>
internal sealed class DdlClauseVisitor : SqlVisitor<Statement>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DdlClauseVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DdlClauseVisitor(ILogger logger)
        : base(logger)
    {
    }

    /// <inheritdoc/>
    public override Statement VisitDdl_clause(Ddl_clauseContext context)
    {
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        Statement statement;

        if (context.drop_clause() is not null)
            statement = Visit(Logger, context.drop_clause());

        else
            throw new NotImplementedException(context.Source().Value);

        Logger.NestEnd();
        return statement;
    }
}