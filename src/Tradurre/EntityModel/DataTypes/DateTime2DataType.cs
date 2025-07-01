// <copyright file="DateTime2DataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DATETIME2 (6-8 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/datetime2-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class DateTime2DataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DateTime2DataType"/> class.
    /// </summary>
    public DateTime2DataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DateTime2DataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DateTime2DataType(Source source)
        : base(source)
    {
    }
}