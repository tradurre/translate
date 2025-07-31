// <copyright file="CascadeRestrictVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using System.Net.Mime;
using Tradurre;
using static PostgreSql.PostgresParser;

namespace PostgreSql.Visitors;

internal sealed class CascadeRestrictVisitor : PostgresVisitor<ParseResult>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="CascadeRestrictVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public CascadeRestrictVisitor(ILogger logger)
        : base(logger)
    {
    }

    /// <inheritdoc/>
    public override ParseResult VisitCascade_restrict(Cascade_restrictContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();

        Logger.NestEnd();

        //if (context.CASCADE().IsNotEmpty())
        //    return DropSchemaOption.Cascade;
        //else if (context.RESTRICT().IsNotEmpty())
        //    return DropSchemaOption.Restrict;
        //else
            throw new NotImplementedException();
    }
}