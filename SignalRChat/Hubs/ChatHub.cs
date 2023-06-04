using Microsoft.AspNetCore.SignalR;
using SignalRChat.Database;
using SignalRChat.Models;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IFakeDatabase _database;
        public ChatHub(IFakeDatabase database) { 
            _database = database;
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
