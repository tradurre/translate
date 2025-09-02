// <copyright file="CascadeRestrictVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the cascade_restrict rule.
/// </summary>
internal sealed class CascadeRestrictVisitor : SqlVisitor<DropOption>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="CascadeRestrictVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public CascadeRestrictVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override DropOption VisitCascade_restrict(Cascade_restrictContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));
        Logger.NestEnd();

        if (context.CASCADE() is not null)
            return DropOption.Cascade;
        else if (context.RESTRICT() is not null)
            return DropOption.Restrict;
        else
            throw new NotImplementedException();
    }
}