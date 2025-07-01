// <copyright file="SmallSerialDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a SMALLSERIAL (2 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-numeric.html" />.
/// </remarks>
public sealed class SmallSerialDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SmallSerialDataType"/> class.
    /// </summary>
    public SmallSerialDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SmallSerialDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public SmallSerialDataType(Source source)
        : base(source)
    {
    }
}