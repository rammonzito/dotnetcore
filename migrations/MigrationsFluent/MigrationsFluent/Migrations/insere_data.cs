using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationsFluent.Migrations
{
    [Migration(88896, "esqueci do produto")]
    public class insere_data : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            IfDatabase("SqlServer")
                .Execute.Sql("INSERT INTO Produtos Values ('bisnaguinha')");
        }
    }
}
