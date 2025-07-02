// <copyright file="SqlWriter.Identifier.cs">
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
    /// Writes the <see cref="Identifier"/>.
    /// </summary>
    /// <param name="fragment">The <see cref="Identifier"/> to write.</param>
    /// <returns>A <see cref="WriteResult"/>.</returns>
    public WriteResult Write(Identifier fragment)
    {
        _logger.TraceEntry();

        WriteResult result = new();

        // TODO: Write the Identifiers

        return result;
    }
}