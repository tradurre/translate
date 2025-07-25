// <copyright file="DropViewStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DROP VIEW statement.
/// </summary>
/// <remarks>
/// IBM DB2 12.1.0: DROP VIEW
/// MariaDB: DROP VIEW
/// MySql 9.3: DROP VIEW
/// Oracle 23: DROP VIEW
/// PostgreSQL 17.5: DROP VIEW https://www.postgresql.org/docs/current/sql-dropview.html
/// Snowflake: DROP VIEW
/// SQL Server 2022: DROP VIEW
/// Teradata Vantage 17.20: DROP VIEW
/// </remarks>
public sealed class DropViewStatement : DropIfExistsStatement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DropViewStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropViewStatement(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DropViewStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="name">The <see cref="ViewName"/> for the statement.</param>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropViewStatement(ViewName name, Source source)
        : base(source)
    {
        ArgumentNullException.ThrowIfNull(name, nameof(name));

        Names.Add(name);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DropViewStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    /// <param name="name">A collection of <see cref="ViewName"/> entities for the statement.</param>
    public DropViewStatement(List<ViewName> names, Source source)
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
    public List<ViewName> Names { get; } = [];

    /// <summary>
    /// Gets a collection of options for the statement.
    /// </summary>
    public List<DropDatabaseOption> Options { get; } = [];
}