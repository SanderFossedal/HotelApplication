using FrontDeskWinForm.Models;
using Microsoft.Data.SqlClient;
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

namespace FrontDeskWinForm
{
    public partial class BookingWindow : Form
    {

        public BookingWindow()
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
                var rooms = context.Rooms.ToList();
                var reservations = context.Reservations.ToList();

                // Filtrer basert på RoomID
                if (int.TryParse(searchCustomerIdTextBox.Text, out int roomId))
                {
                    rooms = rooms.Where(r => r.RoomID == roomId).ToList();
                }

                DateTime checkInDate = dateTimePicker1.Value.Date;
                DateTime checkOutDate = dateTimePicker2.Value.Date;

                rooms = rooms.Where(room => !reservations.Any(reservation =>
                    room.RoomID == reservation.RoomId.RoomID &&
                    (checkInDate < reservation.CheckOut && checkOutDate > reservation.CheckIn))).ToList();

                // Hent filtrerte rom og legg dem til i ListView
                foreach (var room in rooms)
                {
                    var reservation = reservations.FirstOrDefault(r => r.RoomId.RoomID == room.RoomID);
                    if (reservation != null)
                    {
                        ListViewItem item = new ListViewItem(room.RoomID.ToString());
                        item.SubItems.Add(room.RoomStatus);
                        item.SubItems.Add(reservation.CheckIn.ToString("yyyy-MM-dd")); // Format date as desired
                        item.SubItems.Add(reservation.CheckOut.ToString("yyyy-MM-dd")); // Format date as desired

                        listView1.Items.Add(item);
                    }
                }
            }
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


        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainWindow mainWindow= new MainWindow();
            this.Hide();
            mainWindow.Show();
            mainWindow.FormClosed += (s, args) => this.Close();
        }

        private void reservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationWindow reservationWindow= new ReservationWindow();
            this.Hide();
            reservationWindow.Show();
            reservationWindow.FormClosed += (s, args) => this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            LoadFilteredRoomData();
        }

        private void searchRoomNumBtn_Click(object sender, EventArgs e)
        {
            LoadFilteredRoomData();
        }

        private void makeReservationsBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a room from the list.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(searchCustomerIdTextBox.Text, out int mobileNumber))
            {
                MessageBox.Show("Please enter a valid mobile number.", "Invalid Mobile Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRoomId = int.Parse(listView1.SelectedItems[0].Text);
            DateTime checkInDate = dateTimePicker1.Value.Date;
            DateTime checkOutDate = dateTimePicker2.Value.Date;

            using (var context = new Context())
            {
                Customer customer = context.Customers.FirstOrDefault(c => c.Mobile == mobileNumber);

                // If the customer doesn't exist, create a new customer.
                if (customer == null)
                {
                    customer = new Customer
                    {
                        Mobile = mobileNumber,
                        // Add other customer properties if necessary.
                    };

                    context.Customers.Add(customer);
                    context.SaveChanges();

                    MessageBox.Show($"Customer with mobile number {mobileNumber} has been created.", "New Customer Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Room room = context.Rooms.FirstOrDefault(r => r.RoomID == selectedRoomId);
                if (room == null)
                {
                    MessageBox.Show("Room not found. Please select a valid room.", "Room Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Reservation newReservation = new Reservation
                {
                    CustomerId = customer,
                    RoomId = room,
                    CheckIn = checkInDate,
                    CheckOut = checkOutDate
                };

                context.Reservations.Add(newReservation);
                context.SaveChanges();

                MessageBox.Show($"Room {selectedRoomId} has been reserved for mobile number {mobileNumber} from {checkInDate.ToShortDateString()} to {checkOutDate.ToShortDateString()}.", "Reservation Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Søk etter bestillinger basert på telefonnummer
            string mobile = textBox1.Text;
            using (var context = new Context())
            {
                var reservations = context.Reservations
                    .Where(r => r.CustomerId.Mobile.ToString() == mobile)
                    .Include(r => r.CustomerId)
                    .Include(r => r.RoomId)
                    .ToList();
                // Vis resultatet i listView1
                listView1.Items.Clear();
                foreach (var reservation in reservations)
                {
                    var item = new ListViewItem(reservation.RoomId.RoomID.ToString());
                    item.SubItems.Add(reservation.RoomId.RoomStatus);
                    item.SubItems.Add(reservation.CheckIn.ToString());
                    item.SubItems.Add(reservation.CheckOut.ToString());
                    item.SubItems.Add(reservation.CustomerId.Mobile.ToString());
                    listView1.Items.Add(item);
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a reservation to delete.");
                return;
            }

            int RoomNum = int.Parse(listView1.SelectedItems[0].Text);

            using (var context = new Context())
            {
                var reservation = context.Reservations.FirstOrDefault(r => r.RoomId.RoomID == RoomNum);
                if (reservation == null)
                {
                    MessageBox.Show("The selected reservation does not exist.");
                    return;
                }

                context.Reservations.Remove(reservation);
                context.SaveChanges();
            }

            MessageBox.Show("Reservation successfully deleted.");
        }
    }
}
