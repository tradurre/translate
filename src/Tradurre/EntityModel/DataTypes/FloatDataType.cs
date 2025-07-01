// <copyright file="FloatDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a FLOAT [(<precision>)] data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-86 standard as FLOAT [(<precision>)].
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/float-and-real-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-numeric.html" />
/// </remarks>
public sealed class FloatDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FloatDataType"/> class.
    /// </summary>
    public FloatDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FloatDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public FloatDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FloatDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public FloatDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="FloatDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public FloatDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}