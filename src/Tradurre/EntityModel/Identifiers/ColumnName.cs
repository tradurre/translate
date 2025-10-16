// <copyright file="ColumnName.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents the name of a table column object.
/// </summary>
/// <remarks>
/// </remarks>
public sealed class ColumnName : Identifier
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ColumnName"/> class with the specified name.
    /// </summary>
    /// <param name="name">The name of the table.</param>
    /// <param name="source">The <see cref="Source"/> for the object.</param>
    public ColumnName(string name, Source source)
        : base(name, source)
    {
    }
}