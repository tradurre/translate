// <copyright file="BitVaryingDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a BIT VARYING data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-bit.html" />.
/// </remarks>
public sealed class BitVaryingDataType : DataTypePrecision
{
   /// <summary>
    /// Initializes a new instance of the <see cref="BitVaryingDataType"/> class.
    /// </summary>
    public BitVaryingDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BitVaryingDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public BitVaryingDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BitVaryingDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BitVaryingDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BitVaryingDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BitVaryingDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}