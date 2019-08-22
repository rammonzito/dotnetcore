using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationsFluent.Migrations
{
    [Migration(9419091, "Produtos restantes")]
    public class _941909_InsertProdutos : Migration
    {
        public override void Up()
        {
            IfDatabase("SqlServer")
                .Execute.Sql("INSERT INTO Produtos VALUES ('Arroz')");
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }


    }
}
