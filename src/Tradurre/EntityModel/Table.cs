// <copyright file="Table.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents a SQL Table.
/// </summary>
public class Table : Fragment
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Table"/> class with the specified <see cref="Source"/>.
    /// </summary>
    /// <param name="name">The <see cref="TableName"/> for the <see cref="Table"/>.</param>
    /// <param name="source">The <see cref="Source"/> for the <see cref="Table"/>.</param>
    public Table(TableName name, Source source)
        : base(source)
    {
        Name = name;
    }

    /// <summary>
    /// Gets a collection of <see cref="Column"/> objects for the <see cref="Table"/>.
    /// </summary>
    public List<Column> Columns { get; } = [];

    /// <summary>
    /// Gets or sets the <see cref="TableName"/> for the <see cref="Table"/>.
    /// </summary>
    public TableName Name { get; set;  }
}