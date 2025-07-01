// <copyright file="RealDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a REAL data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-86 standard as REAL.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/float-and-real-transact-sql"/>
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-numeric.html" />
/// </remarks>
public sealed class RealDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RealDataType"/> class.
    /// </summary>
    public RealDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RealDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public RealDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RealDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public RealDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RealDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public RealDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}