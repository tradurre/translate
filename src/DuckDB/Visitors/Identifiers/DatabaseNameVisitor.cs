// <copyright file="DatabaseNameVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the database_name rule.
/// </summary>
internal sealed class DatabaseNameVisitor : SqlVisitor<DatabaseName>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="DatabaseNameVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public DatabaseNameVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override DatabaseName VisitDatabase_name(Database_nameContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));
        Identifier value = Visit(Logger, context.identifier());

        Logger.NestEnd();

        return new DatabaseName(value.Value, context.Source())
        {
            IsQuoted = value.IsQuoted,
        };
    }
}