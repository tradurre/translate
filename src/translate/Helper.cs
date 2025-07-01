// <copyright file="Helper.cs">
// All rights reserved.
// </copyright>

namespace Tradurre;

internal static class Helper
{
    /// <summary>
    /// The client version for the assembly.
    /// </summary>
    private static string ClientVersion
    => $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Version}";

    /// <summary>
    /// Writes the header to the console.
    /// </summary>
    internal static void WriteHeader()
    {
        Console.WriteLine($"Translate (Preview)");
        Console.WriteLine($"Version {ClientVersion}");
        Console.WriteLine($"Copyright (C) {DateTime.Now.Year}. All rights reserved.");
        Console.WriteLine();
    }
}