using System;
using System.ComponentModel;
using FriendsApp.Blueprint.ViewModels;
using Xamarin.Forms;

namespace FriendsApp.Blueprint.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BindingContext = new MainViewModel();
        }   

        private bool HasLightButtonStyle { get; set; } = true;

        private void ChangeButtonStyle(object sender, EventArgs e)
        {
            ((App)Application.Current).ChangeButtonStyle();
        }
    }
}