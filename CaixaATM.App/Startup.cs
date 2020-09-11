using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;
using Serilog;
using CaixaATM.Data.Repository;
using CaixaATM.Application.Services;
using CaixaATM.Domain;

namespace CaixaATM.App
{
    public static class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            var logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            services.AddSingleton(logger);

            logger.Information("Carregando configurações...");

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile($"appsettings.json");
            var configuration = builder.Build();
            
            services.AddSingleton<IConfiguration>(configuration);

            services.AddTransient<IAtendimentoATM, AtendimentoATM>();
            services.AddTransient<IOperacoesATMServices, OperacoesATMServices>();
            services.AddSingleton<IATMRepository, ATMRepository>();

            services.AddSingleton<Mock>();
            services.AddSingleton<ConsoleApp>();
        }
    }
}
