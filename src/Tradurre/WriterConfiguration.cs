// <copyright file="IWriter.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Defines options for the <see cref="IWriter"/>
/// </summary>
public sealed class WriterConfiguration
{
    /// <summary>
    /// Initialzies a new instance of the <see cref="WriterConfiguration"/> class.
    /// </summary>
    public WriterConfiguration()
    {
    }

    public bool UseQuotedIdentifiers { get; set; }
}