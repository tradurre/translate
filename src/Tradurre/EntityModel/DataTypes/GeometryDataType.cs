// <copyright file="GeometryDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a GEOMETRY data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/spatial-geometry/spatial-types-geometry-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class GeometryDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GeometryDataType"/> class.
    /// </summary>
    public GeometryDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GeometryDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public GeometryDataType(Source source)
        : base(source)
    {
    }
}