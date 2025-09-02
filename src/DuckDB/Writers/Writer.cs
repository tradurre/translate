// <copyright file="Writer.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;

namespace DuckDB.Writers;

public partial class Writer : IWriter
{
    private readonly ILogger<Writer> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="Writer"/> with the specified <see cref="ILogger{TCategoryName}"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger{TCategoryName}"/>.</param>
    public Writer(ILogger<Writer> logger)
    {
        logger.TraceEntry();
        _logger = logger;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Writer"/> with the specified <see cref="ILogger{TCategoryName}"/> and <see cref="WriterConfiguration"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger{TCategoryName}"/>.</param>
    /// <param name="configuration">A <see cref="WriterConfiguration"/>.</param>
    public Writer(ILogger<Writer> logger, WriterConfiguration configuration)
        : this(logger)
    {
        logger.TraceEntry();
        Configuration = configuration;
    }

    /// <summary>
    /// Gets or sets the <see cref="WriterConfiguration"/> for the <see cref="SqlWriter"/>.
    /// </summary>
    public WriterConfiguration Configuration { get; set; } = new();

    /// <inheritdoc/>
    public WriteResult Write(List<Fragment> statements)
    {
        throw new NotImplementedException();
    }
}