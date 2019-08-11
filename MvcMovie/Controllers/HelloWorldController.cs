using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 
        public ActionResult Index()
        {
            return View();
        }
        //The Index method above uses a view template to generate an HTML response to the browser.Controller methods
        //(also known as action methods), such as the Index method above, generally return an ActionResult(or a 
        //class derived from ActionResult), not primitive types like string.

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}