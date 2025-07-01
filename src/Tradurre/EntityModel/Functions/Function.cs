// <copyright file="Function.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// The base definition of any function.
/// </summary>
public abstract class Function : Expression
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Function"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the <see cref="Function"/>.</param>
    public Function(Source source)
        : base(source)
    {
    }
}