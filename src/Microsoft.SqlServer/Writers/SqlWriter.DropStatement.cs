// <copyright file="SqlWriter.DropStatement.cs">
// All rights reserved.
// </copyright>

using Tradurre;

namespace Microsoft.SqlServer.Writers;

/// <summary>
/// The writer for Microsoft SQL Server.
/// </summary>
internal partial class SqlWriter
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

        // TODO: Write the DropStatements

        return result;
    }
}