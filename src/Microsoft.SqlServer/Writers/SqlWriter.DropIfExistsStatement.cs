// <copyright file="SqlWriter.DropIfExistsStatement.cs">
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
    /// Writes the <see cref="DropIfExistsStatement"/>.
    /// </summary>
    /// <param name="fragment">The <see cref="DropIfExistsStatement"/> to write.</param>
    /// <returns>A <see cref="WriteResult"/>.</returns>
    public WriteResult Write(DropIfExistsStatement fragment)
    {
        _logger.TraceEntry();

        WriteResult result = new();

        // TODO: Write the DropIfExistsStatements

        return result;
    }
}