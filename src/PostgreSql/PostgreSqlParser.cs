// <copyright file="PostgreSqlParser.cs">
// All rights reserved.
// </copyright>

using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PostgreSql.Visitors;
using Tradurre;

namespace PostgreSql;

public class PostgreSqlParser : IParser
{
    private readonly ILogger _logger;

    private readonly IServiceProvider _provider;

    private CommonTokenStream _tokens;

    /// <summary>
    /// Initializes a new instance of the <see cref="PostgreSqlParser"/> class with the specified <see cref="ILogger{TCategoryName}"/>.
    /// </summary>
    /// <param name="logger"></param>
    public PostgreSqlParser(ILogger<PostgreSqlParser> logger, IServiceProvider provider)
    {
        logger.TraceEntry();
        _logger = logger;
        _provider = provider;
    }

    /// <inheritdoc/>
    public ParseResult Parse(string statement)
    {
        _logger.TraceEntry();

        ParseResult result = new();

        AntlrInputStream stream = new(statement);
        PostgresLexer lexer = new(stream);
        _tokens = new CommonTokenStream(lexer);
        PostgresParser parser = new(_tokens);
        parser.Interpreter.PredictionMode = PredictionMode.LL;

#if DEBUG
        parser.Interpreter.PredictionMode = PredictionMode.LL_EXACT_AMBIG_DETECTION;
#endif

        var listeners_o = _provider.GetServices<IAntlrErrorListener<object>>();

        if (listeners_o != null && listeners_o.Any())
        {
            parser.RemoveErrorListeners();

            foreach (var listenero in listeners_o)
            {
                parser.AddErrorListener(listenero);
            }
        }

        var listenersi = _provider.GetServices<IAntlrErrorListener<int>>();

        if (listenersi != null && listenersi.Any())
        {
            lexer.RemoveErrorListeners();

            foreach (var listeneri in listenersi)
            {
                lexer.AddErrorListener(listeneri);
            }
        }

        var context = parser.batch();
        return new BatchVisitor(_logger).VisitBatch(context);
    }
}