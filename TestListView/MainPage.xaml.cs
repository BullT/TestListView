﻿using System.Collections.ObjectModel;
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


        }

        public ObservableCollection<User> Users { get; set; }

        private void UsersListView_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            foreach (User userSelected in Users)
            {
                UsersListView.SelectedItems.Add(userSelected);
            }
        }
    }
}
