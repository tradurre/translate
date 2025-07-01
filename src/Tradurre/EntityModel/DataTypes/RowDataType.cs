// <copyright file="RowDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a ROW data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-99 standard as ROW.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/rowversion-transact-sql"/>
///                       Note: Microsoft recommends the ROWVERSION synonym instead of the TIMESTAMP synonym.
/// PostgreSQL: N/A
/// </remarks>
public sealed class RowDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RowDataType"/> class.
    /// </summary>
    public RowDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RowDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public RowDataType(Source source)
        : base(source)
    {
    }
}