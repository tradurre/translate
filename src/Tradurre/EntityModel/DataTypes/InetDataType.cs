// <copyright file="InetDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an IPv4 or IPv6 (7 or 19 bytes) hosts or networks data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-net-types.html" />.
/// </remarks>
public sealed class InetDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InetDataType"/> class.
    /// </summary>
    public InetDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="InetDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public InetDataType(Source source)
        : base(source)
    {
    }
}