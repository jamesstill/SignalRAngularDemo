using System;
using System.Web.Http;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace SignalRAngularDemo.Hubs
{
    /// <summary>
    /// This code was shamelessly stolen from a presentation by Brad Wilson at
    /// the 2012 Norwegian Developer's Conference (NDC). The video is hosted 
    /// online here: http://vimeo.com/43603472
    /// </summary>
    /// <typeparam name="THub"></typeparam>
    public abstract class SignalRBase<THub> : ApiController where THub : IHub
    {
        private readonly Lazy<IHubContext> _hub = new Lazy<IHubContext>(
            () => GlobalHost.ConnectionManager.GetHubContext<THub>()
        );

        protected IHubContext Hub
        {
            get { return _hub.Value; }
        }
    }
}