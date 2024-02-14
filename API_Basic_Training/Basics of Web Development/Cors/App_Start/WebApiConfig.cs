using System.Web.Http;
using System.Web.Http.Cors;

namespace Cors
{
    public static class WebApiConfig
    {
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
            EnableCorsAttribute cors = new EnableCorsAttribute("http://127.0.0.1:5500, https://docs.google.com", "*", "*");
            config.EnableCors(cors);
        }
    }
}
