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

namespace Tail.Api.App_Start
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

    public class AuthorizationFilter : ActionFilterAttribute
    {
        public override Task OnActionExecutingAsync(HttpActionContext actionContext, CancellationToken cancellationToken)
        {
            //if (!(actionContext.ControllerContext.Controller is AuthController))
            //{
            //    // Check Token is there and token is valid.
            //    if (actionContext.Request.Headers.Authorization == null)
            //        actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);
            //    else
            //    {
            //        var scheme = actionContext.Request.Headers.Authorization.Scheme;
            //        var token = actionContext.Request.Headers.Authorization.Parameter;
            //        if (!"Bearer".Equals(scheme) || string.IsNullOrEmpty(token))
            //            actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);

            //        var jwtModel = JwtHelper.GetJwtClaimModel(token);

            //        if(jwtModel==null)
            //            actionContext.Response = new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.Unauthorized);


            //    }

            //}

            return base.OnActionExecutingAsync(actionContext, cancellationToken);
        }

        //public override void OnActionExecuting(HttpActionContext actionContext)
        //{
        //    //GetRequestContext(token);
        //    base.OnActionExecuting(actionContext);
        //}

        //public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        //{

        //    //var token = this.GetJwtToken();

        //    //actionExecutedContext.Response.Headers.Add("Authorization", $"Bearer {token}");

        //    base.OnActionExecuted(actionExecutedContext);

        //}

        //private static void GetRequestContext(string token)
        //{
        //    token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1c2VyTmFtZSI6InJhaHVsLmpvc2hpIiwidXNlcklkIjoiNzg5NDU2In0.MEa910yquCj29U-RfRH55gvqrX-yaYSuTQoPU_bJODg";
        //    var secret = "GQDstcKsx0NHjPOuXOYg5MbeJ1XT0uFiwDVvVBrk";

        //}
    }
}