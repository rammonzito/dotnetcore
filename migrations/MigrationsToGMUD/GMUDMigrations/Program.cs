using log4net.Core;
using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
namespace GMUDMigrations
{
    class Program
    {
        protected readonly ILogger _logger;
        static void Main(string[] args)
        {
            var connetionString = "Data Source=localhost;Initial Catalog=Mocks;User ID=rootmock;Password=123456abc@";
            //var evolveConnection = new SqlConnection();
            try
            {
                //var evolve = new Evolve.Evolve(evolveConnection, msg => _logger.LogInformation("testing migration"))
                //{

                //    Locations = new List<string> { "Migrations/db" },
                //    IsEraseDisabled = true,

                //};

                //evolve.Migrate();
            }
            catch (Exception)
            {
                //_logger.LogCritical("Database migration failed.", ex);
                throw;
            }
        }
    }
}
