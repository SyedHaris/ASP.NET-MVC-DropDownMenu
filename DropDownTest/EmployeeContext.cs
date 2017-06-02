namespace DropDownTest
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class EmployeeContext : DbContext
    {
        // Your context has been configured to use a 'EmployeeModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DropDownTest.EmployeeModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'EmployeeModel' 
        // connection string in the application configuration file.
        public EmployeeContext()
            : base("name=EmployeeModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Employee> Employees { get; set; }
         public virtual DbSet<Department> Departments { get; set; }
    }

    public class Employee
    {
        public Employee() {
        }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }
        public virtual Department Department { get; set; } 

    }

    public class Department {

        public Department() {
            Employees = new List<Employee>();
        }
        public int DepartmentId { get; set; }
        [Required]
        public String DepartmentName { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }


    public class EmployeeViewModel {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }
        public int DepartmentId { get; set; }
    }
}