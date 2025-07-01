// <copyright file="ITokenExtensions.cs">
// All rights reserved.
// </copyright>

using Antlr4.Runtime;

namespace Tradurre;

/// <summary>
/// A set of extensions for <see cref="IToken"/> class.
/// </summary>
public static class ITokenExtensions
{
    /// <summary>
    /// Returns a flag that indicates if the <see cref="IToken"/> is not null.
    /// </summary>
    /// <param name="context">The <see cref="IToken"/> to examine.</param>
    /// <returns>A flag that indicates if the <see cref="IToken"/> is not null.</returns>
    internal static bool IsNotEmpty(this IToken context)
    {
        return context != null;
    }
}