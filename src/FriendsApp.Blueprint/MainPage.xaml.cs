using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendsApp.Blueprint.ViewModels;
using Xamarin.Forms;

namespace FriendsApp.Blueprint
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

        private void ChangeStyle(object sender, EventArgs e)
        {
            if (!IsUsingNormalStyle)
            {
                ((App)Application.Current).Resources["ButtonStyle"] = ((App)Application.Current).Resources["NormalButtonStyle"];
            }
            else
            {
                ((App)Application.Current).Resources["ButtonStyle"] = ((App)Application.Current).Resources["LightButtonStyle"];
            }
            IsUsingNormalStyle = !IsUsingNormalStyle;
        }

        private bool IsUsingNormalStyle { get; set; } = true;
    }
}
