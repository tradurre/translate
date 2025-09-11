// <copyright file="TypeNameVisitor.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;
using static DuckDB.DuckDBParser;

namespace DuckDB.Visitors;

/// <summary>
/// Handles the type_name rule.
/// </summary>
internal sealed class TypeNameVisitor : SqlVisitor<TypeName>
{
    /// <summary>
    /// Initlaizes a new instance of the <see cref="TypeNameVisitor"/> class with the specified <see cref="ILogger"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger"/>.</param>
    public TypeNameVisitor(ILogger logger)
        : base(logger)
    {
        Logger.TraceEntry();
    }

    /// <inheritdoc/>
    public override TypeName VisitType_name(Type_nameContext context)
    {
        Logger.TraceEntry();
        Logger.NestStart();
        ArgumentNullException.ThrowIfNull(context, nameof(context));

        Identifier value = Visit(Logger, context.name);

        TypeName name = new(value.Value, context.Source());

        if (context.schema is not null)
        {
            name.Schema = (SchemaName)Visit(Logger, context.schema);

            if (context.catalog is not null)
                name.Schema.Database = (DatabaseName)Visit(Logger, context.catalog);
        }

        Logger.NestEnd();
        return name;
    }
}