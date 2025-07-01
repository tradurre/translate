// <copyright file="SmallDateTimeDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a SMALLDATETIME (4 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/smalldatetime-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class SmallDateTimeDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SmallDateTimeDataType"/> class.
    /// </summary>
    public SmallDateTimeDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SmallDateTimeDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public SmallDateTimeDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SmallDateTimeDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public SmallDateTimeDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SmallDateTimeDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public SmallDateTimeDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}