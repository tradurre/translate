using Serilog.Sinks.SystemConsole.Themes;

namespace Tradurre.Themes;

/// <summary>
/// A static class of theme definitions.
/// </summary>
public static class ConsoleThemes
{
    public static ConsoleTheme TranslateTheme { get; } = new ConsoleTheme(
        new Dictionary<ConsoleThemeStyle, string>
        {
            [ConsoleThemeStyle.Text] = "\x1b[38;5;0253m",
            [ConsoleThemeStyle.SecondaryText] = "\x1b[38;5;0246m",
            [ConsoleThemeStyle.TertiaryText] = "\x1b[38;5;0242m",
            [ConsoleThemeStyle.Invalid] = "\x1b[33;1m",
            [ConsoleThemeStyle.Null] = "\x1b[38;5;0038m",
            [ConsoleThemeStyle.Name] = "\x1b[38;5;0081m",
            [ConsoleThemeStyle.String] = "\x1b[38;5;0216m",
            [ConsoleThemeStyle.Number] = "\x1b[38;5;151m",
            [ConsoleThemeStyle.Boolean] = "\x1b[38;5;0038m",
            [ConsoleThemeStyle.Scalar] = "\x1b[38;5;0079m",
            [ConsoleThemeStyle.LevelVerbose] = "\x1b[36m",
            [ConsoleThemeStyle.LevelDebug] = "\x1b[35;1m",                          // Purple
            [ConsoleThemeStyle.LevelInformation] = "\x1b[36;1m",                    // Cyan
            [ConsoleThemeStyle.LevelWarning] = "\x1b[33;1m",                        // Yellow
            [ConsoleThemeStyle.LevelError] = "\x1b[31;1m",                          // Red
            [ConsoleThemeStyle.LevelFatal] = "\x1b[38;5;0197m\x1b[48;5;0238m",
        });
}