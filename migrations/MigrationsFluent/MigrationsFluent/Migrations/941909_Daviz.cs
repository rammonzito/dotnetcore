using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationsFluent.Migrations
{
    [Migration(941909, "Nome incorreto")]
    public class _941909_Daviz : Migration
    {
        public override void Up()
        {
            IfDatabase("SqlServer")
                .Execute.Sql("UPDATE Usuarios SET Nome = Nome + ' - ' + 'Developer' " +
                "WHERE Nome IS NOT NULL");
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }


    }
}
