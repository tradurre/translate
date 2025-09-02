// <copyright file="Writer.DropFunctionStatement.cs">
// All rights reserved.
// </copyright>

using Tradurre;

namespace DuckDB.Writers;

/// <inheritdoc/>
public partial class Writer
{
    /// <summary>
    /// Writes the <see cref="DropFunctionStatement"/>.
    /// </summary>
    /// <param name="fragment">The <see cref="DropFunctionStatement"/> to write.</param>
    /// <returns>A <see cref="WriteResult"/>.</returns>
    public WriteResult Write(DropFunctionStatement fragment)
    {
        _logger.TraceEntry();
        WriteResult result = new();

        throw new NotImplementedException();

        _logger.TraceExit();
        return result;
    }
}