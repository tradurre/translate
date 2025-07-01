// <copyright file="BoxDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a geometric box (32 byte) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-geometric.html" />.
/// </remarks>
public sealed class BoxDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BoxDataType"/> class.
    /// </summary>
    public BoxDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BoxDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BoxDataType(Source source)
        : base(source)
    {
    }
}