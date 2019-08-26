using FluentMigrator;
using System;

namespace MigrationsFluent
{
    [Migration(941499, "Issue 941909")]
    public class AddLogTable : Migration
    {
        public override void Up()
        {
            //Testing Expression
            IfDatabase("SqlServer").Insert.IntoTable("Usuarios").Row(new { Nome = "felipet" });
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}