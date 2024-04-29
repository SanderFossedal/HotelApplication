using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
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
using WpfApp.Models;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MaintenanceWindow.xaml
    /// </summary>
    public partial class MaintenanceWindow : Window
    {
        // Reference to datacontext -> readonly flag because the variable is only set one time in the constructor (it won't be point to another object)
        private readonly Dat154Assignment4Context dx = new();

        private readonly LocalView<Models.Task> Tasks;

        public MaintenanceWindow()
        {
            InitializeComponent();

            Tasks = dx.Tasks.Local;
            dx.Tasks.Load();

            taskList.DataContext = Tasks.Where(e => e.Tasktype == "MAINTENANCE");
        }

        // Method for shutting down application on close
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }

        // Method for "Back"-button in application to return to MainWindow
        private void GoBackButton(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden; // Hiding current window
            objMainWindow.Show();
        }

        // Method for "Change status"-button in application to change tasks status
        private void ChangeStatusButton(object sender, RoutedEventArgs e)
        {
            int taskid = int.Parse(tid.Text);
            Models.Task t = Tasks.Where(e => e.Id == taskid).First();
            t.Taskstatus = tstatus.Text;

            dx.SaveChanges();

            // Refresh
            MaintenanceWindow objMaintenanceWindow = new MaintenanceWindow();
            this.Visibility = Visibility.Hidden; // Hiding current window
            objMaintenanceWindow.Show();
        }

        // Method for "Add Note"-button in application to add note to task
        private void AddNoteButton(object sender, RoutedEventArgs e)
        {
            int taskid = int.Parse(tid2.Text);
            Models.Task t = Tasks.Where(t => t.Id == taskid).First();
            t.Note = tnote.Text;

            dx.SaveChanges();
        }
    }
}
