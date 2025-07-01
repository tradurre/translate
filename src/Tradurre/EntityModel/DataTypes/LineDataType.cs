// <copyright file="LineDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a geometric line (24 byte) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-geometric.html" />
/// </remarks>
public sealed class LineDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LineDataType"/> class.
    /// </summary>
    public LineDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="LineDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public LineDataType(Source source)
        : base(source)
    {
    }
}