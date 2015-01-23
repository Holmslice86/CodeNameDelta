using CodeNameDelta.Service.App_Start;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace CodeNameDelta.Service
{
    public static class WebApiConfig
    {

        public static void Register(HttpConfiguration config)
        {
            var container = UnityLazyInit.Container;

            config.Services.Replace(typeof(IHttpControllerActivator), new UnityHttpControllerActivator(container));


            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
