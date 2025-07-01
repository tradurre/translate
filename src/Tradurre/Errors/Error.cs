// <copyright file="Error.cs">
// All rights reserved.
// </copyright>

using System.Runtime.Serialization;

namespace Tradurre;

/// <summary>
/// Represents a translation error in the framework.
/// </summary>
public abstract class Error : ISerializable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Error"/> class with the specified identifier.
    /// </summary>
    /// <param name="id">The identifier for the error.</param>
    public Error(int id)
        : base()
    {
        Id = id;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Error"/> class with the specified identifier and message.
    /// </summary>
    /// <param name="id">The identifier for the error.</param>
    /// <param name="message">The error message.</param>
    public Error(int id, string message)
        : this(id)
    {
        Message = message;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Error"/> class with the specified identifier, message, file path, and help URL.
    /// </summary>
    /// <param name="id">The identifier for the error.</param>
    /// <param name="message">The error message.</param>
    /// <param name="file">The file name the error originated from.</param>
    /// <param name="helpUrl">The help URL for more information.</param>
    public Error(int id, string message, string? file, string? helpUrl)
        : this(id)
    {
        Message = message;
        File = file;
        HelpURL = helpUrl;
    }

    /// <summary>
    /// Gets the object data for serialization.
    /// </summary>
    /// <param name="info">The <see cref="SerializationInfo"/>.</param>
    /// <param name="context">The <see cref="StreamingContext"/>.</param>
    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        if (info is null)
        {
            return;
        }

        ArgumentNullException.ThrowIfNull(info);

        info.AddValue("ClassName", nameof(Error));
        info.AddValue("FileName", File, typeof(string));
        info.AddValue("HelpURL", HelpURL, typeof(string));
        info.AddValue("Message", Message, typeof(string));
    }

    /// <summary>
    /// Gets or sets the identifier for the <see cref="Error"/>.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the file the <see cref="Error"/> was found in.
    /// </summary>
    public string? File { get; set; }

    /// <summary>
    /// Gets or sets the URL for help with the <see cref="Error"/>.
    /// </summary>
    public string? HelpURL { get; set; }

    /// <summary>
    /// Gets or sets the message for the <see cref="Error"/>.
    /// </summary>
    public string? Message { get; set; }
}
