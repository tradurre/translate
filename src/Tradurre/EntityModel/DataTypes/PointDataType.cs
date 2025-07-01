// <copyright file="PointDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a geometric point (16 byte) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-geometric.html" />
/// </remarks>
public sealed class PointDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PointDataType"/> class.
    /// </summary>
    public PointDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PointDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public PointDataType(Source source)
        : base(source)
    {
    }
}