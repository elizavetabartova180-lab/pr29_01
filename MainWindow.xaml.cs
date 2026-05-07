using System.Windows;
using System.Windows.Controls;

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
