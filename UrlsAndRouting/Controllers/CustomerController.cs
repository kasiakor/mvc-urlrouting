﻿using System;
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

        //if we dont add the contraint int
        //the current request is ambiguous between the following action methods
        [Route("Users/Add/{user}/{id:int}")]
        public string Create(string user, int id)
        {
            return string.Format("The user name is {0}, and her id is {1}", user, id);
        }

        [Route("Users/Add/{user}/{password}")]
        public string CghangePassword(string user, string password)
        {
            return string.Format("The user name is {0}, and her new password is {1}", user, password);
        }
    }
}