// <copyright file="BitDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a BIT data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/bit-transact-sql?view=sql-server-ver17"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-bit.html" />
/// </remarks>
public sealed class BitDataType : DataTypePrecision
{
   /// <summary>
    /// Initializes a new instance of the <see cref="BitDataType"/> class.
    /// </summary>
    public BitDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BitDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public BitDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BitDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BitDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BitDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BitDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}