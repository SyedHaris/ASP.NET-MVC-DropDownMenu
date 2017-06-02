using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownTest
{
    public class EmployeeController : Controller
    {
        EmployeeContext db = new EmployeeContext();
        
        [HttpGet]
        public ActionResult Add() {
            ViewBag.Departments = new SelectList(db.Departments, "DepartmentId", "DepartmentName");
            return View();
        }

        [HttpPost]
        public ActionResult Add(EmployeeViewModel emp)
        {
            Employee employee = new Employee();
            Department dep = db.Departments.Find(emp.DepartmentId);
            employee.Department = dep;
            employee.EmployeeName = emp.EmployeeName;
            employee.EmployeeSalary = emp.EmployeeSalary;
            db.Employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("Add", "Employee");
        }
    }
}