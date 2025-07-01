// <copyright file="ITranslator.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// The base definition of a translator.
/// </summary>
public interface ITranslator
{
    /// <summary>
    /// Parses one or more statements from the <see cref="SourceType"/>,
    /// </summary>
    /// <param name="source">The <see cref="SourceType"/> of the statement.</param>
    /// <param name="statement">The statement(s) to translate.</param>
    /// <returns>A <see cref="ParseResult"/>.</returns>
    ParseResult Parse(SourceType source, string statement);

    /// <summary>
    /// Translates one or more statements from the <see cref="SourceType"/> to the <see cref="TargetType"/>.
    /// </summary>
    /// <param name="source">The <see cref="SourceType"/> of the statement.</param>
    /// <param name="target">The <see cref="TargetType"/> to translate to.</param>
    /// <param name="statement">The statement(s) to translate.</param>
    /// <returns>A <see cref="TranslationResult"/>.</returns>
    TranslationResult Translate(SourceType source, TargetType target, string statement);
}