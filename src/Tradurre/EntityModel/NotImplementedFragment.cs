// <copyright file="NotImplementedFragment.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a SQL fragment that has not yet been implemented.
/// </summary>
public sealed class NotImplementedFragment : Statement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NotImplementedFragment"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public NotImplementedFragment(Source source)
        : base(source)
    {
        // TODO: Warnings.Add(new NotImplementedWarning(source.Value), string.Empty);
    }
}