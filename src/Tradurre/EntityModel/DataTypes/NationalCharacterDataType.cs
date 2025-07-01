// <copyright file="NationalCharacterDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a NATIONAL CHARACTER / NCHAR (2 times length bytes) data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-92 standard as NATIONAL ( CHAR | CHARACTER ) | NCHAR [ <left paren> <length> <right paren> ].
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/nchar-and-nvarchar-transact-sql"/>
/// PostgreSQL: Not Supported.
/// </remarks>
public sealed class NationalCharacterDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NationalCharacterDataType"/> class.
    /// </summary>
    public NationalCharacterDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NationalCharacterDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public NationalCharacterDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NationalCharacterDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public NationalCharacterDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NationalCharacterDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public NationalCharacterDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}