using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_JobPortalProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Enabling Attribute Routing for Application
            //routes.MapMvcAttributeRoutes();
            routes.MapRoute(
                name: "ForNewsPaper",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Jobs", action = "AddNewsPaper", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Jobs", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
