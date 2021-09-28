using Microsoft.AspNetCore.SignalR;

namespace MessengerServer.Hubs
{
    public class MessengerHub : Hub
    {
        public async Task GroupMessage(string message)
        {
            Console.WriteLine(message);
            await this.Clients.Others.SendAsync(ActionName.Send.ToString(), message);
        }
    }
}