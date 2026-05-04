using pr29_bartova.Classes;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using pr29_bartova.Classes;

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
