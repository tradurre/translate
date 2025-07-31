// <copyright file="PostgresVisitor{T}.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;

namespace PostgreSql.Visitors;

/// <summary>
/// Base visitor for all PostgreSQL specific visitors.
/// </summary>
/// <typeparam name="T">The type of visitor result</typeparam>
/// <remarks>
/// Initializes a new instance of the <see cref="SqlServerVisitor{T}"/> class with the specified <see cref="ILogger"/>.
/// </remarks>
/// <param name="logger">An <see cref="ILogger"/>.</param>
internal partial class PostgresVisitor<T>(ILogger logger) : PostgresParserBaseVisitor<T>
    where T : class
{
    /// <summary>
    /// The <see cref="ILogger"/> for the visitor.
    /// </summary>
    private readonly ILogger _logger = logger;

    /// <summary>
    /// Gets the <see cref="ILogger"/>.
    /// </summary>
    internal ILogger Logger { get { return _logger; } }
}