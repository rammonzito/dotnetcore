using FluentMigrator;
using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationsFluent.Migrations
{
    [Migration(20190, "Issue 941909 - other script")]
    public class AddLogTable : Migration
    {
        public override void Up()
        {

            //Testing Execute
            IfDatabase("SqlServer").Update.Table("Usuarios").Set(new { Nome = "John" }).Where(new { Nome = "Jonis - Developer" });
        }
        public override void Down()
        {
            throw new NotImplementedException();
        }
    }

}
