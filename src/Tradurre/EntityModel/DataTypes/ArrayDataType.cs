// <copyright file="ArrayDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an Array data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-99 standard as ARRAY.
/// Microsoft SQL Server: N/A
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/arrays.html" />
/// </remarks>
public sealed class ArrayDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ArrayDataType"/> class.
    /// </summary>
    public ArrayDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ArrayDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public ArrayDataType(Source source)
        : base(source)
    {
    }
}