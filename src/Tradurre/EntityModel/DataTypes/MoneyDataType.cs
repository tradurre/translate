// <copyright file="MoneyDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a MONEY (4 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/bit-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class MoneyDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MoneyDataType"/> class.
    /// </summary>
    public MoneyDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="MoneyDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public MoneyDataType(Source source)
        : base(source)
    {
    }
}