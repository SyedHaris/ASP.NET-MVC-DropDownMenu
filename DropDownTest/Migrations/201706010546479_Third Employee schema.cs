namespace DropDownTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdEmployeeschema : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "EmployeeAge", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "EmployeeAge");
        }
    }
}
