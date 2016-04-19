using System;

namespace NavTest
{
    public interface INavigationPath
    {
        event EventHandler<int> ListChanged;
        void ToList(int id);
    }

    public class NavigationPath : INavigationPath
    {
        public event EventHandler<int> ListChanged;

        protected virtual void OnListChanged(int id)
        {
            ListChanged?.Invoke(this, id);
        }

        public void ToList(int id)
        {
            OnListChanged(id);
        }
    }
}
