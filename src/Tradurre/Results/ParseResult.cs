// <copyright file="ParseResult.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// The result of a language parse.
/// </summary>
public sealed class ParseResult
{
    /// <summary>
    /// Initialzies a new instance of the <see cref="ParseResult"/> class.
    /// </summary>
    public ParseResult()
    {
    }

    /// <summary>
    /// A collection of parsing or validation messages.
    /// </summary>
    public List<Message> Messages { get; } = [];

    /// <summary>
    /// Gets a collection of <see cref="Statement"/> from a parse.
    /// </summary>
    public List<Statement> Statements { get; } = [];
}