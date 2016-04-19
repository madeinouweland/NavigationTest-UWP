namespace NavTest
{
    public class Bootstrapper
    {
        private INavigator _navigator;
        private INavigationPath _navigationPath;

        public INavigator Navigator => _navigator;

        public Bootstrapper()
        {
            _navigationPath = new NavigationPath();
            _navigator = new Navigator(_navigationPath);
        }
    }
}
