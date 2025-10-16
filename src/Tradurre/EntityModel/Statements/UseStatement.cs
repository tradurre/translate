// <copyright file="UseStatement.cs">
// All rights reserved.
// </copyright>

using System.Data.Common;

namespace Tradurre;

/// <summary>
/// Represents a USE SQL Statement.
/// </summary>
/// <remarks>
/// DuckDB: USE https://duckdb.org/docs/stable/sql/statements/use
public sealed class UseStatement: Statement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UseStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="name">The <see cref="SchemaName"/> for the statement.</param>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public UseStatement(SchemaName name, Source source)
        : base(source)
    {
        Name = name;
    }

    /// <summary>
    /// Gets or sets the <see cref="SchemaName"/> for the statement.
    /// </summary>
    public SchemaName Name { get; set; }
}