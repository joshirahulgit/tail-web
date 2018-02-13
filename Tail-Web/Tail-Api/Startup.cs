using Microsoft.Owin;
using Tail_Api;

[assembly: OwinStartup("TailWeb", typeof(Startup))]
namespace Tail_Api
{
    using System.Web.Http;
    using Microsoft.Owin;
    using Microsoft.Owin.Extensions;
    using Microsoft.Owin.FileSystems;
    using Microsoft.Owin.StaticFiles;
    using Owin;
    using System;
    using App_Start;
    using Microsoft.IdentityModel.Tokens;
    using System.Text;
    using Microsoft.Owin.Security.OAuth;
    using System.Threading.Tasks;
    using System.Security.Claims;
    using Microsoft.AspNet.SignalR.Client;
    using Microsoft.AspNet.SignalR;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.MapSignalR();

            var httpConfig = HttpRouteConfiguration.Get();
            app.UseWebApi(httpConfig);

            var fileServerOptions = PublicFileConfiguration.Get();
            app.UseFileServer(fileServerOptions);
        }
    }
}
