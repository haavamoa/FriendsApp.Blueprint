using FriendsApp.Blueprint.ViewModels;
using LightInject;

namespace FriendsApp.Blueprint
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IMainViewModel, MainViewModel>();
            serviceRegistry.Register<MainPage>();
        }
    }
}