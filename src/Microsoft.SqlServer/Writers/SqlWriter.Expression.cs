// <copyright file="SqlWriter.Expression.cs">
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
    /// Writes the <see cref="Expression"/>.
    /// </summary>
    /// <param name="fragment">The <see cref="Expression"/> to write.</param>
    /// <returns>A <see cref="WriteResult"/>.</returns>
    public WriteResult Write(Expression fragment)
    {
        _logger.TraceEntry();

        WriteResult result = new();

        // TODO: Write the Expressions

        return result;
    }
}