// <copyright file="SqlWriter.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;

namespace Microsoft.SqlServer.Writers;

/// <summary>
/// The entity writers for Microsoft SQL Server.
/// </summary>
internal partial class SqlWriter
{
    private readonly ILogger<SqlWriter> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="SqlWriter"/> with the specified <see cref="ILogger{TCategoryName}"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger{TCategoryName}"/>.</param>
    public SqlWriter(ILogger<SqlWriter> logger)
    {
        logger.TraceEntry();
        _logger = logger;
    }

    public SqlWriter(ILogger<SqlWriter> logger, WriterConfiguration configuration)
        : this (logger)
    {
        logger.TraceEntry();
        Configuration = configuration;
    }

    /// <summary>
    /// Gets or sets the <see cref="WriterConfiguration"/> for the <see cref="SqlWriter"/>.
    /// </summary>
    public WriterConfiguration Configuration { get; set; } = new();
}