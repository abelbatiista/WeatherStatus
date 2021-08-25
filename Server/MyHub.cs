using Microsoft.AspNet.SignalR.Hubs;
using Microsoft.AspNet.SignalR;

namespace Server
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
