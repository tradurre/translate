// <copyright file="AlterStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an ALTER SQL statement.
/// </summary>
public abstract class AlterStatement : Statement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public AlterStatement(Source source)
        : base(source)
    {
    }
}