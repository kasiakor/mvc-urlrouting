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
        public ActionResult Index()
        {
            ViewBag.Controller = "Home";
            ViewBag.Action = "Index";
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
            ViewBag.CustomVariable = id;
            return View("CustomVariable");
        }
    }
}