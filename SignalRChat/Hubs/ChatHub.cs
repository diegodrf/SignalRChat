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
            var _user = new User(user);
            var _message = new Message(_user, message);
            _database.AddMessage(_message);

            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
