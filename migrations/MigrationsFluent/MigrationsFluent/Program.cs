using System;
using FluentMigrator.Runner;
using FluentMigrator.Runner.Processors.SqlServer;
using FluentMigrator.Runner.Initialization;
using Microsoft.Extensions.DependencyInjection;
using FluentMigrator;

namespace MigrationsFluent
{
    public class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = CreateServices();

            using (var scope = serviceProvider.CreateScope())
            {
                UpdateDatabase(scope.ServiceProvider);
            }

        }
        private static IServiceProvider CreateServices()
        {
            var connetionString = "Data Source=localhost;Initial Catalog=Moq;User ID=rootmock;Password=123456abc@";

            return new ServiceCollection()
            .AddFluentMigratorCore()
            .ConfigureRunner(r => r
            .AddSqlServer()
            .WithGlobalConnectionString(connetionString)
            .ScanIn(typeof(AddLogTable).Assembly).For.Migrations()
            )
            .AddLogging(l => l.AddFluentMigratorConsole())
            .BuildServiceProvider(false);
        }

        private static void UpdateDatabase(IServiceProvider serviceProvider)
        {
            try
            {

                var runner = serviceProvider.GetRequiredService<IMigrationRunner>();
                runner.MigrateUp();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
