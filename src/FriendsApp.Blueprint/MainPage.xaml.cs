using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FriendsApp.Blueprint
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> m_friendsNames;

        public MainPage()
        {   
            InitializeComponent();
            m_friendsNames = new ObservableCollection<string>();
            FriendsListView.ItemsSource = m_friendsNames;
        }

        private void AddButton_OnClicked(object sender, EventArgs e)
        {
            m_friendsNames.Add(FriendNameEntry.Text);
        }
    }
}
