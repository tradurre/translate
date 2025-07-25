// <copyright file="DropSchemaStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DROP SCHEMA statement.
/// </summary>
/// <remarks>
/// IBM DB2 12.1.0: DROP SCHEMA
/// MariaDB: DROP SCHEMA
/// MySql 9.3: DROP SCHEMA
/// Oracle 23: DROP SCHEMA
/// PostgreSQL 17.5: DROP SCHEMA https://www.postgresql.org/docs/current/sql-dropschema.html
/// Snowflake: DROP SCHEMA
/// SQL Server 2022: DROP SCHEMA
/// Teradata Vantage 17.20: DROP SCHEMA
/// </remarks>
public sealed class DropSchemaStatement : DropIfExistsStatement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DropSchemaStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropSchemaStatement(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DropSchemaStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="name">The <see cref="SchemaName"/> for the statement.</param>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropSchemaStatement(SchemaName name, Source source)
        : base(source)
    {
        ArgumentNullException.ThrowIfNull(name, nameof(name));

        Names.Add(name);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DropSchemaStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    /// <param name="name">A collection of <see cref="SchemaName"/> entities for the statement.</param>
    public DropSchemaStatement(List<SchemaName> names, Source source)
        : base(source)
    {
        ArgumentNullException.ThrowIfNull(source, nameof(source));

        Names.AddRange(names);
    }

    /// <summary>
    /// Gets or sets a flag that indicates if all active connections should be terminated.
    /// </summary>
    public bool? Force { get; set; }

    /// <summary>
    /// Gets a collection of names of databases to drop.
    /// </summary>
    public List<SchemaName> Names { get; } = [];

    /// <summary>
    /// Gets or sets the <see cref="DropSchemaOption"/> for the statement.
    /// </summary>
    public DropSchemaOption? Options { get; set; }
}