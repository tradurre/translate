

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Tradurre;

namespace Amazon.Redshift;

public class SqlParser : IParser
{
    private readonly ILogger<SqlParser> _logger;
    private readonly IServiceProvider _provider;

    /// <summary>
    /// Initializes a new instance of the <see cref="SqlParser"/> with the specified <see cref="ILogger{TCategoryName}"/>.
    /// </summary>
    /// <param name="logger">An <see cref="ILogger{TCategoryName}"/>.</param>
    /// <param name="provider">An <see cref="IServiceProvider"/> for additional services.</param>
    public SqlParser(ILogger<SqlParser> logger, IServiceProvider provider)
    {
        _logger = logger;
        _provider = provider;

        _logger.TraceEntry();

    }

    public ParseResult Parse(string statement)
    {
        _logger.TraceEntry();

        ParseResult result = new();

        try
        {

            AntlrInputStream stream = new(statement);
            RedshiftLexer lexer = new(stream);
            CommonTokenStream tokens = new(lexer);
            RedshiftParser parser = new(tokens);

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

            // Visit
            parser.batch();
            //BatchVisitor visitor = new(_logger);
        }
        catch (Exception ex)
        {
            _logger.LogError("{Error}", ex);
            // TODO: result.Errors.Add(new Error(ex.Message, ));
        }

        return result;
    }
}