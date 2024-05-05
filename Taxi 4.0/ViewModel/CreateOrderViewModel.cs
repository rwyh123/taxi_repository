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
    public class CreateOrderViewModel : ViewModelBase
    {
        public ICommand BackToMainMenu { get; }

        public CreateOrderViewModel(NavigationStore _navigationStore, Func<MainWindowViewModel> createMainWindowViewModel)
        {
            BackToMainMenu = new NavigateCommand(_navigationStore, createMainWindowViewModel);
        }

    }
}
