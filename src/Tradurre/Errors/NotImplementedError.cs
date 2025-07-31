// <copyright file="NotImplementedError.cs">
// All rights reserved.
// </copyright>

using System.Runtime.Serialization;

namespace Tradurre;

/// <summary>
/// Represents a translation error when the tranlsation is not complete.
/// </summary>
public sealed class NotImplementedError : Error
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NotImplementedError"/> class with the specified identifier.
    /// </summary>
    /// <param name="id">The identifier for the error.</param>
    public NotImplementedError(int id)
        : base(id)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NotImplementedError"/> class with the specified identifier and message.
    /// </summary>
    /// <param name="id">The identifier for the error.</param>
    /// <param name="message">The error message.</param>
    public NotImplementedError(int id, string message)
        : this(id)
    {
        Message = message;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NotImplementedError"/> class with the specified identifier, message, file path, and help URL.
    /// </summary>
    /// <param name="id">The identifier for the error.</param>
    /// <param name="message">The error message.</param>
    /// <param name="file">The file name the error originated from.</param>
    /// <param name="helpUrl">The help URL for more information.</param>
    public NotImplementedError(int id, string message, string? file, string? helpUrl)
        : this(id)
    {
        Message = message;
        File = file;
        HelpURL = helpUrl;
    }
}