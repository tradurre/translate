// <copyright file="IntervalType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Defines the interval attributes.
/// </summary>
/// <remarks>
/// Defined in the SQL-92 standard as YEAR | MONTH | DAY | HOUR | MINUTE.
/// Microsoft SQL Server: N/A
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-datetime.html" />
/// </remarks>
public enum IntervalType
{
    Day,

    Hour,

    Minute,

    Month,

    Second,

    Year,
}