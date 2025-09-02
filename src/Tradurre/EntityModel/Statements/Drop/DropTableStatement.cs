// <copyright file="DropTableStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DROP TABLE statement.
/// </summary>
/// <remarks>
/// DuckDB: DROP TABLE https://duckdb.org/docs/stable/sql/statements/drop
/// </remarks>
public sealed class DropTableStatement : DropIfExistsStatement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DropTableStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropTableStatement(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DropTableStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="name">The <see cref="TableName"/> for the statement.</param>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropTableStatement(TableName name, Source source)
        : base(source)
    {
        ArgumentNullException.ThrowIfNull(name, nameof(name));
        Name = name;
    }

    /// <summary>
    /// Gets or sets the <see cref="TableName"/> to drop.
    /// </summary>
    public TableName? Name { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DropOption"/> for the statement.
    /// </summary>
    public DropOption? Option { get; set; }
}