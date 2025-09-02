// <copyright file="TerminationStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an empty or termination (;) SQL Statement.
/// </summary>
public sealed class TerminationStatement : Statement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TerminationStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public TerminationStatement(Source source)
        : base(source)
    {
    }
}