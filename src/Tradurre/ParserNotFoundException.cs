// <copyright file="ParserNotFoundException.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents errors that occur when search for an <see cref="IParser"/> instance.
/// </summary>
public sealed class ParserNotFoundException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ParserNotFoundException"/>.
    /// </summary>
    public ParserNotFoundException()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ParserNotFoundException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public ParserNotFoundException(string? message)
        : base(message)
    {
    }
}
