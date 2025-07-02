// <copyright file="Translator.cs">
// All rights reserved.
// </copyright>

using Antlr4.Runtime;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Reflection.Metadata.Ecma335;

namespace Tradurre;

/// <summary>
/// The result of a language writing operation.
/// </summary>
public sealed class Translator : ITranslator
{
    private readonly ILogger<Translator> _logger;

    private readonly IServiceProvider _provider;

    public Translator(ILogger<Translator> logger, IServiceProvider provider)
    {
        _logger = logger;
        _provider = provider;
    }

    /// <inheritdoc/>
    /// <exception cref="NotImplementedException"></exception>
    public ParseResult Parse(SourceType source, string statement)
    {
        _logger.TraceEntry();

        // Get the parser
        var parser = _provider.GetKeyedService<IParser>(source) ?? throw new ParserNotFoundException();

        return parser.Parse(statement);
    }

    /// <inheritdoc/>
    /// <exception cref="NotImplementedException"></exception>
    public TranslationResult Translate(SourceType source, TargetType target, string statement)
    {
        _logger.TraceEntry();

        TranslationResult result = new();

        // Parse the statments into intermediate objects
        var parse_result = Parse(source, statement);

        // TODO: Add errors and warnings to the result


        // Get the writer
        var writer = _provider.GetKeyedService<IWriter>(target) ?? throw new InvalidOperationException();
        var write_result = writer.Write(parse_result.Statements.ToList<Fragment>());

        // TODO: result.Statements.AddRange(write_result.Statements);

        // TODO: Add errors and warnings to the result

        return result;
    }

    /// <summary>
    /// Gets or sets the <see cref="ITokenStream"/> for the translator.
    /// </summary>
    public static BufferedTokenStream? Tokens { get; set; }
} 