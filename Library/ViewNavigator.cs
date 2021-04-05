using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;

namespace Library
{
    public class ViewNavigator
    {
        private Action<Screen> _navigate;
        private Dictionary<Direction, Screen> _screens = new Dictionary<Direction, Screen>();

        public void SetNavigator(Action<Screen> navigate)
        {
            _navigate = navigate;
        }

        public void Navigate(Direction direction)
        {
            _navigate(_screens[direction]);
        }

        public void AddDirections(Direction direction, Screen action)
        {
            _screens.Add(direction, action);
        }
    }

    public enum Direction
    {
        LogIn,
        Menu,
    }
}
