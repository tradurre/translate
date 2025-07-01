// <copyright file="IWriter.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Defines the base implementation of an abstract tree language wrtier.
/// </summary>
public interface IWriter
{
    /// <summary>
    /// Writes the specified collection of <see cref="Expression"/> objects to the language target.
    /// </summary>
    /// <param name="statements">The statements to write out.</param>
    /// <returns>A collection of translated statements.</returns>
    WriteResult Write(List<Fragment> statements);
}