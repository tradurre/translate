// <copyright file="NationalCharacterVaryingDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a NATIONAL CHARACTER VARYING / NVARCHAR (2 times length + 2 bytes) data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-92 standard as NATIONAL ( CHAR | CHARACTER ) VARYING | NVARCHAR [ <left paren> <length> <right paren> ].
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/nchar-and-nvarchar-transact-sql"/>
/// PostgreSQL: Not Supported.
/// </remarks>
public sealed class NationalCharacterVaryingDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NationalCharacterVaryingDataType"/> class.
    /// </summary>
    public NationalCharacterVaryingDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NationalCharacterVaryingDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public NationalCharacterVaryingDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NationalCharacterVaryingDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public NationalCharacterVaryingDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="NationalCharacterVaryingDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public NationalCharacterVaryingDataType(int precision, Source source)
        : base(precision, source)
    {
    }

    /// <summary>
    /// Gets or sets a flag that indicates if the (MAX) value is set.
    /// </summary>
    public bool? IsMax { get; set; }
}