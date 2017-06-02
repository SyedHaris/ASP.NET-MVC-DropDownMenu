namespace DropDownTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fifthemployeeschema : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "DepartmentName", c => c.String());
        }
    }
}
