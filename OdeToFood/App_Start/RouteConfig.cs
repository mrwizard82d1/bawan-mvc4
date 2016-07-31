using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OdeToFood
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // /Cuisine/french

            // If we allow the user to enter routes like the previous route, we would have an issue: every cuisine, 
            // like french, would require us to implement an appropriately named action method. Although this approach
            // is doable, it would be better to treat the last component of the URL as a parameter rather than an action.
            //
            // Because the default route matches the preceeding route, we must map this route using different 
            // information. Because the routing engine looks at candidate routes using the routes in the order defined,
            // we must create the new route **before** the default route.

            routes.MapRoute("Cuisine", "Cuisine/{name}",
                new {controller = "Cuisine", action = "Search", name = UrlParameter.Optional});

            // /Home

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}