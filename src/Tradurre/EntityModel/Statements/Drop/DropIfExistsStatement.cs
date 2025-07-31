// <copyright file="DropIfExistsStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DROP SQL statement with the IF EXISTS qualifer.
/// </summary>
public abstract class DropIfExistsStatement : CreateStatement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DropIfExistsStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropIfExistsStatement(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Gets or sets a flag that indicates if the IF EXISTS flag is set for the statement.
    /// </summary>
    public bool IfExists { get; set; }
}