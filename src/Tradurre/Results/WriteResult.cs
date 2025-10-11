// <copyright file="WriteResult.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// The result of a language writing operation.
/// </summary>
public sealed class WriteResult
{
    /// <summary>
    /// Initialzies a new instance of the <see cref="WriteResult"/> class.
    /// </summary>
    public WriteResult()
    {
    }

    /// <summary>
    /// A collection of writing messages.
    /// </summary>
    public List<Message> Messages { get; } = [];

    /// <summary>
    /// Gets a collection of <see cref="Statement"/> from the operation.
    /// </summary>
    public List<Statement> Statements { get; } = [];
}