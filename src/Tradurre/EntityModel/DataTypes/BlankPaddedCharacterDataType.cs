// <copyright file="BlankPaddedCharacterDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a BLANK PADDED CHARACTER (BPCHAR) data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-character.html" />.
/// </remarks>
public sealed class BlankPaddedCharacterDataType : DataTypePrecision
{
   /// <summary>
    /// Initializes a new instance of the <see cref="BlankPaddedCharacterDataType"/> class.
    /// </summary>
    public BlankPaddedCharacterDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BlankPaddedCharacterDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public BlankPaddedCharacterDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BlankPaddedCharacterDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BlankPaddedCharacterDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BlankPaddedCharacterDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public BlankPaddedCharacterDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}