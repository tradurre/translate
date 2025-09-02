// <copyright file="FunctionName.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents the name of a function object.
/// </summary>
/// <remarks>
/// DuckDB: CREATE FUNCTION
/// DuckDB: DROP FUNCTION https://duckdb.org/docs/stable/sql/statements/drop
/// </remarks>
public sealed class FunctionName : Identifier
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FunctionName"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the function.</param>
    /// <param name="source">The <see cref="Source"/> for the object.</param>
    public FunctionName(string name, Source source)
        : base(name, source)
    {
    }
}