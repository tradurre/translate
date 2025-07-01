// <copyright file="IParser.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Defines the base implementation of a language parser.
/// </summary>
public interface IParser
{
    /// <summary>
    /// Parses the statement for correctness.
    /// </summary>
    /// <param name="statement">The statement to translate.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    ParseResult Parse(string statement);
}