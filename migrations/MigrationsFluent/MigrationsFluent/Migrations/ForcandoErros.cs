using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationsFluent.Migrations
{
    [Migration(555141, "Forçando alguns erros")]
    public class ForcandoErros : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            //string path = "db";
            IfDatabase("SqlServer")
                .Execute.Sql("INSERT INTO Produtos VALUES ('feijão')");
        }
    }
}
