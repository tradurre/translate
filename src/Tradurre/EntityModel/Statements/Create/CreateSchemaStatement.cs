// <copyright file="CreateSchemaStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a CREATE SCHEMA statement.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="CreateSchemaStatement"/> class with the specified
/// <see cref="Source"/>.
/// </remarks>
public sealed class CreateSchemaStatement : CreateIfNotExistsStatement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSchemaStatement"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public CreateSchemaStatement(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateSchemaStatement"/> class with the specified <see cref="SchemaName"/> and <see cref="Source"/>.
    /// </summary>
    /// <param name="name">The <see cref="SchemaName"/> for the statement.</param>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public CreateSchemaStatement(SchemaName name, Source source)
        : base(source)
    {
        Name = name;
    }

    /// <summary>
    /// Gets or sets the <see cref="SchemaName"/> for the statement.
    /// </summary>
    public SchemaName? Name { get; set; }
}