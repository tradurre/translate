// <copyright file="CreateTypeAsDataTypeStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a CREATE TYPE ...AS data type statement.
/// </summary>
/// <remarks>
///
/// Initializes a new instance of the <see cref="CreateTypeAsDataTypeStatement"/> class with the specified
/// <see cref="Source"/>.
/// </remarks>
/// <seealso cref="https://duckdb.org/docs/stable/sql/statements/create_type"/>
public sealed class CreateTypeAsDataTypeStatement : CreateTypeStatement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateTypeAsDataTypeStatement"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public CreateTypeAsDataTypeStatement(TypeName name, DataType type, Source source)
        : base(name, source)
    {
        Type = type;
    }

    /// <summary>
    /// Gets or sets the <see cref="DataType"/> for the statement.
    /// </summary>
    public DataType Type { get; set; }
}