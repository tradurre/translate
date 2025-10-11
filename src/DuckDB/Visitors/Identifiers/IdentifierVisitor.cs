// <copyright file="IdentifierVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the identifier rule.
/// </summary>
internal sealed class IdentifierVisitor : SqlVisitor<Identifier>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="IdentifierVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public IdentifierVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override Identifier VisitIdentifier(IdentifierContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        Identifier identifier = new(
            context.IDENTIFIER().GetText(),
            context.Source());

        if (context.DOUBLE_QUOTED_IDENTIFER() is not null)
        {
            identifier.IsQuoted = true;
            string value = context.IDENTIFIER().GetText();
            identifier.Value = value.Trim().TrimStart('"').TrimEnd('"');
        }

        Logger.NestEnd();
        return identifier;
    }
}