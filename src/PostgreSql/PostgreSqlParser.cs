// <copyright file="PostgreSqlParser.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;

namespace PostgreSql;

public class PostgreSqlParser : IParser
{
    private readonly ILogger _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="PostgreSqlParser"/> class with the specified <see cref="ILogger{TCategoryName}"/>.
    /// </summary>
    /// <param name="logger"></param>
    public PostgreSqlParser(ILogger<PostgreSqlParser> logger)
    {
        logger.TraceEntry();
        _logger = logger;        
    }

    /// <inheritdoc/>
    public ParseResult Parse(string statement)
    {
        _logger.TraceEntry();

        ParseResult result = new();

        return result;
    }
}
