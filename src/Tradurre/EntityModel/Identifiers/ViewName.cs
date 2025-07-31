// <copyright file="ViewName.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents the name of a database object.
/// </summary>
/// <remarks>
/// PostgreSQL: CREATE VIEW https://www.postgresql.org/docs/current/sql-createview.html
/// PostgreSQL: DROP VIEW https://www.postgresql.org/docs/current/sql-dropview.html
/// SQL Server: CREATE VIEW
/// SQL Server: DROP VIEW
/// </remarks>
public sealed class ViewName : Identifier
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ViewName"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the database.</param>
    /// <param name="source">The <see cref="Source"/> for the object.</param>
    public ViewName(string name, Source source)
        : base(name, source)
    {
    }

    /// <summary>
    /// Gets or sets the schema for the identifier.
    /// </summary>
    public SchemaName? Schema { get; set; }
}