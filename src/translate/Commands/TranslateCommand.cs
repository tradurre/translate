// <copyright file="TranslateCommand.cs">
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
[Command("translate", Description = "Translates the input files from source to target.")]
public class TranslateCommand : ICommand
{
    private readonly ILogger<TranslateCommand> _logger;
    private readonly IServiceProvider _provider;

    /// <summary>
    /// Initializes a new instance of the <see cref="TranslateCommand"/> class with the specified
    /// <see cref="ILogger"/> and <see cref="IServiceProvider"/>.
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="provider"></param>
    public TranslateCommand(ILogger<TranslateCommand> logger, IServiceProvider provider)
        : base()
    {
        _logger = logger;
        _provider = provider;
        _logger.TraceEntry();

        // Get the translator
        // TODO: Throw a better exception for logging
        Translator = _provider.GetService<ITranslator>() ?? throw new NotImplementedException();
    }

    [CommandOption(
    "source",
    's',
    Description = "The source type of the SQL files to parse.",
    IsRequired = true)]
    public SourceType Source { get; set; }

    [CommandOption(
        "target",
        't',
        Description = "The source type of the SQL files to parse.",
        IsRequired = true)]
    public TargetType Target { get; set; }

    [CommandOption(
        "input",
        'i',
        Description = "The directory to the source files.",
        IsRequired = true
        )]
    public DirectoryInfo? Input { get; set; }

    [CommandOption(
        "output",
        'o',
        Description = "The directory to output the files.",
        IsRequired = true
        )]
    public DirectoryInfo? Output { get; set; }

    private ITranslator Translator { get; set; }

    public ValueTask ExecuteAsync(IConsole console)
    {
        _logger.TraceEntry();

        Helper.WriteHeader();

        List<TranslationResult> results = [];

        results.AddRange(Translate(Input));

        return default;
    }

    private List<TranslationResult> Translate(DirectoryInfo directory)
    {
        _logger.TraceEntry();

        List<TranslationResult> results = [];

        foreach (FileInfo file in directory.GetFiles("*.sql"))
        {
            results.AddRange(Translate(file));
        }

        foreach (DirectoryInfo child in directory.GetDirectories())
        {
            results.AddRange(Translate(child));
        }

        return results;
    }

    private TranslationResult Translate(FileInfo file)
    {
        _logger.TraceEntry();

        string statements = File.ReadAllText(file.FullName);
        return Translator.Translate(Source, Target, statements);
    }
}