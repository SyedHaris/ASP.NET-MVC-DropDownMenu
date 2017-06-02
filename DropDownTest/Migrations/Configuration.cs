namespace DropDownTest.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<DropDownTest.EmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DropDownTest.EmployeeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            Department dep1 = new Department { DepartmentName = "IT" };
            
            Department dep2 = new Department {  DepartmentName="Finance" };


            Employee emp1 = new Employee { EmployeeName = "Haris", EmployeeSalary = 50000,Department=dep1 };
            Employee emp2 = new Employee { EmployeeName="abc",EmployeeSalary=20000, Department = dep2 };

            context.Employees.Add(emp1);
            context.Employees.Add(emp2);

            context.Departments.AddOrUpdate(dep1,dep2);
            
        }
    }
}
