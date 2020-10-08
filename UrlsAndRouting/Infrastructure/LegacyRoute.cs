using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace UrlsAndRouting.Infrastructure
{
    public class LegacyRoute : RouteBase
    {
        private string[] urls;

        //ctor takes an array of strings that represent target urls
        public LegacyRoute(params string[] targetUrls)
        {
            urls = targetUrls;
        }

        //GetRouteData(HttpContextBase httpContext) mechanism for matching inbound urls
        //returns frist not-null value
        //returns route information about the request
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            RouteData result = null;

            string requestedUrl = httpContext.Request.AppRelativeCurrentExecutionFilePath;

            //string value, comparer
            if (urls.Contains(requestedUrl, StringComparer.OrdinalIgnoreCase))
            {
                //if match found an instance of RouteData will be returned with values for controller and action
                //MvcRouteHandler will connect routing system to the controller/action model
                //route, route handler
                result = new RouteData(this, new MvcRouteHandler());

                //string key, string value
                result.Values.Add("controller", "Legacy");
                result.Values.Add("action", "GetLegacyURL");
                result.Values.Add("legacyURL", requestedUrl);
            }

            return result;

        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            return null;
        }
    }
}