using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace GMUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connetionString = "Data Source=localhost;Initial Catalog=Mocks;User ID=rootmock;Password=123456abc@";
            var evolveConnection = new SqlConnection(connetionString);

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            // entry to run app
            serviceProvider.GetService<App>().Run();

            try
            {
                var evolve = new Evolve.Evolve(evolveConnection, null/* msg => _logger.LogInformation("testing migration")*/)
                {
                    Locations = new List<string> { "Migrations/db/dataset" },
                    IsEraseDisabled = true,

                };

                //var evolve = new Evolve.Evolve(evolveConnection, null);


                //evolve.Locations = new List<string> { @"Migrations/db" };
                //evolve.IsEraseDisabled = true;
                
                evolve.Migrate();
            }
            catch (Exception ex)
            {
                //_logger.LogCritical("Database migration failed.", ex);
                throw ex;
            }
        }
        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            // add configured instance of logging
            serviceCollection.AddSingleton(new LoggerFactory()
              .AddConsole()
              .AddDebug());

            // add logging
            serviceCollection.AddLogging();

            // build configuration
            var configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("app-settings.json", false)
              .Build();
            serviceCollection.AddOptions();
            serviceCollection.Configure<AppSettings>(configuration.GetSection("Configuration"));

            // add services 
            serviceCollection.AddTransient<ITestService, TestService>();

            // add app
            serviceCollection.AddTransient<App>();
        }
    }
}
