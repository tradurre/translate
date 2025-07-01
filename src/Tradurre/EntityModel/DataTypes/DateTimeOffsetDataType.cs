// <copyright file="DateTimeOffsetDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DATETIMEOFFSET (10 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/datetimeoffset-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class DateTimeOffsetDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DateTimeOffsetDataType"/> class.
    /// </summary>
    public DateTimeOffsetDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DateTimeOffsetDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public DateTimeOffsetDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DateTimeOffsetDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DateTimeOffsetDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DateTimeOffsetDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DateTimeOffsetDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}