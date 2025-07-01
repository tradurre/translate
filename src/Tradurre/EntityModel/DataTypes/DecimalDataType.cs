// <copyright file="DecimalDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DEC | DECIMAL [(<precision> [,<scale>])] data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-86 standard as DEC | DECIMAL [(<precision> [,<scale>])].
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/decimal-and-numeric-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-numeric.html" />
/// </remarks>
public sealed class DecimalDataType : DataTypePrecisionAndScale
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DecimalDataType"/> class.
    /// </summary>
    public DecimalDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DecimalDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public DecimalDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DecimalDataType"/> class with the specified precision and scale.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="scale">The precision for the data type.</param>
    public DecimalDataType(int precision, int scale)
        : base(precision, scale)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DecimalDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DecimalDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DecimalDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DecimalDataType(int precision, Source source)
        : base(precision, source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DecimalDataType"/> class with the specified precision, scale, and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// /// <param name="scale">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DecimalDataType(int precision, int scale, Source source)
        : base(precision, scale, source)
    {
    }
}