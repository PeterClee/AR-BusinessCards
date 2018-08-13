using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace businesscardapp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "usrtbl", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Create",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "usrtbl", action = "Create", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Delete",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "usrtbl", action = "Delete", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Details",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "usrtbl", action = "Details", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Edit",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "usrtbl", action = "Edit", id = UrlParameter.Optional }
            );
        }
    }
}
