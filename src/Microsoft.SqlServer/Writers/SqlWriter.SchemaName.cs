// <copyright file="SqlWriter.SchemaName.cs">
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
    /// Writes the <see cref="SchemaName"/>.
    /// </summary>
    /// <param name="fragment">The <see cref="SchemaName"/> to write.</param>
    /// <returns>A <see cref="WriteResult"/>.</returns>
    public WriteResult Write(SchemaName fragment)
    {
        _logger.TraceEntry();

        WriteResult result = new();

        string template = "{0}";

        if (fragment.IsQuoted)
            template = "[{0}]";

        result.Statement = string.Format(template, fragment.Value);

        return result;
    }
}