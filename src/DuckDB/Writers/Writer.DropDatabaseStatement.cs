// <copyright file="Writer.DropDatabaseStatement.cs">
// All rights reserved.
// </copyright>

using Tradurre;

namespace DuckDB.Writers;

/// <inheritdoc/>
public partial class Writer
{
    /// <summary>
    /// Writes the <see cref="DropDatabaseStatement"/>.
    /// </summary>
    /// <param name="fragment">The <see cref="DropDatabaseStatement"/> to write.</param>
    /// <returns>A <see cref="WriteResult"/>.</returns>
    public WriteResult Write(DropDatabaseStatement fragment)
    {
        _logger.TraceEntry();
        WriteResult result = new();

        throw new NotImplementedException();

        _logger.TraceExit();
        return result;
    }
}