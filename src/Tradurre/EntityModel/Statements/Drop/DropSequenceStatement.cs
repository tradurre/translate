// <copyright file="DropSequenceStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DROP SEQUENCE statement.
/// </summary>
/// <remarks>
/// DuckDB: DROP SEQUENCE https://duckdb.org/docs/stable/sql/statements/drop
/// </remarks>
public sealed class DropSequenceStatement : DropIfExistsStatement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DropSequenceStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropSequenceStatement(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DropSequenceStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="name">The <see cref="SequenceName"/> for the statement.</param>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropSequenceStatement(SequenceName name, Source source)
        : base(source)
    {
        ArgumentNullException.ThrowIfNull(name, nameof(name));
        Name = name;
    }

    /// <summary>
    /// Gets or sets the <see cref="SequenceName"/> to drop.
    /// </summary>
    public SequenceName? Name { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DropOption"/> for the statement.
    /// </summary>
    public DropOption? Option { get; set; }
}