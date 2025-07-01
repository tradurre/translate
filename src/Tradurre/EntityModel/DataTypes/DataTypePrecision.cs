// <copyright file="DataTypePrecision.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a data type with precision.
/// </summary>
public class DataTypePrecision : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataTypePrecision"/> class.
    /// </summary>
    public DataTypePrecision()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataTypePrecision"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public DataTypePrecision(int precision)
        : base()
    {
        Precision = precision;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataTypePrecision"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DataTypePrecision(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataTypePrecision"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DataTypePrecision(int precision, Source source)
        : base(source)
    {
        Precision = precision;
    }

    /// <summary>
    /// Gets or sets the precision for the data type.
    /// </summary>
    public int? Precision { get; set; }
}