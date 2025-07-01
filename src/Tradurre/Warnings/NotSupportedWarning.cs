// <copyright file="NotSupportedWarning.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a warning that indicates that a fragment has a partial or full not-supported output.
/// </summary>
public sealed class NotSupportedWarning : Warning
{
    private static readonly int WARNING_ID = 0001;

    /// <summary>
    /// Initializes a new instance of the <see cref="NotSupportedWarning"/> class with the specified message.
    /// </summary>
    /// <param name="source">The source not implemented.</param>
    /// <param name="message">Any additional message for the statement..</param>
    public NotSupportedWarning(string source, string message)
        : base(WARNING_ID)
    {
        Message = string.Format(WarningMessages.NotSupportedWarning, source, message);
    }
}