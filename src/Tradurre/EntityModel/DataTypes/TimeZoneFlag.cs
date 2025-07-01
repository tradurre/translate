// <copyright file="TimeZoneFlag.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Defines a timze zone attribute for date time data types.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/time-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-datetime.html" />
/// </remarks>
public enum TimeZoneFlag
{
    NotDefined,

    WithoutTimeZone,

    WithTimeZone,
}