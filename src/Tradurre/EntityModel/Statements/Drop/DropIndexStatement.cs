// <copyright file="DropIndexStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DROP INDEX statement.
/// </summary>
/// <remarks>
/// DuckDB: DROP INDEX https://duckdb.org/docs/stable/sql/statements/drop
/// </remarks>
public sealed class DropIndexStatement : DropIfExistsStatement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DropIndexStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropIndexStatement(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DropIndexStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summaryIndexName
    /// <param name="name">The <see cref="FunctionName"/> for the statement.</param>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropIndexStatement(IndexName name, Source source)
        : base(source)
    {
        ArgumentNullException.ThrowIfNull(name, nameof(name));
        Name = name;
    }

    /// <summary>
    /// Gets or sets the name for the statement.
    /// </summary>
    public IndexName? Name { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DropOption"/> for the statement.
    /// </summary>
    public DropOption? Option { get; set; }
}