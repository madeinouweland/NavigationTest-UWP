namespace NavTest
{
    public interface IPage2ViewModel
    {
        string Name { get; }
        void NavigateToPage1();
    }

    public class Page2ViewModel : IPage2ViewModel
    {
        private INavigator _navigator;

        public string Name => "page2";

        public Page2ViewModel(INavigator navigator)
        {
            _navigator = navigator;

        }

        public void NavigateToPage1()
        {
            _navigator.NavigateToPage1();
        }
    }
}
