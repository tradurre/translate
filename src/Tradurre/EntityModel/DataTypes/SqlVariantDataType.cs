// <copyright file="SqlVariantDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a SQL_VARIANT data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/sql-variant-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class SqlVariantDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SqlVariantDataType"/> class.
    /// </summary>
    public SqlVariantDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SqlVariantDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public SqlVariantDataType(Source source)
        : base(source)
    {
    }
}