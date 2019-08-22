using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationsFluent.Migrations
{
    [Migration(888745, "Produto novo")]
    public class _888745_insereprodutostbm : Migration
    {
        public override void Down()
        {
            throw new NotImplementedException();
        }

        public override void Up()
        {
            IfDatabase("SqlServer")
                .Execute.Sql("INSERT INTO Produtos VALUES ('Batata')");
        }
    }
}
