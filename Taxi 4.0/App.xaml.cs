using System.Configuration;
using System.Data;
using System.Windows;
using Taxi_4._0.Stores;
using Taxi_4._0.ViewModel;
using Taxi4._0.Domain.Models;

namespace Taxi_4._0
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private readonly Taxi2 _taxiDbContext;

        public App()
        {
            _navigationStore = new NavigationStore();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new HelloViewModel(_navigationStore, loginViewModel,registrationViewModel);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        private MainWindowViewModel createMainWindowViewModel()
        {
            return new MainWindowViewModel(_navigationStore, createCreateOrderViewModel, orderListViewModel);
        }

        private CreateOrderViewModel createCreateOrderViewModel()
        {
            return new CreateOrderViewModel(_navigationStore, createMainWindowViewModel);
        }

        private OrderListViewModel orderListViewModel()
        {
            return new OrderListViewModel(_navigationStore, createMainWindowViewModel, createCreateOrderViewModel);
        }

        private HelloViewModel helloViewModel()
        {
            return new HelloViewModel(_navigationStore, loginViewModel, registrationViewModel);
        }

        private RegistrationViewModel registrationViewModel()
        {
            return new RegistrationViewModel(_navigationStore,helloViewModel);
        }

        private LoginViewModel loginViewModel()
        {
            return new LoginViewModel(_navigationStore,helloViewModel, createMainWindowViewModel);
        }
    }

}
