using System.Collections.Generic;
using System.Threading.Tasks;

namespace FriendsApp.Blueprint.Services
{
    public interface IFriendsService
    {
        Task<IEnumerable<string>> GetFriends();
        Task AddFriend(string newFriendName);
        Task RemoveFriend(string newFriendName);
    }
}