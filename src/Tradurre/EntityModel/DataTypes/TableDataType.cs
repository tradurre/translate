// <copyright file="TableDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a TABLE (variable bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/table-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class TableDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TableDataType"/> class.
    /// </summary>
    public TableDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TableDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public TableDataType(Source source)
        : base(source)
    {
    }

    // TODO: Complete the TABLE data type definition
}