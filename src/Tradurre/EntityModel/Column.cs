// <copyright file="Column.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a SQL Table Column.
/// </summary>
public class Column : Fragment
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Column"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="name">The <see cref="ColumnName"/> for the <see cref="Column"/>.</param>
    /// <param name="source">The <see cref="Source"/> for the <see cref="Column"/>.</param>
    public Column(ColumnName name, Source source)
        : base(source)
    {
        Name = name;
    }

    /// <summary>
    /// Gets or sets the <see cref="ColumnName"/> for the <see cref="Column"/>.
    /// </summary>
    public ColumnName Name { get; set;  }
}