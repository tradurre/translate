using Antlr4.Runtime;
using Antlr4.Runtime.Atn;

namespace Amazon.Redshift;

public abstract class ParseTestBase
{
    internal void Parse(string fragment)
    {
        try
        {
            AntlrInputStream stream = new(fragment);
            RedshiftLexer lexer = new(stream);
            CommonTokenStream tokens = new(lexer);
            RedshiftParser parser = new(tokens);
            parser.Interpreter.PredictionMode = PredictionMode.LL;

            parser.batch();

            if (parser.NumberOfSyntaxErrors > 0)
                Assert.Fail($"Syntax Errors: {parser.NumberOfSyntaxErrors}");
        }
        catch (Exception ex)
        {
            Assert.Fail(ex.ToString());
        }
    }
}