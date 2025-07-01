// <copyright file="PolygonDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a geometric polygon (40+16n byte) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-geometric.html" />.
/// </remarks>
public sealed class PolygonDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PolygonDataType"/> class.
    /// </summary>
    public PolygonDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PolygonDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public PolygonDataType(Source source)
        : base(source)
    {
    }
}