using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SignalRAngularDemo.Startup))]
namespace SignalRAngularDemo
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}