using System;
using FriendsApp.Blueprint.ViewModels;
using LightInject;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FriendsApp.Blueprint
{
    public partial class App : Application
    {
        private readonly ServiceContainer m_container;

        public App()
        {
            InitializeComponent();
            m_container = new ServiceContainer(new ContainerOptions(){EnablePropertyInjection = false});
            m_container.RegisterFrom<CompositionRoot>();
            MainPage = m_container.GetInstance<MainPage>();
        }

        protected override async void OnStart()
        {
            // Handle when your app starts
            await m_container.GetInstance<IMainViewModel>().Initialize();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
