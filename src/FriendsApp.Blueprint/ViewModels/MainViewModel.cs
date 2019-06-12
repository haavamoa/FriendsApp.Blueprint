using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using FriendsApp.Blueprint.Annotations;
using FriendsApp.Blueprint.Services;
using Xamarin.Forms;

namespace FriendsApp.Blueprint.ViewModels
{
    public class MainViewModel : IMainViewModel, INotifyPropertyChanged
    {
        private readonly IFriendsService m_friendsService;

        public MainViewModel(IFriendsService friendsService)
        {
            m_friendsService = friendsService;
            Friends = new ObservableCollection<string>();
            AddNewFriendCommand = new Command(AddNewFriend);
        }

        private void AddNewFriend()
        {
            Friends.Add(NewFriendName);
            NewFriendName = string.Empty;
            OnPropertyChanged(nameof(NewFriendName));
        }

        public string NewFriendName { get; set; }
        public async Task Initialize()
        {
            await m_friendsService.GetFriends();
        }

        public ObservableCollection<string> Friends { get; }

        public ICommand AddNewFriendCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}