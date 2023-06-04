using SignalRChat.Models;

namespace SignalRChat.Database
{
    public class FakeDatabase : IFakeDatabase
    {
        private readonly List<Message> _fakeDatabase = new();

        public IList<Message> GetAllMessages()
        {
            return _fakeDatabase.OrderBy(m => m.CreatedAt).ToList();
        }

        public void AddMessage(Message message)
        {
            _fakeDatabase.Add(message);
        }
    }
}
