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
    /// Gets a collection of <see cref="FileResult"/> objects from a parse.
    /// </summary>
    public List<FileResult> Files { get; } = [];

    /// <summary>
    /// Gets a collection of <see cref="Statement"/> from a parse.
    /// </summary>
    public List<Statement> Statements
    { get { return Files.SelectMany(f => f.Statements).ToList(); } }

    /// <summary>
    /// Gets any validation or parsing errors from a parse.
    /// </summary>
    public List<Error> Errors
    { get { return [.. Files.SelectMany(f => f.Errors)]; } }

    /// <summary>
    /// Gets any validation or parsing warnings from a parse.
    /// </summary>
    public List<Warning> Warnings
    { get { return [.. Files.SelectMany(f => f.Warnings)]; } }

    public void Add(ParseResult result)
    {
        if (result == null)
            return;

        Errors.AddRange(result.Errors);
        Statements.AddRange(result.Statements);
        Warnings.AddRange(result.Warnings);
    }
}