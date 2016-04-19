using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace NavTest
{
    public interface INavigator
    {
        void NavigateToPage1();
        void NavigateToPage2();
        void ToList(int listId);
    }

    public class Navigator : INavigator
    {
        private INavigationPath _navigationPath;

        public Navigator(INavigationPath navigationPath)
        {
            _navigationPath = navigationPath;
        }

        public void NavigateToPage1()
        {
            var page = new Page1();
            page.ViewModel = new Page1ViewModel(this, _navigationPath);
            Window.Current.Content = page;
        }

        public void NavigateToPage2()
        {
            var page = new Page2();
            page.ViewModel = new Page2ViewModel(this);
            Window.Current.Content = page;
        }

        public void ToList(int id)
        {
            _navigationPath.ToList(id);
        }
    }
}
