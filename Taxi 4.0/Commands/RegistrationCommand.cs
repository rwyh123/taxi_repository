using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Storage.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Taxi_4._0.ViewModel;
using Taxi4._0.Domain.Models;

namespace Taxi_4._0.Commands
{
    public class RegistrationCommand : ComandBase
    {
        private readonly RegistrationViewModel _regView;
        private readonly Taxi2 _taxiContext;

        public RegistrationCommand(RegistrationViewModel regView, Taxi2 taxiContext)
        {
            _regView = regView;
            _taxiContext = taxiContext;
        }

        public override bool CanExecute(object? parameter)
        {
            if ((_regView.REmail == string.Empty || _regView.RLogin == string.Empty || _regView.RPassword == null))
            {
                _regView.ErrorMessage = "All fields need to be, filled";
                return false;

            }
            else
            {
                _regView.ErrorMessage = "";
                return true;
            }
        }
        public override void Execute(object? parameter)
        {
            //var user = _taxiContext.Users.Where(i => i.Email == _regView.REmail && i.Login == _regView.RLogin && i.Password == _regView.RPassword).FirstOrDefault();
            //if (user != null || _regView.REmail == string.Empty || _regView.RLogin == string.Empty || _regView.RPassword == null)
            //{
            //    _regView.ErrorMessage = "Cannot register, check entered data";
            //    _regView.REmail = string.Empty;
            //    _regView.RLogin = string.Empty;
            //    _regView.RPassword = null;

            //}
            //else
            //{ 
                _regView.ErrorMessage = "Succussed registration";
                var tody = DateTime.Now;
                var usertoadd = new User(_regView.RLogin, _regView.REmail, (int)_regView.RPassword, new DateOnly(tody.Year, tody.Month, tody.Day));
                _taxiContext.Users.Add(usertoadd);
                var account = new Account(usertoadd);
                _taxiContext.Accounts.Add(account);
                _taxiContext.SaveChanges();
            //}
        }
    }
}
