using Serilog.Sinks.SystemConsole.Themes;

namespace Tradurre.Themes;

public class ConsoleTheme : Serilog.Sinks.SystemConsole.Themes.ConsoleTheme
{
    private const string AnsiStyleReset = "\x1b[0m";

    private readonly Dictionary<ConsoleThemeStyle, string> _styles;

    /// <summary>
    /// Construct a theme given a set of styles.
    /// </summary>
    /// <param name="styles">Styles to apply within the theme.</param>
    internal ConsoleTheme(IReadOnlyDictionary<ConsoleThemeStyle, string> styles)
    {
        ArgumentNullException.ThrowIfNull(styles);
        _styles = styles.ToDictionary(kv => kv.Key, kv => kv.Value);
    }

    /// <inheritdoc/>
    public override bool CanBuffer => true;

    /// <inheritdoc/>
    protected override int ResetCharCount { get; } = AnsiStyleReset.Length;

    /// <summary>
    /// A 256-color theme.
    /// </summary>
    internal static ConsoleTheme Translate { get; } = ConsoleThemes.TranslateTheme;

    /// <inheritdoc/>
    public override void Reset(TextWriter output)
    {
        output.Write(AnsiStyleReset);
    }

    /// <inheritdoc/>
    public override int Set(TextWriter output, ConsoleThemeStyle style)
    {
        if (_styles.TryGetValue(style, out string? ansiStyle))
        {
            output.Write(ansiStyle);
            return ansiStyle.Length;
        }

        return 0;
    }
}