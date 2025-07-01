// <copyright file="TextSearchQueryDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a text search query data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-textsearch.html" />.
/// </remarks>
public sealed class TextSearchQueryDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TextSearchQueryDataType"/> class.
    /// </summary>
    public TextSearchQueryDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextSearchQueryDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public TextSearchQueryDataType(Source source)
        : base(source)
    {
    }
}