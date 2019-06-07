using System;
using System.Linq;
using FriendsApp.Blueprint.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FriendsApp.Blueprint
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            ChangeButtonStyle();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public void ChangeButtonStyle()
        {
            Resources["ButtonStyle"] =
                HasLightButtonStyle ? Resources["LightButtonStyle"] : Resources["DarkButtonStyle"];

            HasLightButtonStyle = !HasLightButtonStyle;
        }

        private bool HasLightButtonStyle { get; set; } = true;
    }
}
