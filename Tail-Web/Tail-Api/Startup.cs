using Microsoft.Owin;
using Tail.Api;

[assembly: OwinStartup(typeof(Startup))]
namespace Tail.Api
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

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {

            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);

            // Add SignalR to the OWIN pipeline
            //
            app.MapSignalR();
            //app.RunSignalR();

            // Build up the WebAPI middleware
            //
            var httpConfig = HttpRouteConfiguration.Get();
            app.UseWebApi(httpConfig);

            var fileServerOptions = PublicFileConfiguration.Get();
            app.UseFileServer(fileServerOptions);

            //this.StartSignalR(app);
        }

        private void StartSignalR(IAppBuilder app)
        {
            //Log.Logger = new LoggerConfiguration()
            //    .WriteTo.ColoredConsole()
            //    .CreateLogger();

            string baseAddress = "http://localhost:7887/";

            // Start OWIN host 
            //using (WebApp.Start<Startup>(url: baseAddress))
            //{
            // Let's wire up a SignalR client here to easily inspect what
            //  calls are happening
            //

            var hubConnection = new HubConnection(baseAddress);
            IHubProxy eventHubProxy = hubConnection.CreateHubProxy("EventHub");
            eventHubProxy.On<string, ChannelEvent>("OnEvent", (channel, ev) =>
            {
                //Log.Information("Event received on {channel} channel - {@ev}", channel, ev)
            });
            hubConnection.Start().Wait();

            // Join the channel for task updates in our console window
            //
            eventHubProxy.Invoke("Subscribe", Constants.AdminChannel);
            eventHubProxy.Invoke("Subscribe", Constants.TaskChannel);

            Console.WriteLine($"Server is running on {baseAddress}");
            Console.WriteLine("Press <enter> to stop server");
            Console.ReadLine();

            //}
        }
    }
}
