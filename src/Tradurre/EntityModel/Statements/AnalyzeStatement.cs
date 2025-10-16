// <copyright file="AnalyzeStatement.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

/// <summary>
/// Represents an empty or termination (;) SQL Statement.
/// </summary>
/// <remarks>
/// DuckDB: ANALYZE https://duckdb.org/docs/stable/sql/statements/analyze
public sealed class AnalyzeStatement : Statement
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AnalyzeStatement"/> class with the specified
    /// <see cref="Source"/>.
    /// </summary>
    /// <param name="source">The <see cref="Source"/> for the statement.</param>
    public AnalyzeStatement(Source source)
        : base(source)
    {
    }
}