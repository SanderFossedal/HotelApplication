using FrontDeskWinForm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task = FrontDeskWinForm.Models.Task;

namespace FrontDeskWinForm
{
    public partial class TaskManagmentWindow : Form
    {

        private int selectedRoomNumber;
        public TaskManagmentWindow()
        {
            InitializeComponent();
            LoadTaskData();
        }

        private void roomManagmentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void mainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Hide();
            mainWindow.Show();
            mainWindow.FormClosed += (s, args) => this.Close();
        }

        private void selectRoomBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(roomNumTextBox.Text, out int roomNumber))
            {
                selectedRoomNumber = roomNumber;
                selectedRoomLabel.Text = $"Selected Room: {selectedRoomNumber}";
            }
            else
            {
                MessageBox.Show("Please enter a valid room number.");
            }
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            if (selectedRoomNumber == 0)
            {
                MessageBox.Show("Please select a room before adding a task.");
                return;
            }

            if (taskTypeComboBox.SelectedItem == null || taskStatusComboBox.SelectedItem == null || string.IsNullOrEmpty(taskNoteTextBox.Text) || string.IsNullOrEmpty(taskDescTextBox.Text))
            {
                MessageBox.Show("Please fill in all task fields.");
                return;
            }

            using (var context = new Context())
            {
                var room = context.Rooms.FirstOrDefault(r => r.RoomID == selectedRoomNumber);
                if (room == null)
                {
                    MessageBox.Show("The selected room does not exist.");
                    return;
                }

                var newTask = new Task
                {
                    TaskType = taskTypeComboBox.SelectedItem.ToString(),
                    TaskStatus = taskStatusComboBox.SelectedItem.ToString(),
                    TaskDescription = taskDescTextBox.Text,
                    TaskNote = taskNoteTextBox.Text,
                    RoomId = room
                };

                context.Tasks.Add(newTask);
                context.SaveChanges();
            }

            MessageBox.Show("Task successfully added.");
        }

        private void LoadTaskData()
        {
            listView1.Items.Clear();

            using (var context = new Context())
            {
                var tasks = context.Tasks.Include(t => t.RoomId).ToList();

                foreach (var task in tasks)
                {
                    ListViewItem item = new ListViewItem(task.RoomId == null ? "null" : task.RoomId.RoomID.ToString());
                    item.SubItems.Add(task.TaskType);
                    item.SubItems.Add(task.TaskDescription);
                    item.SubItems.Add(task.TaskStatus);
                    item.SubItems.Add(task.Id.ToString());
                    item.SubItems.Add(task.TaskNote ?? "null");

                    listView1.Items.Add(item);
                }
            }
        }
    }
}