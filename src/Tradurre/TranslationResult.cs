// <copyright file="TranslationResult.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// The result of a translation including parse and write operations.
/// </summary>
public sealed class TranslationResult
{
    /// <summary>
    /// Initialzies a new instance of the <see cref="TranslationResult"/> class.
    /// </summary>
    public TranslationResult()
    {
    }

    /// <summary>
    /// Gets a collection of <see cref="Statement"/> from the translation.
    /// </summary>
    public List<Statement> Statements { get; } = [];

    /// <summary>
    /// Gets any validation or parsing errors associated with this operation.
    /// </summary>
    public List<Error> Errors { get; } = [];

    /// <summary>
    /// Gets any validation or parsing warnings associated with this operation.
    /// </summary>
    public List<Warning> Warnings { get; } = [];

    /// <summary>
    /// Adds the <see cref="ParseResult"/> <see cref="ParseResult.Errors"/> and <see cref="ParseResult.Warnings"/> to the current result.
    /// </summary>
    /// <param name="result">The <see cref="ParseResult"/> to evaluate.</param>
    internal void Add(ParseResult result)
    {
        if (result == null)
            return;

        if (result.Errors.Count > 0)
            Errors.AddRange(result.Errors);

        if (result.Warnings.Count > 0)
            Warnings.AddRange(result.Warnings);
    }

    /// <summary>
    /// Adds the <see cref="WriteResult"/> <see cref="WriteResult.Errors"/> and <see cref="WriteResult.Warnings"/> to the current result.
    /// </summary>
    /// <param name="result">The <see cref="WriteResult"/> to evaluate.</param>
    internal void Add(WriteResult result)
    {
        if (result == null)
            return;

        if (result.Errors.Count > 0)
            Errors.AddRange(result.Errors);

        if (result.Warnings.Count > 0)
            Warnings.AddRange(result.Warnings);
    }
}