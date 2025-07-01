// <copyright file="BinaryLargeObjectDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a BINARY LARGE OBJECT (CLOB) (precision) data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-99 standard as BINARY LARGE OBJECT <left paren> <length> <right paren>.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/relational-databases/blob/compare-options-for-storing-blobs-sql-server"/>
///                       Note: There is no direct BLOB data type.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-binary.html" /> for data up to 4GB. For larger data, see 
///  <see href="https://www.postgresql.org/docs/current/largeobjects.html"/>.
/// </remarks>
public sealed class BinaryLargeObjectDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryLargeObjectDataType"/> class.
    /// </summary>
    public BinaryLargeObjectDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryLargeObjectDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public BinaryLargeObjectDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryLargeObjectDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BinaryLargeObjectDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BinaryLargeObjectDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BinaryLargeObjectDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}