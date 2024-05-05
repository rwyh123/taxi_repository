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
    public class MainWindowViewModel : ViewModelBase
    {
        public ICommand CreateOrder {get;}
        public ICommand OrderList { get;}

        public MainWindowViewModel(NavigationStore navigationStore, Func<CreateOrderViewModel> createCreateOrderViewModel, Func<OrderListViewModel> createOrderListViewModel)
        {
            CreateOrder = new NavigateCommand(navigationStore, createCreateOrderViewModel);
            OrderList = new NavigateCommand(navigationStore, createOrderListViewModel);
        }
    }
}
