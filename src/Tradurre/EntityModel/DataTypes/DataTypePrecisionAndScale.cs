// <copyright file="DataTypePrecisionAndScale.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a data type with precision and scale.
/// </summary>
public class DataTypePrecisionAndScale : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataTypePrecisionAndScale"/> class.
    /// </summary>
    public DataTypePrecisionAndScale()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataTypePrecisionAndScale"/> class with the specified precision.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public DataTypePrecisionAndScale(int precision)
        : base()
    {
        Precision = precision;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataTypePrecisionAndScale"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    public DataTypePrecisionAndScale(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataTypePrecisionAndScale"/> class with the specified precision and scale.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="scale">The precision for the data type.</param>
    public DataTypePrecisionAndScale(int precision, int scale)
        : base()
    {
        Precision = precision;
        Scale = scale;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataTypePrecisionAndScale"/> class with the specified precision and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DataTypePrecisionAndScale(int precision, Source source)
        : base(source)
    {
        Precision = precision;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataTypePrecisionAndScale"/> class with the specified precision, scale, and <see cref="Source"/>.
    /// </summary>
    /// <param name="precision">The precision for the data type.</param>
    /// /// <param name="scale">The precision for the data type.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DataTypePrecisionAndScale(int precision, int scale, Source source)
        : base(source)
    {
        Precision = precision;
        Scale = scale;
    }

    /// <summary>
    /// Gets or sets the precision for the data type.
    /// </summary>
    public int? Precision { get; set; }

    /// <summary>
    /// Gets or sets the scale for the data type.
    /// </summary>
    public int? Scale { get; set; }
}