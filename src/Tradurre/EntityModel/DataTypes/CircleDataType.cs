// <copyright file="CircelDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a geometric circle (24 byte) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-geometric.html" />.
/// </remarks>
public sealed class CircelDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CircelDataType"/> class.
    /// </summary>
    public CircelDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CircelDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public CircelDataType(Source source)
        : base(source)
    {
    }
}