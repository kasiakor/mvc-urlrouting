using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlsAndRouting.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id = "default")
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
            ViewBag.Id= id;
            return View("ActionName");
        }

        public ActionResult CustomVariable(string id)
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "CustomVariable";
            //using RouteData.Values property
            //ViewBag.CustomVariable = RouteData.Values["id"];

            //matches a URL against the route
            //Home/CustomVariable/Hello with id="Helllo"
            //if id not provided id = null. ?? returns first no null value
            ViewBag.CustomVariable = id ?? "<no value>";
            return View("CustomVariable");
        }

        public RedirectToRouteResult MyActionMethod()
        {
            return RedirectToAction("Index", "Customer", new { id = "Monkey"});
        }
    }
}