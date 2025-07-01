// <copyright file="DatabaseName.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents the name of a database object.
/// </summary>
/// <remarks>
/// PostgreSQL: CREATE DATABASE https://www.postgresql.org/docs/current/sql-createdatabase.html
/// PostgreSQL: DROP DATABASE https://www.postgresql.org/docs/current/sql-dropdatabase.html
/// SQL Server: CREATE DATABASE https://learn.microsoft.com/en-us/sql/t-sql/statements/create-database-transact-sql
/// SQL Server: DROP DATABASE https://learn.microsoft.com/en-us/sql/t-sql/statements/drop-database-transact-sql
/// </remarks>
public sealed class DatabaseName : Identifier
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DatabaseName"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the database.</param>
    /// <param name="source">The <see cref="Source"/> for the object.</param>
    public DatabaseName(string name, Source source)
        : base(name, source)
    {
    }
}