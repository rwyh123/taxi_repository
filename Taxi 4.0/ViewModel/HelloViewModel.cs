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
    public class HelloViewModel : ViewModelBase
    {
        public ICommand HLogin { get; }
        public ICommand HRegistration { get; }

        public HelloViewModel(NavigationStore navigationStore, Func<LoginViewModel> LoginViewModel, Func<RegistrationViewModel> RegistrationViewModel)
        {
            HLogin = new NavigateCommand(navigationStore, LoginViewModel);
            HRegistration = new NavigateCommand(navigationStore, RegistrationViewModel);
        }
    }
}
