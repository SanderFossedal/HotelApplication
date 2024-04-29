using FrontDeskWinForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontDeskWinForm
{
    public partial class RoomManagementWindow : Form
    {
        public RoomManagementWindow()
        {
            InitializeComponent();
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

        private void LoadFilteredRoomData()
        {
            listView1.Items.Clear();

            using (var context = new Context())
            {
                var rooms = context.Rooms.AsQueryable();

                // Filtrer basert på RoomID
                if (int.TryParse(searchRoomNumTextBox.Text, out int roomId))
                {
                    rooms = rooms.Where(r => r.RoomID == roomId);
                }

                // Filtrer basert på RoomStatus
                if (!string.IsNullOrWhiteSpace(searchRoomStatusTextBox.Text))
                {
                    rooms = rooms.Where(r => r.RoomStatus.Contains(searchRoomStatusTextBox.Text));
                }

                // Filtrer basert på BedsNumber
                if (int.TryParse(searchBedsNumberTextBox.Text, out int bedsNumber))
                {
                    rooms = rooms.Where(r => r.BedsNumber == bedsNumber);
                }

                // Filtrer basert på RoomSize
                if (!string.IsNullOrWhiteSpace(searchRoomSizeTextBox.Text))
                {
                    rooms = rooms.Where(r => r.RoomSize.Contains(searchRoomSizeTextBox.Text));
                }

                // Hent filtrerte rom og legg dem til i ListView
                var filteredRooms = rooms.ToList();
                foreach (var room in filteredRooms)
                {
                    ListViewItem item = new ListViewItem(room.RoomID.ToString());
                    item.SubItems.Add(room.RoomStatus);
                    item.SubItems.Add(room.BedsNumber.ToString());
                    item.SubItems.Add(room.RoomSize);

                    listView1.Items.Add(item);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        //Edit button, passes selected room to EditRoom window
        private void editRoomBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int selectedRoomId = int.Parse(listView1.SelectedItems[0].Text);

                using (var context = new Context())
                {
                    Room selectedRoom = context.Rooms.FirstOrDefault(r => r.RoomID == selectedRoomId);
                    RoomEditWindow roomEditWindow = new RoomEditWindow(selectedRoom);
                    roomEditWindow.Show();
                }

            }
            else
            {
                MessageBox.Show("Please select a room from the list before editing.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Hide();
            mainWindow.Show();
            mainWindow.FormClosed += (s, args) => this.Close();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingWindow bookingWindow = new BookingWindow();
            this.Hide();
            bookingWindow.Show();
            bookingWindow.FormClosed += (s, args) => this.Close();
        }

        private void roomEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomEditWindow roomEditWindow = new RoomEditWindow();
            this.Hide();
            roomEditWindow.Show();
            roomEditWindow.FormClosed += (s, args) => this.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            LoadFilteredRoomData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFilteredRoomData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadFilteredRoomData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadFilteredRoomData();
        }
    }
}
