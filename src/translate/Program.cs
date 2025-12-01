// <copyright file="Program.cs">
// All rights reserved.
// </copyright>

using CliFx;
using CliFx.Attributes;
using CliFx.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
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

#if DEBUG
                        restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Debug,
#else
                        restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Warning,
#endif
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
                .AddKeyedSingleton<IParser, Amazon.Redshift.SqlParser>(SourceType.AmazonRedshift)

                // Writer Extensions
                .AddKeyedSingleton<IWriter, Microsoft.SqlServer.SqlServerWriter>(TargetType.MicrosoftSqlServer)

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