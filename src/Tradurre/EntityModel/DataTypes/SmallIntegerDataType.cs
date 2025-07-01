// <copyright file="SmallIntegerDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an INT2 | SMALLINT (2 bytes) data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-86 standard as SMALLINTEGER.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/int-bigint-smallint-and-tinyint-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-numeric.html" />
/// </remarks>
public sealed class SmallIntegerDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SmallIntegerDataType"/> class.
    /// </summary>
    public SmallIntegerDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SmallIntegerDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public SmallIntegerDataType(Source source)
        : base(source)
    {
    }
}