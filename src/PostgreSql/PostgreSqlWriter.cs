// <copyright file="PostgreSqlWriter.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;

namespace PostgreSql;

public class PostgreSqlWriter : IWriter
{
    private readonly ILogger _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="PostgreSqlWriter"/> class with the specified <see cref="ILogger{TCategoryName}"/>.
    /// </summary>
    /// <param name="logger"></param>
    public PostgreSqlWriter(ILogger<PostgreSqlWriter> logger)
    {
        logger.TraceEntry();
        _logger = logger;        
    }

    /// <inheritdoc/>
    public WriteResult Write(List<Fragment> statements)
    {
        _logger.TraceEntry();
        throw new NotImplementedException();
    }
}
