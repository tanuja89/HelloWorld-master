﻿
namespace HelloWorldAPI
{
    using System.Web.Http;

    /// <summary>
    /// Sets up Web API (routing, etc)
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers and configures Web API
        /// </summary>
        /// <param name="config">Http Configuration</param>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
