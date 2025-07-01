// <copyright file="DoublePrecsionDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a DOUBLE PRECISION data type.
/// </summary>
/// <remarks>
/// Defined in the SQL-86 standard as DOUBLE PRECISION.
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/data-types/float-and-real-transact-sql"/>
///                       In SQL Server, a DOUBLE PRECISION is a synonym for FLOAT(53).
/// PostgreSQL: <see href="https://www.postgresql.org/docs/current/datatype-numeric.html" />
/// </remarks>
public sealed class DoublePrecsionDataType : DataTypePrecision
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DoublePrecsionDataType"/> class.
    /// </summary>
    public DoublePrecsionDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DoublePrecsionDataType"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public DoublePrecsionDataType(int precision)
        : base(precision)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DoublePrecsionDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DoublePrecsionDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DoublePrecsionDataType"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DoublePrecsionDataType(int precision, Source source)
        : base(precision, source)
    {
    }
}