// <copyright file="TextSearchVectorDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a vector data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-textsearch.html" />.
/// </remarks>
public sealed class TextSearchVectorDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TextSearchVectorDataType"/> class.
    /// </summary>
    public TextSearchVectorDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextSearchVectorDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public TextSearchVectorDataType(Source source)
        : base(source)
    {
    }
}