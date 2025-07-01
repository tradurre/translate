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
    /// Gets or sets the statement from the writer operation.
    /// </summary>
    public string Statement { get; set; } = string.Empty;

    /// <summary>
    /// Gets any validation or writer errors from the operation.
    /// </summary>
    public List<Error> Errors { get; } = [];

    /// <summary>
    /// Gets any validation or writer warnings from the operation.
    /// </summary>
    public List<Warning> Warnings { get; } = [];
}