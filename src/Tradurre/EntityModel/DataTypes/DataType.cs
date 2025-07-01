// <copyright file="DataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a data type.
/// </summary>
public abstract class DataType : Fragment
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DataType"/> class.
    /// </summary>
    public DataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public DataType(Source source)
        : base(source)
    {
    }
}