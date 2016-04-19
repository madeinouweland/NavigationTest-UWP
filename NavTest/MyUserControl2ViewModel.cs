using System.ComponentModel;

namespace NavTest
{
    public interface IMyUserControl2ViewModel : INotifyPropertyChanged
    {
        string Title { get; }
        string TaskInfo { get; }
    }

    public class MyUserControl2ViewModel : ObservableObject, IMyUserControl2ViewModel
    {
        public string Title => "tasks";

        private string _taskInfo = "click a list...";
        public string TaskInfo
        {
            get { return _taskInfo; }
            set
            {
                if (_taskInfo != value)
                {
                    _taskInfo = value;
                    NotifyOfPropertyChange(nameof(TaskInfo));
                }
            }
        }

        public MyUserControl2ViewModel(INavigationPath navigationPath)
        {
            navigationPath.ListChanged += (s, a) =>
            {
                TaskInfo = "Taskinfo for list " + a;
            };
        }
    }
}
