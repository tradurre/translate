// <copyright file="SqlWriter.DropDatabaseStatement.cs">
// All rights reserved.
// </copyright>

using System.Drawing.Imaging;
using System.Text;
using Tradurre;

namespace Microsoft.SqlServer.Writers;

/// <summary>
/// The writer for Microsoft SQL Server.
/// </summary>
internal partial class SqlWriter
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


        StringBuilder sb = new();

        sb.Append("DROP DATABASE ");

        if (fragment.IfExists)
            sb.Append("IF EXISTS ");

        string[] values = new string[fragment.Names.Count];

        for (int i = 0; i < fragment.Names.Count; i++)
        {
            var name_result = Write(fragment.Names[i]);

            result.Errors.AddRange(name_result.Errors);
            result.Warnings.AddRange(name_result.Warnings);
            values[i] = result.Statement;
        }

        sb.Append(string.Join(", ", values));

        if (fragment.Force is not null && (bool)fragment.Force)
            result.Warnings.Add(new NotSupportedWarning("DROP DATABASE ... FORCE", 
                "By default, Microsoft SQL Server will automatically terminate connections during the DROP DATABASE operation."));

        if (fragment.Options.Contains(DropDatabaseOption.At_PartitionNumber))
            result.Warnings.Add(new NotSupportedWarning("DROP DATABASE ... AT PARTITION NUMBER",
                "Microsoft SQL Server does not support multi-node partitioned databases."));

        if (fragment.Options.Contains(DropDatabaseOption.Cascade))
            result.Warnings.Add(new NotSupportedWarning("DROP DATABASE ... CASCADE", 
                "By default, Microsoft SQL Server will automatically drop all objects during the DROP DATABASE operation."));

        if (fragment.Options.Contains(DropDatabaseOption.Restrict))
            result.Warnings.Add(new NotSupportedWarning("DROP DATABASE ... RESTRICT", 
                "Microsoft SQL Server does not support checking for the existence of cross database foreign keys during a DROP DATABASE operation."));

        sb.Append(';');

        result.Statement = sb.ToString();

        return result;
    }
}