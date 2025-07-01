// <copyright file="MacAddressDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a MAC address (6 byte) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-net-types.html" />.
/// </remarks>
public sealed class MacAddressDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MacAddressDataType"/> class.
    /// </summary>
    public MacAddressDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MacAddressDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public MacAddressDataType(Source source)
        : base(source)
    {
    }
}