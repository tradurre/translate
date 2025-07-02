// <copyright file="SqlWriter.Fragment.cs">
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
    /// Writes the <see cref="Fragment"/>.
    /// </summary>
    /// <param name="fragment">The <see cref="Fragment"/> to write.</param>
    /// <returns>A <see cref="WriteResult"/>.</returns>
    public WriteResult Write(Fragment fragment)
    {
        _logger.TraceEntry();

        WriteResult result = new();

        // TODO: Write the fragments

        return result;
    }
}