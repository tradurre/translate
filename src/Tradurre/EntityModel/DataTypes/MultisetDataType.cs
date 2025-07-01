// <copyright file="MultisetDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a MULTISET data type.
/// </summary>
/// <remarks>
/// Defined in the SQL:2003 standard as MULTISET.
/// Microsoft SQL Server: N/A.
/// Oracle: 
/// PostgreSQL: N/A.
/// </remarks>
public sealed class MultisetDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MultisetDataType"/> class.
    /// </summary>
    public MultisetDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MultisetDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public MultisetDataType(Source source)
        : base(source)
    {
    }
}