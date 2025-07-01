// <copyright file="NotImplementedWarning.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an internal translation warning.
/// </summary>
public sealed class NotImplementedWarning : Warning
{
    private static readonly int WARNING_ID = 9999;

    /// <summary>
    /// Initializes a new instance of the <see cref="NotImplementedWarning"/> class with the specified message.
    /// </summary>
    /// <param name="source">The source not implemented.</param>
    public NotImplementedWarning(string source)
        : base(WARNING_ID)
    {
        Message = string.Format(WarningMessages.NotImplementedWarning, source);
    }
}