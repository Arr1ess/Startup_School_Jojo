using System.Collections.Generic;

namespace MyApp.Models
{
    public class Channel
    {
        public int Id { get; set; }
        public int ChannelId { get; set; }
        public string HashCode { get; set; }
        public string Chat { get; set; }
        public List<int> Users { get; set; } = new List<int>();

        public Channel(int channelId = 0, string hashCode = "", string chat = "")
        {
            ChannelId = channelId;
            HashCode = hashCode;
            Chat = chat;
        }
    }
}
