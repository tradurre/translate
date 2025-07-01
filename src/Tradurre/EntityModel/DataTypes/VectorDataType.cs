// <copyright file="VectorDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a VECTOR (4 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/vector-data-type"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class VectorDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VectorDataType"/> class.
    /// </summary>
    public VectorDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="VectorDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public VectorDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="VectorDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public VectorDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="VectorDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public VectorDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}