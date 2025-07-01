// <copyright file="EnumDataType.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an enumeration data type.
/// </summary>
/// <remarks>
/// Microsoft SQL Server: N/A.
/// PostgreSQL: <see href="https://www.postgresql.org/docs/17/datatype-enum.html" />.
/// </remarks>
public sealed class EnumDataType : DataType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EnumDataType"/> class.
    /// </summary>
    public EnumDataType()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EnumDataType"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="source">A <see cref="Source"/>.</param>
    public EnumDataType(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Gets or sets the values in the enumeration.
    /// </summary>
    public List<string> Values { get; set; } = [];
}