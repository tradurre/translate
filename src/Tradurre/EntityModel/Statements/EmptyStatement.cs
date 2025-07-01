// <copyright file="Statement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an empty or termination (;) SQL Statement.
/// </summary>
public sealed class EmptyStatement : Statement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmptyStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public EmptyStatement(Source source)
        : base(source)
    {
    }
}