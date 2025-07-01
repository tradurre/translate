// <copyright file="DateDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DATE (3 bytes) data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-92 standard as DATE.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/date-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-datetime.html" />
/// </remarks>
public sealed class DateDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DateDataType"/> class.
    /// </summary>
    public DateDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DateDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DateDataType(Source source)
        : base(source)
    {
    }
}