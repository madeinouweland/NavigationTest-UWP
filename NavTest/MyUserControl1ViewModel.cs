using System.Collections.Generic;

namespace NavTest
{
    public interface IMyUserControl1ViewModel
    {
        string Title { get; }
        List<int> Lists { get; }
        void SelectList(int id);
    }

    public class MyUserControl1ViewModel : IMyUserControl1ViewModel
    {
        private INavigator _navigator;

        public string Title => "lists";
        public List<int> Lists => new List<int> { 1, 2, 3, 4, 5 };

        public MyUserControl1ViewModel(INavigator navigator)
        {
            _navigator = navigator;
        }

        public void SelectList(int id)
        {
            _navigator.ToList(id);
        }
    }
}
