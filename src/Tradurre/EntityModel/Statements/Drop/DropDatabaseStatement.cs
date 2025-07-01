// <copyright file="DropDatabaseStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DROP DATABASE statement.
/// </summary>
/// <remarks>
/// IBM DB2 12.1.0: DROP DATABASE https://www.ibm.com/docs/en/db2/12.1.0?topic=commands-drop-database
/// MariaDB: DROP DATABASE https://mariadb.com/kb/en/drop-database/
/// MySql 9.3: DROP DATABASE https://dev.mysql.com/doc/refman/9.3/en/drop-database.html
/// Oracle 23: DROP DATABASE https://docs.oracle.com/en/database/oracle/oracle-database/23/sqlrf/DROP-DATABASE.html
/// PostgreSQL 17.5: DROP DATABASE https://www.postgresql.org/docs/current/sql-dropdatabase.html
/// Snowflake: DROP DATABASE https://docs.snowflake.com/en/sql-reference/sql/drop-database
/// SQL Server 2022: DROP DATABASE https://learn.microsoft.com/en-us/sql/t-sql/statements/drop-database-transact-sql
/// Teradata Vantage 17.20: DROP DATABASE https://docs.teradata.com/r/Enterprise_IntelliFlex_VMware/SQL-Data-Definition-Language-Syntax-and-Examples/Database-Statements/DROP-DATABASE
/// </remarks>
public sealed class DropDatabaseStatement : DropIfExistsStatement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DropDatabaseStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropDatabaseStatement(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DropDatabaseStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="name">The <see cref="DatabaseName"/> for the statement.</param>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropDatabaseStatement(DatabaseName name, Source source)
        : base(source)
    {
        ArgumentNullException.ThrowIfNull(name, nameof(name));

        Names.Add(name);
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DropDatabaseStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    /// <param name="name">A collection of <see cref="DatabaseName"/> entities for the statement.</param>
    public DropDatabaseStatement(List<DatabaseName> names, Source source)
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
    public List<DatabaseName> Names { get; } = [];

    /// <summary>
    /// Gets a collection of options for the statement.
    /// </summary>
    public List<DropDatabaseOption> Options { get; } = [];
}