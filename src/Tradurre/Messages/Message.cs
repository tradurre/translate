// <copyright file="Message.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// A user facing message during the parse or translate phase.
/// </summary>
/// <remarks>
/// Based on the type, can return results that indicate information back to the user. For example, an error can translate out to:
/// TRANSLATION_ERROR('CA0001', 'FLOAT(54)', 'FLOATs cannot be greater than 53.');
/// or
/// TRANSLATION_WARNING('CA0011', 'INTERVAL', 'The INTERVAL data type is not supported. The single column [column1] has been converted to [column1_begin] and [column1_end].');
/// </remarks>
public abstract class Message
{
    public Message(MessageId id, MessageType type, Source source, string value = "")
    {
        Id = id;
        Source = source;
        Type = type;
        Value = value;
    }

    /// <summary>
    /// Gets or sets the <see cref="MessageId"/> for the <see cref="Message"/>.
    /// </summary>
    public MessageId Id { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Source"/> for the <see cref="Message"/>.
    /// </summary>
    public Source Source { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="MessageType"/> for the <see cref="Message"/>.
    /// </summary>
    public MessageType Type { get; set; }

    /// <summary>
    /// Gets or sets the value for the <see cref="Message"/>.
    /// </summary>
    public string Value { get; set; }
}
