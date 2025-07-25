// <copyright file="DropViewVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static PostgreSql.PostgresParser;

namespace PostgreSql.Visitors;

internal sealed class DropViewVisitor : PostgresVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DropViewVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DropViewVisitor(ILogger logger)
        : base(logger)
    {
    }

    /// <inheritdoc/>
    public override ParseResult VisitDrop_view(Drop_viewContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();

        ParseResult result = new();

        //Drop


        Logger.NestEnd();
        return result;
    }
}