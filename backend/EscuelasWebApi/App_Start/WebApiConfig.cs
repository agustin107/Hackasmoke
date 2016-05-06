using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace EscuelasWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.SuppressDefaultHostAuthentication();
          //config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute(
               name: "ControllerOnly",
               routeTemplate: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
);
            config.Routes.MapHttpRoute(
                name: "Default",
                //routeTemplate: "api/{controller}/{id}",
                routeTemplate: "{controller}/{action}"

            );
            // Web API routes





            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
