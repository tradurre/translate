using Microsoft.Extensions.Logging;
using Microsoft.SqlServer.Writers;
using Tradurre;

namespace Microsoft.SqlServer;

[TestClass]
public sealed class ViewNameTests
{
    [TestMethod]
    [DataRow("a", "a")]
    [DataRow("a", "[a]", default, true)]
    //[DataRow("a48", "a48")]
    //[DataRow("A", "A")]
    //[DataRow("Aa1", "Aa1")]
    //[DataRow("a", "[a]", true)]
    //[DataRow("a48", "[a48]", true)]
    //[DataRow("A", "[A]", true)]
    //[DataRow("Aa1", "[Aa1]", true)]
    public void Primary(string name, string expected, string? schema = default, bool quoted = false)
    {
        ViewName o = new(name, new Source())
        {
            IsQuoted = quoted
        };

        if (!string.IsNullOrEmpty(schema))
            o.Schema = new(schema, new Source());

        var writer = GetWriter();
        var result = writer.Write(o);

        Assert.AreEqual(expected, result.Statement);
    }

    private SqlWriter GetWriter()
    {
        using var loggerFactory = LoggerFactory.Create(c => c.AddConsole());
        var logger = loggerFactory.CreateLogger<SqlWriter>();
        SqlWriter writer = new(logger);
        return writer;
    }
}