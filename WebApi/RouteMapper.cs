﻿using DotNetNuke.Web.Api;
using System.Web.Http;

namespace MDP.WebApi
{
    /// <summary>
    /// Class Routemapper.
    /// </summary>
    public class RouteMapper : IServiceRouteMapper
    {
        /// <summary>
        /// Registers the routes.
        /// </summary>
        /// <param name="routeManager">The route manager.</param>
        public void RegisterRoutes(IMapRoute routeManager)
        {
            routeManager.MapHttpRoute("MDP", "default", "{controller}/{action}/{id}", new { id = RouteParameter.Optional }, new[] { "MDP.WebApi" });

            //routeManager.MapHttpRoute("AngularModule", "default1", "{controller}/{action}/{id}", new { id = "" }, new[] { "AngularModule.WebApi" });
            //routeManager.MapHttpRoute("AngularModule", "default2", "{controller}/{action}", new { id = RouteParameter.Optional }, new[] { "AngularModule.WebApi" });
            //routeManager.MapHttpRoute("AngularModule", "default3", "{controller}/{action}/{id}/{name}", new { id = "", name = "" }, new[] { "AngularModule.WebApi" });
        }
    }
}