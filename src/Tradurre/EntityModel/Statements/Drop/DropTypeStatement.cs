// <copyright file="DropTypeStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DROP TYPE statement.
/// </summary>
/// <remarks>
/// DuckDB: DROP TYPE https://duckdb.org/docs/stable/sql/statements/drop
/// </remarks>
public sealed class DropTypeStatement : DropIfExistsStatement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DropTypeStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropTypeStatement(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DropTypeStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="name">The <see cref="TypeName"/> for the statement.</param>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropTypeStatement(TypeName name, Source source)
        : base(source)
    {
        ArgumentNullException.ThrowIfNull(name, nameof(name));
        Name = name;
    }

    /// <summary>
    /// Gets or sets the <see cref="TypeName"/> to drop.
    /// </summary>
    public TypeName? Name { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="DropOption"/> for the statement.
    /// </summary>
    public DropOption? Option { get; set; }
}