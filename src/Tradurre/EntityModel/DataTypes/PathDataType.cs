// <copyright file="PathDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a geometric path (16+16n byte) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-geometric.html" />.
/// </remarks>
public sealed class PathDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PathDataType"/> class.
    /// </summary>
    public PathDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PathDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public PathDataType(Source source)
        : base(source)
    {
    }
}