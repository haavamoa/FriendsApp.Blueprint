using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using FriendsApp.Blueprint.ViewModels.Interfaces;
using Xamarin.Forms;

namespace FriendsApp.Blueprint.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged, IHandleFriends
    {
        private string m_newFriendName;

        public MainViewModel()
        {
            AddNewFriendCommand = new Command(AddNewFriend, () => !string.IsNullOrEmpty(NewFriendName));
            Friends = new ObservableCollection<FriendViewModel>();
        }

        public ObservableCollection<FriendViewModel> Friends { get; set; }

        public string NewFriendName
        {
            get => m_newFriendName;
            set
            {
                m_newFriendName = value;
                OnPropertyChanged();
                ((Command)AddNewFriendCommand).ChangeCanExecute();
            }
        }

        public ICommand AddNewFriendCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void AddNewFriend()
        {
            var newFriend = new FriendViewModel(NewFriendName, this);
            Friends.Add(newFriend);
            NewFriendName = string.Empty;
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RemoveFriend(FriendViewModel friend)
        {
            Friends.Remove(friend);
        }
    }
}