// <copyright file="SequenceName.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents the name of a sequence object.
/// </summary>
/// <remarks>
/// DuckDB: CREATE SEQUENCE https://duckdb.org/docs/stable/sql/statements/create_sequence
/// DuckDB: DROP SEQUENCE https://duckdb.org/docs/stable/sql/statements/drop
/// </remarks>
public sealed class SequenceName : Identifier
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SequenceName"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the sequence.</param>
    /// <param name="source">The <see cref="Source"/> for the object.</param>
    public SequenceName(string name, Source source)
        : base(name, source)
    {
    }
}