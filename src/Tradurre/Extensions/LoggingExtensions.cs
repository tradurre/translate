// <copyright file="LoggingExtensions.cs">
// All rights reserved.
// </copyright>

using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace Tradurre;

/// <summary>
/// This class contains extensions for <see cref="Microsoft.Extensions.Logging.ILogger"/> class.
/// </summary>
public static class LoggingExtensions
{
    private static List<string> nests = [];

    private static Lock _nest_lock = new();

    /// <summary>
    /// Message template for entry message.
    /// </summary>
    private static readonly string METHOD_ENTRY_TEMPLATE = "Method Entry ({ticks}): {file}.{member}:{line}";

    /// <summary>
    /// Message template for exit message.
    /// </summary>
    private static readonly string METHOD_EXIT_TEMPLATE = "Method Exit ({ticks}): {file}.{member}:{line}";

    public static void NestEnd(this ILogger logger, [CallerMemberName] string member_name = "")
    {
        if (string.IsNullOrEmpty(member_name))
            return;

        lock (_nest_lock)
        {
            if (nests.Any() && nests.Count > 0)
                nests.RemoveAt(nests.Count - 1);
        }
    }

    public static void NestStart(this ILogger logger, [CallerMemberName] string member_name = "")
    {
        if (string.IsNullOrEmpty(member_name))
            return;

        lock (_nest_lock)
        {
            nests ??= [];

            if (nests.Count > 0)
            {
                if (!member_name.Equals(nests[^1], StringComparison.InvariantCultureIgnoreCase))
                {
                    nests.Add(member_name);
                }
            }
            else
            {
                nests.Add(member_name);
            }
        }

        logger.LogTrace("Tree: {Tree}", string.Join($" > ", nests.ToArray()));
    }

    /// <summary>
    /// Traces the calling method entry for debugging.
    /// </summary>
    /// <param name="logger">The <see cref="ILogger"/>.</param>
    /// <param name="member_name">The calling memeber name.</param>
    /// <param name="source_path">The calling member source file path.</param>
    /// <param name="line_number">The calling member source line number.</param>
    public static void TraceEntry(this ILogger logger,
        [CallerMemberName] string member_name = "",
        [CallerFilePath] string source_path = "",
        [CallerLineNumber] int line_number = 0)
    {
        logger.LogTrace(METHOD_ENTRY_TEMPLATE,
            DateTime.Now.Ticks,
            source_path,
            member_name,
            line_number);
    }

    /// <summary>
    /// Traces the calling method exit for debugging.
    /// </summary>
    /// <param name="logger">The <see cref="ILogger"/>.</param>
    /// <param name="member_name">The calling memeber name.</param>
    /// <param name="source_path">The calling member source file path.</param>
    /// <param name="line_number">The calling member source line number.</param>
    public static void TraceExit(this ILogger logger,
        [CallerMemberName] string member_name = "",
        [CallerFilePath] string source_path = "",
        [CallerLineNumber] int line_number = 0)
    {
        logger.LogTrace(METHOD_EXIT_TEMPLATE,
            DateTime.Now.Ticks,
            source_path,
            member_name,
            line_number);
    }
}