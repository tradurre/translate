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
    /// Gets a collection of <see cref="FileResult"/> from the translation.
    /// </summary>
    public List<FileResult> Files { get; } = [];
}