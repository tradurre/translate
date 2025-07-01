// <copyright file="ParseCommand.cs">
// All rights reserved.
// </copyright>

using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Tradurre.Commands;

/// <summary>
/// A command for parsing a directory of files for correctness.
/// </summary>
[Command("parse", Description = "Parses the input files to validate correctness.")]
public class ParseCommand : ICommand
{
    private const string _dashes = "***************************************************************************************************";
    private readonly ILogger _logger;
    private readonly IServiceProvider _provider;

    [CommandOption(
        "source",
        's',
        Description = "The source type of the SQL files to parse.",
        IsRequired = true)]
    public SourceType Type { get; set; }

    [CommandOption(
        "input",
        'i',
        Description = "The directory to the source files.",
        IsRequired = true
        )]
    public DirectoryInfo? Input { get; set; }

    private ITranslator? Translator { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ParseCommand"/> with the specified
    /// <see cref="ILogger{TCategoryName}"/>.
    /// </summary>
    /// <param name="logger">The <see cref="ILogger{TCategoryName}"/> for the command.</param>
    public ParseCommand(ILogger<ParseCommand> logger, IServiceProvider provider)
    {
        _logger = logger;
        _provider = provider;
        _logger.TraceEntry();
    }

    /// <inheritdoc/>
    public ValueTask ExecuteAsync(IConsole console)
    {
        _logger.TraceEntry();

        Helper.WriteHeader();

        // Get the Translator
        ITranslator? translator = _provider.GetService<ITranslator>() ?? throw new NotImplementedException();
        
        Translator = translator;

        // Rarse the input
        //Parse(Input);

        console.Output.WriteLine();
        _logger.LogInformation("File(s) parsed successfully");
        console.Output.WriteLine();

        return default;
    }
}