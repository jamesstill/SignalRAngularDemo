using System.Net;
using System.Net.Http;
using SignalRAngularDemo.Hubs;
using SignalRAngularDemo.Models;

namespace SignalRAngularDemo.Controllers
{
    public class WidgetController : SignalRBase<WidgetHub>
    {
        // POST api/<controller>
        public HttpResponseMessage Post(Widget item)
        {
            if (item == null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

            // validate and add to database in a real app

            // notify all connected clients
            Hub.Clients.All.acceptWidget(item);
            
            // return the item inside of a 201 response
            return Request.CreateResponse(HttpStatusCode.Created, item);
        }
    }
}