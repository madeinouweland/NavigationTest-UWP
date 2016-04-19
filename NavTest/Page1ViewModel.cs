namespace NavTest
{
    public interface IPage1ViewModel
    {
        string Name { get; }
        void NavigateToPage2();
        IMyUserControl1ViewModel MyUserControl1ViewModel { get; }
        IMyUserControl2ViewModel MyUserControl2ViewModel { get; }
    }

    public class Page1ViewModel : IPage1ViewModel
    {
        private INavigator _navigator;

        public IMyUserControl1ViewModel MyUserControl1ViewModel { get; }
        public IMyUserControl2ViewModel MyUserControl2ViewModel { get; }

        public string Name => "page1";

        public Page1ViewModel(INavigator navigator, INavigationPath navigationPath)
        {
            _navigator = navigator;

            MyUserControl1ViewModel = new MyUserControl1ViewModel(navigator);
            MyUserControl2ViewModel = new MyUserControl2ViewModel(navigationPath);
        }

        public void NavigateToPage2()
        {
            _navigator.NavigateToPage2();
        }
    }
}
