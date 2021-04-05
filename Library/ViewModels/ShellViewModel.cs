using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private MenuViewModel _menuVM;
        private LoginViewModel _loginVM;
        private ViewNavigator _viewNavigator;


        public ShellViewModel(LoginViewModel loginVM, MenuViewModel menuVM, ViewNavigator viewNawigator)
        {
            _loginVM = loginVM;
            _menuVM = menuVM;

            _viewNavigator = viewNawigator;
            _viewNavigator.SetNavigator(Navigate);
            _viewNavigator.AddDirections(Direction.LogIn, _loginVM);
            _viewNavigator.AddDirections(Direction.Menu, _menuVM);

            Navigate(_loginVM);
        }

        public void Navigate(Screen screen)
        {
            ActivateItem(screen);
        }


      
    }
}
