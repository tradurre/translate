// <copyright file="SchemaName.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents the name of a schema object.
/// </summary>
/// <remarks>
/// PostgreSQL: CREATE SCHEMA https://www.postgresql.org/docs/current/sql-createschema.html
/// PostgreSQL: DROP SCHEMA https://www.postgresql.org/docs/current/sql-dropschema.html
/// SQL Server: CREATE SCHEMA https://learn.microsoft.com/en-us/sql/t-sql/statements/create-schema-transact-sql
/// SQL Server: DROP SCHEMA https://learn.microsoft.com/en-us/sql/t-sql/statements/drop-schema-transact-sql
/// </remarks>
public sealed class SchemaName : Identifier
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SchemaName"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the database.</param>
    /// <param name="source">The <see cref="Source"/> for the object.</param>
    public SchemaName(string name, Source source)
        : base(name, source)
    {
    }
}