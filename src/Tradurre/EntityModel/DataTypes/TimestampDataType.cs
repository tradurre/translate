// <copyright file="TimestampDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a TIMESTAMP data type with optional precision and flag for including/excluding timezone information.
/// </summary>
/// <remarks>
/// Defined in the SQL-92 standard as TIMESTAMP [ <left paren> <time precision> <right paren> ] [ WITH TIME ZONE ].
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/datetimeoffset-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-datetime.html" />
/// </remarks>
public sealed class TimestampDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TimestampDataType"/> class.
    /// </summary>
    public TimestampDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TimestampDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public TimestampDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Gets or sets the precision for the data type.
    /// </summary>
    public short? Precision { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="TimeZoneFlag"/> for the data type.
    /// </summary>
    public TimeZoneFlag TimeZoneFlag { get; set; } = TimeZoneFlag.NotDefined;
}