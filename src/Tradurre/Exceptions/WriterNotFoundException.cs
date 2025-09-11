// <copyright file="WriterNotFoundException.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents errors that occur when search for an <see cref="IWriter"/> instance.
/// </summary>
public sealed class WriterNotFoundException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WriterNotFoundException"/>.
    /// </summary>
    public WriterNotFoundException()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="WriterNotFoundException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public WriterNotFoundException(string? message)
        : base(message)
    {
    }
}
