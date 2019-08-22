using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationsFluent.Migrations
{
    [Migration(201908219419092, "Issue 941909 - other script")]
    public class AddLogTable : Migration
    {
        public override void Up()
        {

            //Testing Execute
            IfDatabase("SqlServer").Insert.IntoTable("Usuarios").Row(new { Nome = "Kashiha" });
        }
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }

}
