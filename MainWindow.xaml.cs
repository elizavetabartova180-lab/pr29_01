using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr29_bartova
{
    public partial class MainWindow : Window
    {
        public static MainWindow init;

        public MainWindow()
        {
            InitializeComponent();
            init = this;
            frame.Navigate(new Pages.Clubs.Main());
        }

        private void Clubs(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Clubs.Main());
        }

        private void Users(object sender, RoutedEventArgs e)
        {
            frame.Navigate(new Pages.Users.Main());
        }

        public void OpenPages(Page page)
        {
            frame.Navigate(page);
        }
    }
}
