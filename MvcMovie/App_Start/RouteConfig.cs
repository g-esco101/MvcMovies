using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcMovie
{
    public class RouteConfig
    {
        /*The MapRoute method is used to route HTTP requests to the correct controller and action
         * method and supply the optional ID parameter. The MapRoute method is also used by the 
         * HtmlHelpers such as ActionLink to generate URLs given the controller, action method and 
         * any route data.*/
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
            name: "Hello",
            url: "{controller}/{action}/{name}/{id}"
            );
        }
    }
}
