// <copyright file="ServerName.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents the name of a server object.
/// </summary>
/// <remarks>
/// </remarks>
public sealed class ServerName : Identifier
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ServerName"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the server.</param>
    /// <param name="source">The <see cref="Source"/> for the object.</param>
    public ServerName(string name, Source source)
        : base(name, source)
    {
    }
}