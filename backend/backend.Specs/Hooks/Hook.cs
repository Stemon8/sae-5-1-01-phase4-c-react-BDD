using System;
using backend.Data;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TechTalk.SpecFlow;

namespace backend.Specs.Hooks
{
    [Binding]
    public class Hooks
    {
        
        private const string AppSettingsFile = "Json/appsettings.json";
        
        private WebApplicationFactory<Program> GetWebApplicationFactory() =>
            new WebApplicationFactory<Program>()
                .WithWebHostBuilder(builder =>
                {
                    builder.ConfigureServices(services =>
                    {
                        services.AddDbContext<EntityContext>(opt =>
                            opt.UseNpgsql(
                                "Server=localhost;Port=5432;Database=cucumberTest;Username=postgres;Password=postgres"));
                    });

                    IConfigurationSection? configSection = null;
                    builder.ConfigureAppConfiguration((context, config) =>
                    {
                        config.AddJsonFile(Path.Combine(Directory.GetCurrentDirectory(), AppSettingsFile));
                        configSection = context.Configuration.GetSection("ConnectionStrings");
                    });
                });
    }
}