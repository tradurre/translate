// <copyright file="SqlServerParser.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;

namespace Microsoft.SqlServer;

/// <summary>
/// The <see cref="IParser"/> implementation for Microsoft SQL Server.
/// </summary>
public sealed class SqlServerParser : IParser
{
    private readonly ILogger<SqlServerParser> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="SqlServerParser"/> with the specified <see cref="ILogger{TCategoryName}"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger{TCategoryName}"/>.</param>
    public SqlServerParser(ILogger<SqlServerParser> logger)
    {
        logger.TraceEntry();
        _logger = logger;
    }

    /// <inheritdoc/>
    public ParseResult Parse(string statement)
    {
        _logger.TraceEntry();
        throw new NotImplementedException();
    }
}