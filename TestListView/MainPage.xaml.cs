using System.Collections.ObjectModel;
using Windows.UI.Xaml.Controls;

namespace TestListView
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Users = new ObservableCollection<User>
            {
                new User {Name = "Xavi"},
                new User {Name = "Noa"},
                new User {Name = "Jenny"}
            };

            foreach (User userSelected in Users)
            {
                UsersListView.SelectedItems.Add(userSelected);
            }
        }

        public ObservableCollection<User> Users { get; set; }
    }
}
