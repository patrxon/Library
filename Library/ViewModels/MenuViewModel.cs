using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;

namespace Library.ViewModels
{
    public class MenuViewModel : Screen
    {
        private ViewNavigator _viewNavigator;

        public MenuViewModel(ViewNavigator viewNavigator)
        {
            _viewNavigator = viewNavigator;
        }

        public void Menu()
        {
            _viewNavigator.Navigate(Direction.LogIn);
        }

    }
}
