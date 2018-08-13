using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace cards4
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );



            routes.MapRoute(
                name: "Home",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "usertbls", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Create",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "usertbls", action = "Create", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Delete",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "usertbls", action = "Delete", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Details",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "usertbls", action = "Details", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Edit",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "usertbls", action = "Edit", id = UrlParameter.Optional }
            );



            routes.MapRoute(
                name: "MainPage",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "cardtbls", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "CreatePage",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "cardtbls", action = "Create", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "DeletePage",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "cardtbls", action = "Delete", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "DetailsPage",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "cardtbls", action = "Details", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "EditPage",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "cardtbls", action = "Edit", id = UrlParameter.Optional }
            );
        }
    }
}
