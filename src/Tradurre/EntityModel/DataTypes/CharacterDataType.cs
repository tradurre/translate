// <copyright file="CharacterDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a CHAR | CHARACTER [(<length>)] data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-86 standard as CHAR | CHARACTER [(<length>)].
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/char-and-varchar-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-character.html" />
/// </remarks>
public sealed class CharacterDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterDataType"/> class.
    /// </summary>
    public CharacterDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public CharacterDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public CharacterDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public CharacterDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}