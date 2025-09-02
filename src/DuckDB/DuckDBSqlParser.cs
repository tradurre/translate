// <copyright file="DuckDBSqlParser.cs">
// All rights reserved.
// </copyright>

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Tradurre;

namespace DuckDB;

/// <summary>
/// The <see cref="IParser"/> implementation for DuckDB.
/// </summary>
public class DuckDBSqlParser : IParser
{
    private readonly ILogger<DuckDBSqlParser> _logger;
    private readonly IServiceProvider _provider;

    /// <summary>
    /// Initializes a new instance of the <see cref="DuckDBSqlParser"/> with the specified <see cref="ILogger{TCategoryName}"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger{TCategoryName}"/>.</param>
    /// <param name="provider">An <see cref="IServiceProvider"/> for additional services.</param>
    public DuckDBSqlParser(ILogger<DuckDBSqlParser> logger, IServiceProvider provider)
        : base()
    {
        _logger = logger;
        _provider = provider;

        _logger.TraceEntry();
    }

    /// <inheritdoc/>
    public ParseResult Parse(string statement)
    {
        _logger.TraceEntry();

        ParseResult result = new();

        try
        {
            AntlrInputStream stream = new(statement);
            DuckDBLexer lexer = new(stream);
            CommonTokenStream tokens = new(lexer);
            DuckDBParser parser = new(tokens);

            parser.Interpreter.PredictionMode = PredictionMode.LL;

#if DEBUG
            parser.Interpreter.PredictionMode = PredictionMode.LL_EXACT_AMBIG_DETECTION;
#endif
            var int_listeners = _provider.GetServices<IAntlrErrorListener<int>>();

            if (int_listeners != null
                && int_listeners.Count() > 0)
            {
                lexer.RemoveErrorListeners();

                foreach (var int_listener in int_listeners)
                {
                    lexer.AddErrorListener(int_listener);
                }
            }

            var context = parser.batch();

        }
        catch (Exception ex)
        {
            _logger.LogError("{Error}", ex);
        }

        return result;
    }
}