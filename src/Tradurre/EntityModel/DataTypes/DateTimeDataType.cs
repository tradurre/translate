// <copyright file="DateTimeDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DATETIME (8 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/datetime-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class DateTimeDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DateTimeDataType"/> class.
    /// </summary>
    public DateTimeDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DateTimeDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DateTimeDataType(Source source)
        : base(source)
    {
    }
}