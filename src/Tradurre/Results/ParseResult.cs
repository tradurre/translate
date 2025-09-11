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
    /// Gets any validation or parsing errors from a parse.
    /// </summary>
    public List<Error> Errors { get; } = [];

    /// <summary>
    /// Gets a collection of <see cref="Statement"/> from a parse.
    /// </summary>
    public List<Statement> Statements { get; } = [];

    /// <summary>
    /// Gets any validation or parsing warnings from a parse.
    /// </summary>
    public List<Warning> Warnings { get; } = [];
}