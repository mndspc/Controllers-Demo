using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return Content("Welcome to employee page");
        }

        [OutputCache(Duration =5)]
        public ActionResult GetTime()
        {
            return Content(DateTime.Now.ToString());
        }

        [ActionName("GetByCode")]

        public ActionResult GetEmployeeDataByEmpCode()
        {
            return Content("Emp Code is 100");
        }

        public ActionResult SearchEmp()
        {
            return RedirectToAction("GetByCode");
        }

        [NonAction]
        public string Test()
        {
            return "This is Test";
        }

        public ActionResult CallTest()
        {
            return RedirectToAction("Test");
        }

        [HttpGet]
        public ActionResult LoginView()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login()
        {
            return Content("User Logged In");
        }

    }
}