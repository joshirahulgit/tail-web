using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.Http.Controllers;
using System.Text;
using JWT;
using JWT.Serializers;
using Newtonsoft.Json;
using JWT.Algorithms;
using System.Net.Http.Formatting;
using Newtonsoft.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using TailApi.Application.Controllers;

namespace Tail_Api.App_Start
{
    public class HttpRouteConfiguration
    {
        public static HttpConfiguration Get()
        {

            var httpConfiguration = new HttpConfiguration();

            // Configure Web API Routes:
            // - Enable Attribute Mapping
            // - Enable Default routes at /api.
            httpConfiguration.MapHttpAttributeRoutes();
            httpConfiguration.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //var jsonFormatter = httpConfiguration.Formatters.OfType<JsonMediaTypeFormatter>().First();
            //jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            httpConfiguration.SuppressDefaultHostAuthentication();

            //httpConfiguration.MessageHandlers.Add(new MessageHandler());

            //httpConfiguration.Filters.Add(new AuthorizationFilter());

            return httpConfiguration;
        }
    }
}