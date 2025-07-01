// <copyright file="BigSerialDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a BIGSERIAL (8 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-numeric.html" />.
/// </remarks>
public sealed class BigSerialDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BigSerialDataType"/> class.
    /// </summary>
    public BigSerialDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BigSerialDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BigSerialDataType(Source source)
        : base(source)
    {
    }
}