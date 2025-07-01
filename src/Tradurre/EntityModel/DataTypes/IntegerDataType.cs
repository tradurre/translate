// <copyright file="IntegerDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an INT | INT4 | INTEGER data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-86 standard as INT | INTEGER.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/int-bigint-smallint-and-tinyint-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-numeric.html" />
/// </remarks>
public sealed class IntegerDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IntegerDataType"/> class.
    /// </summary>
    public IntegerDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="IntegerDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public IntegerDataType(Source source)
        : base(source)
    {
    }
}