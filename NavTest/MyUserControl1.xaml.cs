namespace NavTest
{
    public sealed partial class MyUserControl1
    {
        public IMyUserControl1ViewModel ViewModel { get; set; }

        public MyUserControl1()
        {
            this.InitializeComponent();
        }

        private void ListView_ItemClick(object sender, Windows.UI.Xaml.Controls.ItemClickEventArgs e)
        {
            var id = (int)e.ClickedItem;
            ViewModel.SelectList(id);
        }
    }
}
