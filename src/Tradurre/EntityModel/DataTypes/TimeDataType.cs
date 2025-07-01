// <copyright file="TimeDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a TIME (5 bytes) data type with optional precision and flag for including/excluding timezone information.
/// </summary>
/// <remarks>
/// Defined in the SQL-92 standard as TIME [ <left paren> <time precision> <right paren> ] [ WITH TIME ZONE ].
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/time-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-datetime.html" />
/// </remarks>
public sealed class TimeDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TimeDataType"/> class.
    /// </summary>
    public TimeDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public TimeDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public TimeDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TimeDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public TimeDataType(int precision, Source source)
        : base(precision, source)
    {
    }

    /// <summary>
    /// Gets or sets the <see cref="TimeZoneFlag"/> for the data type.
    /// </summary>
    public TimeZoneFlag TimeZoneFlag { get; set; } = TimeZoneFlag.NotDefined;
}