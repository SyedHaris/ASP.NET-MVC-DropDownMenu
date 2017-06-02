namespace DropDownTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Firstemployeeschema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        Employee_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.DepartmentId)
                .ForeignKey("dbo.Employees", t => t.Employee_EmployeeId)
                .Index(t => t.Employee_EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        EmployeeName = c.String(),
                        EmployeeSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Departments", "Employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Departments", new[] { "Employee_EmployeeId" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
