namespace DropDownTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fourthemployeeschema : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "EmployeeAge");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "EmployeeAge", c => c.Int(nullable: false));
        }
    }
}
