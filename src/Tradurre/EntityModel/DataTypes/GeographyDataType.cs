// <copyright file="GeographyDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a GEOGRAPHY data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: <see href="https://learn.microsoft.com/en-us/sql/t-sql/spatial-geography/spatial-types-geography"/>
/// PostgreSQL: <see href="" />
/// </remarks>
public sealed class GeographyDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GeographyDataType"/> class.
    /// </summary>
    public GeographyDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GeographyDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public GeographyDataType(Source source)
        : base(source)
    {
    }
}