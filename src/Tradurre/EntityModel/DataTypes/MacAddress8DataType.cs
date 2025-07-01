// <copyright file="MacAddress8DataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a MAC EUI-64 format address (8 byte) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-net-types.html" />.
/// </remarks>
public sealed class MacAddress8DataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MacAddress8DataType"/> class.
    /// </summary>
    public MacAddress8DataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MacAddress8DataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public MacAddress8DataType(Source source)
        : base(source)
    {
    }
}