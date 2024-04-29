using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontDeskWinForm.Models;

namespace FrontDeskWinForm
{
    public partial class RoomEditWindow : Form
    {

        private Room selectedRoom;
        public RoomEditWindow()
        {
            InitializeComponent();
            
        }

        public RoomEditWindow(Room _selectedRoom)
        {
            selectedRoom = _selectedRoom;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow= new MainWindow();
            this.Hide();
            mainWindow.Show();
            mainWindow.FormClosed += (s, args) => this.Close();
        }

        private void RoomEditWindow_Load(object sender, EventArgs e)
        {
            roomNrLabel.Text = selectedRoom.RoomID.ToString();
            status.SelectedItem = selectedRoom.RoomStatus;
        }

        private void SaveChanges()
        {
            using (var context = new Context())
            {
                var room = context.Rooms.FirstOrDefault(r => r.RoomID == selectedRoom.RoomID);
                if (room != null)
                {
                    room.RoomStatus = status.SelectedItem.ToString();
                    context.SaveChanges();
                }
            }
        }

        private void UpdateNumBeds(int newNumBeds)
        {
            using (var context = new Context())
            {
                var room = context.Rooms.FirstOrDefault(r => r.RoomID == selectedRoom.RoomID);
                if (room != null)
                {
                    room.BedsNumber = newNumBeds;
                    context.SaveChanges();
                    MessageBox.Show("Number of beds has been updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void ChangeNumBedsButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numBedsComboBox.SelectedItem.ToString(), out int newNumBeds))
            {
                UpdateNumBeds(newNumBeds);
            }
            else
            {
                MessageBox.Show("Please select a valid number of beds from the ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
