// <copyright file="CreateTypeStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a CREATE TYPE statement.
/// </summary>
/// <remarks>
///
/// Initializes a new instance of the <see cref="CreateTypeStatement"/> class with the specified
/// <see cref="Source"/>.
/// </remarks>
/// <seealso cref="https://duckdb.org/docs/stable/sql/statements/create_type"/>
public abstract class CreateTypeStatement : CreateStatement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateTypeStatement"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public CreateTypeStatement(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateTypeStatement"/> class with the specified <see cref="TypeName"/> and <see cref="Source"/>.
    /// </summary>
    /// <param name="name">The <see cref="TypeName"/> for the statement.</param>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public CreateTypeStatement(TypeName name, Source source)
        : base(source)
    {
        Name = name;
    }

    /// <summary>
    /// Gets or sets the <see cref="TypeName"/> for the statement.
    /// </summary>
    public TypeName? Name { get; set; }

}