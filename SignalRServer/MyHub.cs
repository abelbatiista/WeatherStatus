using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR;

namespace SignalRServer
{
    [HubName("WeatherHub")]
    public class MyHub : Hub
    {
        public void Notify(string info)
        {
            Clients.All.SendInfo(info);
        }
    }
}
