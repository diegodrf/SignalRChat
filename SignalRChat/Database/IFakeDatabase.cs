using SignalRChat.Models;

namespace SignalRChat.Database
{
    public interface IFakeDatabase
    {
        void AddMessage(Message message);
        IList<Message> GetAllMessages();
    }
}