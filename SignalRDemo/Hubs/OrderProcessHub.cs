using Microsoft.AspNet.SignalR;
using SignalRDemo.Models;
using System.Threading.Tasks;

namespace SignalRDemo.Hubs
{
    public class OrderProcessHub : Hub
    {
        public override Task OnConnected()
        {
            Groups.Add(Context.ConnectionId, PetShopGroups.ProcessingDepartment);
            return base.OnConnected();
        }

        public override Task OnDisconnected()
        {
            Groups.Remove(Context.ConnectionId, PetShopGroups.ProcessingDepartment);
            return base.OnDisconnected();
        }
    }
}
