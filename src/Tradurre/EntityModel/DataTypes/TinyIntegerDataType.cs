// <copyright file="TinyIntegerDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;
/// <summary>
/// Represents a TINYINT/INT1 (1 byte) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/int-bigint-smallint-and-tinyint-transact-sql"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class TinyIntegerDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TinyIntegerDataType"/> class.
    /// </summary>
    public TinyIntegerDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="TinyIntegerDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public TinyIntegerDataType(Source source)
        : base(source)
    {
    }
}