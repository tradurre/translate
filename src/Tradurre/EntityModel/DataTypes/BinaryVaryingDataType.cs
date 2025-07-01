// <copyright file="BinaryVaryingDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a VARYING BINARY / VARBINARY (length + 2 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/binary-and-varbinary-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class BinaryVaryingDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryVaryingDataType"/> class.
    /// </summary>
    public BinaryVaryingDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryVaryingDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="length">The length for the data type.</param>
    public BinaryVaryingDataType(int length)
        : base(length)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryVaryingDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BinaryVaryingDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryVaryingDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="length">The length for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BinaryVaryingDataType(int length, Source source)
        : base(length, source)
    {
    }

    /// <summary>
    /// Gets or sets a flag that indicates if the (MAX) value is set.
    /// </summary>
    public bool? IsMax { get; set; }
}