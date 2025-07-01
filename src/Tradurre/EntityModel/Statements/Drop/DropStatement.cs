// <copyright file="DropStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DROP SQL statement.
/// </summary>
public abstract class DropStatement : Statement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DropStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public DropStatement(Source source)
        : base(source)
    {
    }
}