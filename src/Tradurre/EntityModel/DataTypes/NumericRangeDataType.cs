// <copyright file="NumericRangeDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a NUMERIC range type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/rangetypes.html" />.
/// </remarks>
public sealed class NumericRangeDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NumericRangeDataType"/> class.
    /// </summary>
    public NumericRangeDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NumericRangeDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public NumericRangeDataType(Source source)
        : base(source)
    {
    }
}