using System.Windows.Input;
using FriendsApp.Blueprint.ViewModels.Interfaces;
using Xamarin.Forms;

namespace FriendsApp.Blueprint.ViewModels
{
    public class FriendViewModel
    {
        public FriendViewModel(string name, IHandleFriends friendsHandler)
        {
            Name = name;
            RemoveFriendCommand = new Command(() => friendsHandler.RemoveFriend(this));
        }

        public string Name { get;}

        public ICommand RemoveFriendCommand { get; }
    }
}