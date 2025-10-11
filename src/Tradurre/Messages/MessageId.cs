// <copyright file="MessageId.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// The identifier for a class of error or warning.
/// </summary>
public enum MessageId
{
    /// <summary>
    /// Internal Errors
    /// </summary>
    Internal = 0001,

    // Object Name Errors (0500 - 0600)

    // Data Type Errors (0700 - 0800)
    DataTypeNotSupported = 0700,
    DataTypePrecision = 0701,
    DataTypeScale = 0702,
}