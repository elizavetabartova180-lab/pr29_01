using pr29_bartova.Classes;
using System.Windows;
using System.Windows.Controls;

namespace pr29_bartova.Pages.Users
{
    public partial class Main : Page
    {
        public UserContext AllUsers = new UserContext();

        public Main()
        {
            InitializeComponent();
            foreach (Models.Users User in AllUsers.Users)
                Parent.Children.Add(new Elements.Item(User, this));
        }
        private void AddUser(object sender, RoutedEventArgs e) =>
            MainWindow.init.OpenPages(new Pages.Users.Add(this));
    }
}
