// <copyright file="CreateIfNotExistsStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a CREATE SQL IF NOT EXISTS statement.
/// </summary>
/// <remarks>
/// Initializes a new instance of the <see cref="CreateIfNotExistsStatement"/> class with the specified
/// <see cref="Source"/>.
/// </remarks>
/// <param name="source">The <see cref="Source"/> for the statement.</param>
public abstract class CreateIfNotExistsStatement(Source source)
    : CreateStatement(source)
{
    /// <summary>
    /// A flag that indicates to do nothing (except issuing a notice) if a schema with the same name already exists.
    /// </summary>
    public bool? IfNotExists { get; set; }
}