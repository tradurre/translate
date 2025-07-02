// <copyright file="Program.cs">
// All rights reserved.
// </copyright>

using CliFx;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.SqlServer;
using Serilog;
using Tradurre.Commands;
using Tradurre.Themes;

namespace Tradurre;

/// <summary>
/// The static program class.
/// </summary>
public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        try
        {
            ServiceProvider provider = new ServiceCollection()
                .AddLogging(builder =>
                {
                    var log_config = new LoggerConfiguration()
                    .MinimumLevel.Verbose()
                    .WriteTo.Console(
                        formatProvider: null,
                        outputTemplate: "{Level}: {Message:lj}{NewLine}{Exception}",
                        restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Verbose,
                        theme: ConsoleTheme.Translate
                        )
                    .CreateLogger();

                    builder.AddSerilog(log_config);
                })

                // Commands
                .AddSingleton<ParseCommand>()
                .AddSingleton<TranslateCommand>()

                .AddSingleton<ITranslator, Translator>()

                // Parser Extensions
                .AddKeyedSingleton<IParser, SqlServerParser>(SourceType.MicrosoftSqlServer)
                .AddKeyedSingleton<IParser, PostgreSql.PostgreSqlParser>(SourceType.PostgreSQL)

                // Writer Extensions
                .AddKeyedSingleton<IWriter, SqlServerWriter>(TargetType.MicrosoftSqlServer)
                .AddKeyedSingleton<IWriter, PostgreSql.PostgreSqlWriter>(TargetType.PostgreSQL)

                .BuildServiceProvider();

            return await new CliApplicationBuilder()
                .AddCommandsFromThisAssembly()
                .UseTypeActivator(provider)
                .Build()
                .RunAsync()
                .ConfigureAwait(false);
        }
        catch (Exception ex)
        {
            Log.Logger.Fatal(ex.Message);

#if DEBUG
            Log.Logger.Fatal(ex.ToString());
#endif
            return -1;
        }
    }
}