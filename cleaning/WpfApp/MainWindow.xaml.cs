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
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Method for shutting down application on close
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        // Method for opening CleanerWindow in application
        private void OpenCleanerWindow(object sender, RoutedEventArgs e)
        {
            CleanerWindow objCleanerWindow = new CleanerWindow();
            this.Visibility = Visibility.Hidden; // Hiding current window
            objCleanerWindow.Show();
        }

        // Method for opening ServiceWindow in application
        private void OpenServiceWindow(object sender, RoutedEventArgs e)
        {
            ServiceWindow objServiceWindow = new ServiceWindow();
            this.Visibility = Visibility.Hidden; // Hiding current window
            objServiceWindow.Show();
        }

        // Method for opening MaintenanceWindow in application
        private void OpenMaintenanceWindow(object sender, RoutedEventArgs e)
        {
            MaintenanceWindow objMaintenanceWindow = new MaintenanceWindow();
            this.Visibility = Visibility.Hidden; // Hiding current window
            objMaintenanceWindow.Show();
        }
    }
}
