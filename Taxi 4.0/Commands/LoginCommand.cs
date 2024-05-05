using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Taxi_4._0.Stores;
using Taxi_4._0.ViewModel;
using Taxi4._0.Domain.Models;

namespace Taxi_4._0.Commands
{
    internal class LoginCommand : ComandBase
    {
        private readonly LoginViewModel _logView;
        private readonly Taxi2 _taxiContext;
        private NavigationStore _navStore;
        private Func<MainWindowViewModel> _mvVM;

        public LoginCommand(LoginViewModel logView, Taxi2 taxiContext, NavigationStore navStore, Func<MainWindowViewModel> mvVM)
        {
            _logView = logView;
            _taxiContext = taxiContext;
            _navStore = navStore;
            _mvVM = mvVM;
        }

        public override void Execute(object? parameter)
        {
            var user = _taxiContext.Users.Where(i =>  i.Login == _logView.LLogin && i.Password == _logView.LPassword).FirstOrDefault();
            if (user == null)
            {
                _logView.ErrorMessage = "Cannot login, check entered data";
                _logView.LLogin = string.Empty;
                _logView.LPassword = null;

            }
            else
            {
                _logView.ErrorMessage = "Succussed login";
                var nav = new NavigateCommand(_navStore,_mvVM);
                nav.Execute(parameter);
            }
        }
    }
}
