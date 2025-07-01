// <copyright file="LineSegmentDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a geometric line segment (32 byte) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-geometric.html" />.
/// </remarks>
public sealed class LineSegmentDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LineSegmentDataType"/> class.
    /// </summary>
    public LineSegmentDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LineSegmentDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public LineSegmentDataType(Source source)
        : base(source)
    {
    }
}