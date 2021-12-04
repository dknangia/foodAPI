using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Food
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

           

            config.Routes.MapHttpRoute(
              name: "Foods",
              routeTemplate: "api/foods/{foodId}",
              defaults: new { controller = "Foods", foodId = RouteParameter.Optional }
          );

            config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{controller}/{id}",
               defaults: new { id = RouteParameter.Optional }
           );
        }
    }
}
