// <copyright file="Statement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a SQL Statement.
/// </summary>
public abstract class Statement : Fragment
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Statement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    protected Statement(Source source)
        : base(source)
    {
    }
}