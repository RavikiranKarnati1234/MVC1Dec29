using MVCSample29Dec.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample29Dec.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult GetEmployeeDetails()
        {
            EmpDept empdept = new EmpDept()
            {
                FirstName = "Ravi",
                DepartmentName="FS"
            };

            return View(empdept);
        }
    }
}