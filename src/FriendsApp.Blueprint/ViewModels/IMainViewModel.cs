using System.Collections.ObjectModel;
using System.Windows.Input;

namespace FriendsApp.Blueprint.ViewModels
{
    public interface IMainViewModel
    {
        ICommand AddNewFriendCommand { get; }
        ObservableCollection<string> Friends { get; }
        string NewFriendName { get; set; }
    }
}