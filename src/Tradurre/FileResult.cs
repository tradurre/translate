// <copyright file="FileResult.cs">
// All rights reserved.
// </copyright>


namespace Tradurre;

/// <summary>
/// Initialzies a new instance of the <see cref="FileResult"/> class.
/// </summary>
public sealed class FileResult(string name)
{
    /// <summary>
    /// Gets or sets the Name of the file parsed.
    /// </summary>
    public string Name { get; set; } = name;

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
}