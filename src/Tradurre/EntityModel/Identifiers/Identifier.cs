// <copyright file="Identifier.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// An object identifier.
/// </summary>
public class Identifier : Fragment
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Identifier"/> class with the specified value.
    /// </summary>
    /// <param name="value">The value of the object.</param>
    public Identifier(string value)
        : base()
    {
        Value = value;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Identifier"/> class with the specified value and <see cref="Source"/>.
    /// </summary>
    /// <param name="value">The value of the object.</param>
    /// <param name="source">A <see cref="Source"/>.</param>
    public Identifier(string value, Source source)
        : base(source)
    {
        Value = value;
    }

    /// <summary>
    /// Gets or sets a child <see cref="Identifier"/>.
    /// </summary>
    public Identifier? Child { get; set; }

    /// <summary>
    /// Gets or sets a flag that indicates if the <see cref="Identifier"/> is quoted.
    /// </summary>
    public bool? IsQuoted { get; set; }

    /// <summary>
    /// Gets or sets the value of the <see cref="Identifier"/>.
    /// </summary>
    public string Value { get; set; }
}