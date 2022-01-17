using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Welcome to Index Page";
        }

        public string  AboutUs()
        {
            return "Welcome to About-US";
        }

        public string GetEmpCode(int id)
        {
            return $"Employee Code:{id}";
        }

        public ActionResult IndexView()
        {
            return View();
            //return View("ViewName");
        }

        public ActionResult NavigateToMsdn()
        {
            return Redirect("https://www.msdn.com");
        }

        public ActionResult NavigateToIndex()
        {
            return RedirectToAction("IndexView");
            //  if action method is in different controller
            //return Redirect("Controller/ActionName");
        }

        public ActionResult RedirectToNewRoute()
        {
            return RedirectToRoute(new { 
                controller="Employee",
                action="Index"
            }); ;
        }

        public ActionResult PrintMessage()
        {
            return Content("<b>This is Test Message</b>");
        }

        public ActionResult OpenFile()
        {
            return new FilePathResult(@"~\Files\angularjs_tutorial.pdf", "application/pdf");
        }

        public ActionResult ShowEmpty()
        {
            return new EmptyResult();
        }
    }
}