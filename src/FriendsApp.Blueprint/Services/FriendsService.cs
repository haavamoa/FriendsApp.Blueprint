using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendsApp.Blueprint.Services
{
    public class FriendsService : IFriendsService
    {
        public Task<IEnumerable<string>> GetFriends()
        {
            throw new System.NotImplementedException();
        }

        public Task AddFriend(string newFriendName)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveFriend(string newFriendName)
        {
            throw new System.NotImplementedException();
        }
    }
}