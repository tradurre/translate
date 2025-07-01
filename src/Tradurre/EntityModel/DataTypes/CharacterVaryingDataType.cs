// <copyright file="CharacterVaryingDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a CHARACTER VARYING / VARCHAR (precision + 2 bytes) data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-92 standard as ( CHAR | CHARACTER ) VARYING | VARCHAR <left paren> <length> <right paren>.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/char-and-varchar-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-character.html" />
/// </remarks>
public sealed class CharacterVaryingDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterVaryingDataType"/> class.
    /// </summary>
    public CharacterVaryingDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterVaryingDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public CharacterVaryingDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterVaryingDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public CharacterVaryingDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterVaryingDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public CharacterVaryingDataType(int precision, Source source)
        : base(precision, source)
    {
    }

    /// <summary>
    /// Gets or sets a flag that indicates if the (MAX) value is set.
    /// </summary>
    public bool? IsMax { get; set; }
}