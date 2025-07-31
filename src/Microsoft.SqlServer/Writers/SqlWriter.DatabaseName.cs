// <copyright file="SqlWriter.DatabaseName.cs">
// All rights reserved.
// </copyright>

using System.Text;
using Tradurre;

namespace Microsoft.SqlServer.Writers;

/// <summary>
/// The writer for Microsoft SQL Server.
/// </summary>
internal partial class SqlWriter
{
    /// <summary>
    /// Writes the <see cref="DatabaseName"/>.
    /// </summary>
    /// <param name="fragment">The <see cref="DatabaseName"/> to write.</param>
    /// <returns>A <see cref="WriteResult"/>.</returns>
    public WriteResult Write(DatabaseName fragment)
    {
        _logger.TraceEntry();

        string template = "{0}";

        WriteResult result = new();

        StringBuilder sb = new();

        if (Configuration.UseQuotedIdentifiers || fragment.IsQuoted)
            template = "[{0}]";

        sb.Append(string.Format(template, fragment.Value));

        //if (fragment.Child is not null)
        //    result.Warnings.Add(new NotSupportedWarning("[database name]",
        //        "Microsoft SQL Server does not support a [database name] with any child identifiers."));

        result.Statement = sb.ToString();

        return result;
    }
}