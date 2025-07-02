// <copyright file="SqlWriter.Statement.cs">
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
    /// Writes the <see cref="Statement"/>.
    /// </summary>
    /// <param name="fragment">The <see cref="Statement"/> to write.</param>
    /// <returns>A <see cref="WriteResult"/>.</returns>
    public WriteResult Write(Statement fragment)
    {
        _logger.TraceEntry();

        WriteResult result = new();

        // TODO: Write the Statements

        return result;
    }
}