// <copyright file="IndexName.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents the name of an index object.
/// </summary>
/// <remarks>
/// DuckDB: CREATE FUNCTION https://duckdb.org/docs/stable/sql/statements/create_index
/// DuckDB: DROP INDEX https://duckdb.org/docs/stable/sql/statements/drop
/// </remarks>
public sealed class IndexName : Identifier
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IndexName"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the index.</param>
    /// <param name="source">The <see cref="Source"/> for the object.</param>
    public IndexName(string name, Source source)
        : base(name, source)
    {
    }
}