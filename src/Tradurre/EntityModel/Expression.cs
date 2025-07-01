// <copyright file="Expression.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a SQL expression.
/// </summary>
public abstract class Expression : Fragment
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Expression"/> class.
    /// </summary>
    public Expression()
        : base(new Source())
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Expression"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the <see cref="Expression"/>.</param>
    public Expression(Source source)
        : base(source)
    {
    }
}