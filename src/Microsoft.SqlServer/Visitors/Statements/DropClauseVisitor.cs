// <copyright file="DropClauseVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static Microsoft.SqlServer.TSqlParser;

namespace Microsoft.SqlServer.Visitors;

/// <summary>
/// Handles the drop_clause rule.
/// </summary>
internal sealed class DropClauseVisitor : SqlVisitor<Statement>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DropClauseVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DropClauseVisitor(ILogger logger)
        : base(logger)
    {
    }

    /// <inheritdoc/>
    public override Statement VisitDrop_clause(Drop_clauseContext context)
    {
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));        

        Statement statement;
        throw new NotImplementedException(context.Info().Value);

        Logger.NestEnd();
        return statement;
    }
}