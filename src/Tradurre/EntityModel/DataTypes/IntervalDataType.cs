// <copyright file="IntervalDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an INTERVAL (16 bytes) data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-92 standard as INTERVAL <interval qualifier>.
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-datetime.html" />.
/// </remarks>
public sealed class IntervalDataType : DataTypePrecision 
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IntervalDataType"/> class.
    /// </summary>
    public IntervalDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IntervalDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public IntervalDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IntervalDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public IntervalDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IntervalDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public IntervalDataType(int precision, Source source)
        : base(precision, source)
    {
    }

    /// <summary>
    /// Gets or sets the optional field attribute for an interval.
    /// </summary>
    public IntervalType? Field { get; set; }


    /// <summary>
    /// Gets or sets the optional field attribute for an interval.
    /// </summary>
    public IntervalType? ToField { get; set; }
}