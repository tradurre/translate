// <copyright file="BigIntegerDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a BIGINT/INT8 (8 bytes) data type.
/// </summary>
/// <remarks>
/// Defined in the SQL:2003 standard as BIGINT.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/int-bigint-smallint-and-tinyint-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-numeric.html" />
/// </remarks>
public sealed class BigIntegerDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BigIntegerDataType"/> class.
    /// </summary>
    public BigIntegerDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BigIntegerDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BigIntegerDataType(Source source)
        : base(source)
    {
    }
}