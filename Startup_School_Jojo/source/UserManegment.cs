using System.Collections.Generic;
using System.Linq;

namespace MyApp.Models
{
    public static class UserManagement
    {
        private static List<User> users = new List<User>();
        private static List<Channel> channels = new List<Channel>();

        public static void AddUser(User user)
        {
            user.Id = users.Count + 1;
            users.Add(user);
        }

        public static User GetUserById(int userId)
        {
            return users.FirstOrDefault(u => u.Id == userId);
        }

        public static void RemoveUser(int userId)
        {
            var user = users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                users.Remove(user);
            }
        }

        public static void AddFriend(int userId, int friendId)
        {
            var user = GetUserById(userId);
            var friend = GetUserById(friendId);
            if (user != null && friend != null)
            {
                user.Friends.Add(friendId);
                friend.Friends.Add(userId);
            }
        }

        public static void RemoveFriend(int userId, int friendId)
        {
            var user = GetUserById(userId);
            var friend = GetUserById(friendId);
            if (user != null && friend != null)
            {
                user.Friends.Remove(friendId);
                friend.Friends.Remove(userId);
            }
        }

        public static void AddUserToChannel(int userId, int channelId)
        {
            var user = GetUserById(userId);
            var channel = channels.FirstOrDefault(c => c.Id == channelId);
            if (user != null && channel != null)
            {
                user.Channels.Add(channelId);
                channel.Users.Add(userId);
            }
        }

        public static void RemoveUserFromChannel(int userId, int channelId)
        {
            var user = GetUserById(userId);
            var channel = channels.FirstOrDefault(c => c.Id == channelId);
            if (user != null && channel != null)
            {
                user.Channels.Remove(channelId);
                channel.Users.Remove(userId);
            }
        }

        public static void AddChannel(Channel channel)
        {
            channel.Id = channels.Count + 1;
            channels.Add(channel);
        }

        public static Channel GetChannelById(int channelId)
        {
            return channels.FirstOrDefault(c => c.Id == channelId);
        }

        public static void RemoveChannel(int channelId)
        {
            var channel = channels.FirstOrDefault(c => c.Id == channelId);
            if (channel != null)
            {
                channels.Remove(channel);
            }
        }
    }
}