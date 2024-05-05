using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Taxi_4._0.Commands;
using Taxi_4._0.Stores;
using Taxi4._0.Domain.Models;

namespace Taxi_4._0.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
        private string lLogin;
        private Nullable<int> lPassword;

        public string LLogin
        { get => lLogin;
            set
            {
                lLogin = value;
                OnProperetyChanged(nameof(LLogin));
            }
        }
        public Nullable<int> LPassword
        { get => lPassword;
            set
            { 
                lPassword = value;
                OnProperetyChanged(nameof(LPassword));
            }
        }
        private string _errorMesage;

        public string ErrorMessage
        {
            get { return _errorMesage; }
            set
            {
                _errorMesage = value;
                OnProperetyChanged(nameof(ErrorMessage));
            }
        }

        public ICommand LHello { get; }
        public ICommand LLoginCommand { get; }
        public LoginViewModel(NavigationStore navigationStore, Func<HelloViewModel> HelloViewModel, Func<MainWindowViewModel> MainWindowModel)
        {
            LHello = new NavigateCommand(navigationStore, HelloViewModel);
            LLoginCommand = new LoginCommand(this, new Taxi2(), navigationStore,MainWindowModel);
        }

        
    }
}
