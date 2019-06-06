using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FriendsApp.Blueprint.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendsList : ContentView
    {
        public FriendsList()
        {
            InitializeComponent();
        }
    }
}