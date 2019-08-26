using System;
using FluentMigrator.Runner;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;
using FluentMigrator.Runner.Initialization;
using FluentMigrator;

namespace ClassLibrary1
{
    [Migration(9419096, "Ajuste legal")]
    public class MyMigration : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            Execute.Sql("Insert into Usuarios VALUES ('teste')");
        }
    }
}