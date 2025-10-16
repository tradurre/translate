// <copyright file="VacuumStatement.cs">
// All rights reserved.
// </copyright>

using System.Data.Common;

namespace Tradurre;

/// <summary>
/// Represents a VACUUM SQL Statement.
/// </summary>
/// <remarks>
/// DuckDB: VACUUM https://duckdb.org/docs/stable/sql/statements/vacuum
public sealed class VacuumStatement : Statement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VacuumStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public VacuumStatement(Source source)
        : base(source)
    {
    }

    /// <summary>
    /// Gets or sets a flag that indicates if the operation should collect statistics about a database.
    /// </summary>
    public bool? Analyze { get; set; }

    /// <summary>
    /// Gets or sets a <see cref="Table"/> for the operation.
    /// </summary>
    public Table? Table { get; set; }
}