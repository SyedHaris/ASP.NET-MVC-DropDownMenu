namespace DropDownTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondEmployeeschema : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Departments", "Employee_EmployeeId", "dbo.Employees");
            DropIndex("dbo.Departments", new[] { "Employee_EmployeeId" });
            AddColumn("dbo.Employees", "Department_DepartmentId", c => c.Int());
            CreateIndex("dbo.Employees", "Department_DepartmentId");
            AddForeignKey("dbo.Employees", "Department_DepartmentId", "dbo.Departments", "DepartmentId");
            DropColumn("dbo.Departments", "Employee_EmployeeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Departments", "Employee_EmployeeId", c => c.Int());
            DropForeignKey("dbo.Employees", "Department_DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Department_DepartmentId" });
            DropColumn("dbo.Employees", "Department_DepartmentId");
            CreateIndex("dbo.Departments", "Employee_EmployeeId");
            AddForeignKey("dbo.Departments", "Employee_EmployeeId", "dbo.Employees", "EmployeeId");
        }
    }
}
