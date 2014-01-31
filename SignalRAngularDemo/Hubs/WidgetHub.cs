using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRAngularDemo.Hubs
{
    [HubName("widgets")]
    public class WidgetHub : Hub { }
}