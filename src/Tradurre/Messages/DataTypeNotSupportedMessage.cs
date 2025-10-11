// <copyright file="DataTypeNotSupportedMessage.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// A message when a data type is not supported in a translation.
/// </summary>
public sealed class DataTypeNotSupportedMessage : Message
{
    /// <summary>
    /// Initialize a new instance of the <see cref="DataTypeNotSupportedMessage"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/>.</param>
    public DataTypeNotSupportedMessage(Source source)
        : base(MessageId.DataTypeNotSupported, MessageType.Error, source)
    {
    }
}