// <copyright file="BinaryDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a BINARY (length bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/binary-and-varbinary-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class BinaryDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryDataType"/> class.
    /// </summary>
    public BinaryDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="length">The length for the data type.</param>
    public BinaryDataType(int length)
        : base(length)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BinaryDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="length">The length for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BinaryDataType(int length, Source source)
        : base(length, source)
    {
    }
}