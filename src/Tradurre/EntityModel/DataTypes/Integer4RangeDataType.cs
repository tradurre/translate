// <copyright file="Integer4RangeDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an INT4 / INTEGER range type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/rangetypes.html" />.
/// </remarks>
public sealed class Integer4RangeDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Integer4RangeDataType"/> class.
    /// </summary>
    public Integer4RangeDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Integer4RangeDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public Integer4RangeDataType(Source source)
        : base(source)
    {
    }
}