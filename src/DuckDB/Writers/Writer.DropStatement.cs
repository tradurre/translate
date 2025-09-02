// <copyright file="Writer.DropStatement.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using Tradurre;

namespace DuckDB.Writers;

/// <inheritdoc/>
public partial class Writer
{
    /// <summary>
    /// Writes the <see cref="DropStatement"/>.
    /// </summary>
    /// <param name="fragment">The <see cref="DropStatement"/> to write.</param>
    /// <returns>A <see cref="WriteResult"/>.</returns>
    public WriteResult Write(DropStatement fragment)
    {
        _logger.TraceEntry();
        WriteResult result = new();


        _logger.TraceExit();
        return result;
    }
}