using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UrlsAndRouting.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        [Route("Test")]
        public ActionResult Index(string id)
        {
            ViewBag.Controller = "Customer";
            ViewBag.Action = "Index";
            //when route attribute is added the new static route has been created. we lost id segment.
            ViewBag.Id = id;
            return View("ActionName");
        }

        [Route("Users/Add/{user}/{id}")]
        public string Create(string user, int id)
        {
            return string.Format("The user name is {0}, and her id is {1}", user, id);
        }
    }
}