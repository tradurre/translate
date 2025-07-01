// <copyright file="CidrDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an IPv4 or IPv6 (7 or 19 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-net-types.html" />.
/// </remarks>
public sealed class CidrDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CidrDataType"/> class.
    /// </summary>
    public CidrDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CidrDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public CidrDataType(Source source)
        : base(source)
    {
    }
}