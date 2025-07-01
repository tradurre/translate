// <copyright file="BinaryJsonDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a Binary JSON data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-json.html" />.
/// </remarks>
public sealed class BinaryJsonDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryJsonDataType"/> class.
    /// </summary>
    public BinaryJsonDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryJsonDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BinaryJsonDataType(Source source)
        : base(source)
    {
    }
}