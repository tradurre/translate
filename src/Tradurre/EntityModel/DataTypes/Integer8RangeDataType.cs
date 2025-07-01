// <copyright file="Integer8RangeDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an INT8 / BIGINT range type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/rangetypes.html" />.
/// </remarks>
public sealed class Integer8RangeDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Integer8RangeDataType"/> class.
    /// </summary>
    public Integer8RangeDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Integer8RangeDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public Integer8RangeDataType(Source source)
        : base(source)
    {
    }
}