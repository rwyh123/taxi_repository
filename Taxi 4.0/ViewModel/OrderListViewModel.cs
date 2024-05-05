using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Taxi_4._0.Commands;
using Taxi_4._0.Stores;

namespace Taxi_4._0.ViewModel
{
    public class OrderListViewModel : ViewModelBase
    {
        public ICommand BackToMainMenu { get; }

        public ICommand CreateOrder { get; }

        public OrderListViewModel(NavigationStore _navigationStore, Func<MainWindowViewModel> createMainWindowViewModel, Func<CreateOrderViewModel> createCreateOrderViewModel)
        {
            BackToMainMenu = new NavigateCommand(_navigationStore, createMainWindowViewModel);
            CreateOrder = new NavigateCommand(_navigationStore, createCreateOrderViewModel);
        }

    }
}
