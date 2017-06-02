using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownTest.Controllers
{
    public class DepartmentController : Controller
    {

        EmployeeContext db = new EmployeeContext();
        // GET: Department
        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Department dep)
        {
            if (ModelState.IsValid) {
                db.Departments.Add(dep);
                db.SaveChanges();
            }
            return RedirectToAction("Add","Department");
        }
    }
}