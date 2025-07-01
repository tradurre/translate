// <copyright file="CharacterLargeObjectDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a CHARACTER LARGE OBJECT (CLOB) (precision) data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-99 standard as CHARACTER LARGE OBJECT <left paren> <length> <right paren>.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/char-and-varchar-transact-sql"/>
///                       Note: There is no direct CLOB data type, rather VARCHAR(MAX).
/// PostgreSQL: Not Supported. See item T046 at <see href="https://www.postgresql.org/docs/current/unsupported-features-sql-standard.html" />.
/// </remarks>
public sealed class CharacterLargeObjectDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterLargeObjectDataType"/> class.
    /// </summary>
    public CharacterLargeObjectDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterLargeObjectDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public CharacterLargeObjectDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterLargeObjectDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public CharacterLargeObjectDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CharacterLargeObjectDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public CharacterLargeObjectDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}