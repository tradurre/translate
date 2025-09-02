// <copyright file="DropFunctionStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DROP FUNCTION statement.
/// </summary>
/// <remarks>
/// DuckDB: DROP FUNCTION https://duckdb.org/docs/stable/sql/statements/drop
/// </remarks>
public sealed class DropFunctionStatement : DropIfExistsStatement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DropFunctionStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropFunctionStatement(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DropFunctionStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="name">The <see cref="FunctionName"/> for the statement.</param>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropFunctionStatement(FunctionName name, Source source)
        : base(source)
    {
        ArgumentNullException.ThrowIfNull(name, nameof(name));
        Name = name;
    }

    /// <summary>
    /// Gets or sets the name for the statement.
    /// </summary>
    public FunctionName? Name { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DropOption"/> for the statement.
    /// </summary>
    public DropOption? Option { get; set; }
}