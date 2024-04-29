using System.Data;
using FrontDeskWinForm.Models;
using System.Windows;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace FrontDeskWinForm
{
    public partial class MainWindow : Form
    {

        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingWindow bookingWindow = new BookingWindow();
            this.Hide();
            bookingWindow.Show();
            bookingWindow.FormClosed += (s, args) => this.Close();
        }

        private void roomManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomManagementWindow roomManagementWindow = new RoomManagementWindow();
            this.Hide();
            roomManagementWindow.Show();
            roomManagementWindow.FormClosed += (s, args) => this.Close();
        }

        private void taskManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManagmentWindow taskmanagementWindow = new TaskManagmentWindow();
            this.Hide();
            taskmanagementWindow.Show();
            taskmanagementWindow.FormClosed += (s, args) => this.Close();
        }

        private void LoadRoomData()
        {
            listView1.Items.Clear();

            using (var context = new Context())
            {
                var rooms = context.Rooms.ToList();

                foreach (var room in rooms)
                {
                    ListViewItem item = new ListViewItem(room.RoomID.ToString());
                    item.SubItems.Add(room.RoomSize);
                    item.SubItems.Add(room.RoomStatus);
                    //item.SubItems.Add(room.RoomSize);

                    listView1.Items.Add(item);
                }
            }
        }

        private void LoadCustomerData()
        {
            listView1.Items.Clear();

            using (var context = new Context())
            {
                var customers = context.Customers.ToList();

                foreach (var customer in customers)
                {
                    ListViewItem item = new ListViewItem(customer.Mobile.ToString());
                    item.SubItems.Add(customer.FirstName);
                    item.SubItems.Add(customer.LastName);
                    item.SubItems.Add(customer.Password.ToString());

                    listView1.Items.Add(item);
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadRoomData();
            //LoadCustomerData();
        }
    }
}