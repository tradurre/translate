// <copyright file="TypeName.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents the name of a type object.
/// </summary>
/// <remarks>
/// DuckDB: CREATE TYPE https://duckdb.org/docs/stable/sql/statements/create_type
/// DuckDB: DROP TYPE https://duckdb.org/docs/stable/sql/statements/drop
/// </remarks>
public sealed class TypeName : Identifier
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TypeName"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the type.</param>
    /// <param name="source">The <see cref="Source"/> for the object.</param>
    public TypeName(string name, Source source)
        : base(name, source)
    {
    }

    /// <summary>
    /// Gets or sets the schema for the identifier.
    /// </summary>
    public SchemaName? Schema { get; set; }
}