using System.Web.Mvc;
using System.Web.Routing;
using UrlsAndRouting.Infrastructure;

namespace UrlsAndRouting
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            //legacy urls
            //route base item, object
            //target urls
            routes.Add(new LegacyRoute(
                "~/articles/vegetarian",
                "~/old/expired/page"));
            //disabled by default
            //routes.MapMvcAttributeRoutes();

            //constraints added to remove error related to home/index in Areas, multiple types
            routes.MapRoute("MyRoute", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = UrlParameter.Optional }, new[] { "UrlsAndRouting.Controllers" });

            ///Home/Index/9 9 will be skipped and Index will return ActionName View
            ///id is null but default value is provided
            //routes.MapRoute("MyRoute0", "{controller}/{action}/{id}", new { controller = "Home", action = "Index", id = "DefaultId" });

            //id is null, check action method when id is optional, no default value provided
            //routes.MapRoute("MyRoute0", "{controller}/{action}/{id}/{*catchall}", new { controller = "Home", action = "Index", id = UrlParameter.Optional },  new { controller = "^H.*", action = "Index|About", id = new MinLengthRouteConstraint(3) });

            //preserve old url Home/Index, new url Shop/Index
            //routes.MapRoute("ShopSchema", "Shop/{action}", new { controller = "Home" });

            //static segments
            //routes.MapRoute("", "P{controller}/{action}", new { controller = "Home", action = "Index" });
            //3rd param object defaults
            // routes.MapRoute("MyRoute", "{controller}/{action}", new { controller = "Home", action = "Index" });
            //name: "Default",
            //url: "{controller}/{action}/{id}",
            //defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }  
        }
    }
}
