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
    public partial class ReservationWindow : Form
    {
        public ReservationWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ReservationWindow_Load(object sender, EventArgs e)
        {

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
