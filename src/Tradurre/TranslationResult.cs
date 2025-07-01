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
    public Dictionary<string, string> Errors { get; } = new(StringComparer.Ordinal);

    /// <summary>
    /// Gets any validation or parsing warnings associated with this operation.
    /// </summary>
    public Dictionary<string, string> Warnings { get; } = new(StringComparer.Ordinal);
}