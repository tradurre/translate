// <copyright file="TimestampRangeDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a TIMESTAMP (WITH TIME ZONE)? range type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/rangetypes.html" />.
/// </remarks>
public sealed class TimestampRangeDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TimestampRangeDataType"/> class.
    /// </summary>
    public TimestampRangeDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TimestampRangeDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public TimestampRangeDataType(Source source)
        : base(source)
    {
    }
}