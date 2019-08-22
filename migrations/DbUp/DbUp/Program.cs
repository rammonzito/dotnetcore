using DbUp;
using System;
using System.Linq;
using System.Reflection;

namespace DbUpDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connectionString =
                args.FirstOrDefault()
                ?? "Data Source=localhost;Initial Catalog=Mocks;User ID=rootmock;Password=123456abc@";

            var upgrader =
                DeployChanges.To
                    .SqlDatabase(connectionString)
                    .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
                    .LogToConsole()
                    .Build();

            var result = upgrader.PerformUpgrade();

            if (!result.Successful)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(result.Error);
                Console.ResetColor();

            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Success!");
            Console.ResetColor();
        }
    }
}
