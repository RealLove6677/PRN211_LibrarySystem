﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LibraryAsp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "handle",
               url: "change-status/{id}/{status}",
               defaults: new { controller = "BorrowBook", action = "changeStatus" }
           );
            routes.MapRoute(
               name: "postDetails",
               url: "postDetails/{id}",
               defaults: new { controller = "Post", action = "getPostById" }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
