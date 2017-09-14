using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using System.Web.Http.Hosting;

namespace TailApi.Application
{
    public class MessageHandler : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {

            var routeData = request.GetRouteData();

            //IRequestContext rc = new RequestContext("gdeleon", "!password!", 92749, "solismammotest", null, "", "");
            //GlobalContext.Add(rc);

            //Debug.WriteLine("Process request");
            //// Call the inner handler.
            var response = await base.SendAsync(request, cancellationToken);
            //Debug.WriteLine("Process response");
            return response;
        }


    }
}