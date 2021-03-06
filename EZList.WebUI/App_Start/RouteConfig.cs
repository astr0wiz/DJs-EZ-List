﻿using System.Web.Mvc;
using System.Web.Routing;

namespace EZList.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "DJList", action = "List", id = UrlParameter.Optional }
            );
        }
    }
}
