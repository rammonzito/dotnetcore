using FluentMigrator;
using System;

namespace MigrationsFluent
{
    [Migration(20190821941909, "Issue 941909")]
    public class AddLogTable : Migration
    {
        public override void Up()
        {
            //Testing Expression
            IfDatabase("SqlServer").Create.Table("Log")
                .WithColumn("Id").AsInt64().PrimaryKey().Identity()
                .WithColumn("Text").AsString();
        }

        public override void Down()
        {
            throw new NotImplementedException();
        }
    }
}