// <copyright file="SmallMoneyDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a SMALLMONEY (2 bytes) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/bit-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class SmallMoneyDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SmallMoneyDataType"/> class.
    /// </summary>
    public SmallMoneyDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SmallMoneyDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public SmallMoneyDataType(Source source)
        : base(source)
    {
    }
}