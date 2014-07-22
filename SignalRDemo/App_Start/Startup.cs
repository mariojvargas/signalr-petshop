using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(SignalRDemo.App_Start.Startup))]

namespace SignalRDemo.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            app.Map("/signalr", map =>
            {
                // PM> Install-Package Microsoft.Owin.Cors
                // map.UseCors(CorsOptions.AllowAll);

                map.RunSignalR(new HubConfiguration()
                {
                    EnableDetailedErrors = true,
                    EnableJavaScriptProxies = true,
                    EnableJSONP = false,
                });
            });
        }
    }
}
