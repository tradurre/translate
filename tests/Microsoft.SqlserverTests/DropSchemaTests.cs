using Microsoft.Extensions.Logging;
using Microsoft.SqlServer.Writers;
using Tradurre;

namespace Microsoft.SqlServer;

[TestClass]
public sealed class DropSchemaTests
{
    [TestMethod]
    [DataRow("s1", "WARNING: \r\n-- Source: \r\n/*\r\n\r\n*/\r\nDROP SCHEMA s1;\r\n", DropSchemaOption.Cascade)]
    public void Options(string names, string expected, DropSchemaOption option, bool if_exists = false)
    {
        DropSchemaStatement statement = new(new Source("DROP SCHEMA..."))
        {
            IfExists = if_exists,
            Options = option
        };

        string[] schema_names = names.Split(',');

        foreach (string schema_name in schema_names)
            statement.Names.Add(new SchemaName(schema_name, new Source()));

        SqlWriter writer = GetWriter();
        var result = writer.Write(statement);

        Assert.AreEqual(expected, result.Statement);
    }

    [TestMethod]
    [DataRow("s1", "DROP SCHEMA s1;\r\n")]
    [DataRow("s1", "DROP SCHEMA IF EXISTS s1;\r\n", true)]
    [DataRow("s1,s2", "DROP SCHEMA s1;\r\nDROP SCHEMA s2;\r\n")]
    [DataRow("s1,s2", "DROP SCHEMA IF EXISTS s1;\r\nDROP SCHEMA IF EXISTS s2;\r\n", true)]
    public void Primary(string names, string expected, bool if_exists = false)
    {
        DropSchemaStatement statement = new(new Source())
        {
            IfExists = if_exists
        };

        string[] schema_names = names.Split(',');

        foreach (string schema_name in schema_names)
            statement.Names.Add(new SchemaName(schema_name, new Source()));

        SqlWriter writer = GetWriter();
        var result = writer.Write(statement);

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