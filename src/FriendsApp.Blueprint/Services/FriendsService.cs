using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FriendsApp.Blueprint.Services
{
    public class FriendsService : IFriendsService
    {
        private readonly HttpClient m_httpClient;
        private const string GetAddress = "https://raw.githubusercontent.com/haavamoa/FriendsApp.Blueprint/dependency-injection/src/FriendsApp.Blueprint/Services/friends.json";

        public FriendsService(HttpClient httpClient)
        {
            m_httpClient = httpClient;
        }

        public async Task<IEnumerable<string>> GetFriends()
        {
            var friends = new List<string>();
            try
            {
                var response = await m_httpClient.GetAsync(new Uri(GetAddress));
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var friendsModels = JsonConvert.DeserializeObject<List<Friend>>(content);
                }
                return new List<string>();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
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

    public class Friend
    {
        public string Name { get; set; }
    }
}