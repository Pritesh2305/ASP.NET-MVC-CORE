using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllertype.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        // Action Method With View as Result
        public ActionResult Getstd()
        {
            int stdid = 101;
            string stdnm = "Pritesh Bhavsar";
            Response.Write("Student Id : " + stdid + "<br>");
            Response.Write("Student Name : " + stdnm + "<br>");
            Response.Write("Student Total : " + this.GetTotal(10,23,20) + "<br>");

            return View();
        }

        // Action Method With Non-View Result
        public ActionResult Getdatetime()
        {
            return Content(DateTime.Today.ToString());
        }   
        
        // Non- Action Method
        [NonAction]
        public int GetTotal(int m1,int m2,int m3)
        {
            return m1+m2+m3;
        }
    }
}