// <copyright file="SqlVisitor{T}.cs>
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;

namespace Microsoft.SqlServer.Visitors;

/// <summary>
/// Base visitor for all TSQL specific visitors.
/// </summary>
/// <typeparam name="T">The type of visitor result</typeparam>
/// <remarks>
/// Initializes a new instance of the <see cref="SqlVisitor{T}"/> class with the specified <see cref="ILogger"/>.
/// </remarks>
/// <param name="logger">An <see cref="ILogger"/>.</param>
internal partial class SqlVisitor<T>(ILogger logger) : TSqlParserBaseVisitor<T>()
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