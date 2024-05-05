using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Taxi_4._0.Commands;
using Taxi_4._0.Stores;

namespace Taxi_4._0.ViewModel
{
    public class RegistrationViewModel : ViewModelBase
    {
        private string rLogin;
        public string RLogin
        {   get => rLogin;
            set
            {
                rLogin = value;
                OnProperetyChanged(nameof(RLogin));
                RRegistrationCommand.CanExecute(null);
            }
        }
        private Nullable<int> rPassword { get; set; }

        public Nullable<int> RPassword
        {
            get => rPassword;
            set
            {
                rPassword = value;
                OnProperetyChanged(nameof(RPassword));
                RRegistrationCommand.CanExecute(null);
            }
        }

        public string rEmail { get; set; }

        public string REmail
        {
            get => rEmail;
            set
            {
                rEmail = value;
                OnProperetyChanged(nameof(REmail));
                RRegistrationCommand.CanExecute(null);
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


        public ICommand RHello { get; }
        public ICommand RRegistrationCommand { get; }
        public RegistrationViewModel(NavigationStore navigationStore, Func<HelloViewModel> HelloViewModel)
        {
            RHello = new NavigateCommand(navigationStore, HelloViewModel);
            RRegistrationCommand = new RegistrationCommand(this, new Taxi4._0.Domain.Models.Taxi2());
        }
    }
}
