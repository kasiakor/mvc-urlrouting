using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            ///Home/Index/9 9 will be skipped and Index will return ActionName View
            routes.MapRoute("MyRoute0", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = "DefaultId" });

            //preserve old url Home/Index, new url Shop/Index
            routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home" });

            //static segments
            //routes.MapRoute("", "P{controller}/{action}", new { controller = "Home", action = "Index" });
            //3rd param object defaults
            routes.MapRoute("MyRoute", "{controller}/{action}", new { controller = "Home", action = "Index" });
                //name: "Default",
                //url: "{controller}/{action}/{id}",
                //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }  
        }
    }
}
