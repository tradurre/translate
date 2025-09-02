// <copyright file="TableName.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents the name of a table object.
/// </summary>
/// <remarks>
/// DuckDB: CREATE TABLE https://duckdb.org/docs/stable/sql/statements/create_table
/// DuckDB: DROP TABLE https://duckdb.org/docs/stable/sql/statements/drop
/// </remarks>
public sealed class TableName : Identifier
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TableName"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the table.</param>
    /// <param name="source">The <see cref="Source"/> for the object.</param>
    public TableName(string name, Source source)
        : base(name, source)
    {
    }

    /// <summary>
    /// Gets or sets the schema for the identifier.
    /// </summary>
    public SchemaName? Schema { get; set; }
}