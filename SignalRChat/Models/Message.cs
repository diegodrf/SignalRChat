namespace SignalRChat.Models
{
    public class Message
    {
        public User User { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; }

        public Message(User user, string text)
        {
            User = user;
            Text = text;
            CreatedAt = DateTime.UtcNow;
        }

    }
}
