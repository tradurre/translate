// <copyright file="SqlServerWriter.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;

namespace Microsoft.SqlServer;

/// <summary>
/// The <see cref="IWriter"/> implementation for Microsoft SQL Server.
/// </summary>
public partial class SqlServerWriter : IWriter
{
    private readonly ILogger<SqlServerWriter> _logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="SqlServerWriter"/> with the specified <see cref="ILogger{TCategoryName}"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger{TCategoryName}"/>.</param>
    public SqlServerWriter(ILogger<SqlServerWriter> logger)
    {
        logger.TraceEntry();
        _logger = logger;
    }

    /// <inheritdoc/>
    public WriteResult Write(List<Fragment> statements)
    {
        _logger.TraceEntry();

        WriteResult result = new();

        foreach (Fragment fragment in statements)
        {
            //var temp_result = Write(fragment);
            //result.Errors.AddRange(temp_result.Errors);
            //result.Statements.AddRange(temp_result.Statements);
            //result.Warnings.AddRange(temp_result.Warnings);            
        }

        return result;
    }
}