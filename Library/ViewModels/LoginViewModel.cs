using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Caliburn.Micro;

namespace Library.ViewModels
{
    public class LoginViewModel : Screen
    {

        private ViewNavigator _viewNavigator;

        public LoginViewModel(ViewNavigator viewNavigator)
        {
            _viewNavigator = viewNavigator;
        }

        public void LogIn()
        {
            _viewNavigator.Navigate(Direction.Menu);
        }

        public void SingIn()
        {

        }

    }
}
