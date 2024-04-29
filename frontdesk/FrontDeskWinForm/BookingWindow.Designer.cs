namespace FrontDeskWinForm
{
    partial class BookingWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchRoomNumBtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.RoomNum = new System.Windows.Forms.ColumnHeader();
            this.RoomStatus = new System.Windows.Forms.ColumnHeader();
            this.CheckInDate = new System.Windows.Forms.ColumnHeader();
            this.CheckOutDate = new System.Windows.Forms.ColumnHeader();
            this.Phone = new System.Windows.Forms.ColumnHeader();
            this.button4 = new System.Windows.Forms.Button();
            this.makeReservationBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchCustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchRoomNumBtn
            // 
            this.searchRoomNumBtn.Location = new System.Drawing.Point(12, 209);
            this.searchRoomNumBtn.Name = "searchRoomNumBtn";
            this.searchRoomNumBtn.Size = new System.Drawing.Size(260, 38);
            this.searchRoomNumBtn.TabIndex = 0;
            this.searchRoomNumBtn.Text = "Search available rooms";
            this.searchRoomNumBtn.UseVisualStyleBackColor = true;
            this.searchRoomNumBtn.Click += new System.EventHandler(this.searchRoomNumBtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RoomNum,
            this.RoomStatus,
            this.CheckInDate,
            this.CheckOutDate,
            this.Phone});
            this.listView1.Location = new System.Drawing.Point(278, 59);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(633, 450);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // RoomNum
            // 
            this.RoomNum.Text = "RoomNum";
            this.RoomNum.Width = 100;
            // 
            // RoomStatus
            // 
            this.RoomStatus.Text = "RoomStatus";
            this.RoomStatus.Width = 110;
            // 
            // CheckInDate
            // 
            this.CheckInDate.Text = "CheckInDate";
            this.CheckInDate.Width = 120;
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.Text = "CheckOutDate";
            this.CheckOutDate.Width = 130;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 100;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(631, 515);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(280, 30);
            this.button4.TabIndex = 4;
            this.button4.Text = "Delete reservation";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // makeReservationBtn
            // 
            this.makeReservationBtn.Location = new System.Drawing.Point(278, 515);
            this.makeReservationBtn.Name = "makeReservationBtn";
            this.makeReservationBtn.Size = new System.Drawing.Size(281, 30);
            this.makeReservationBtn.TabIndex = 5;
            this.makeReservationBtn.Text = "Make reservation";
            this.makeReservationBtn.UseVisualStyleBackColor = true;
            this.makeReservationBtn.Click += new System.EventHandler(this.makeReservationsBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.reservationToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(205, 34);
            this.reservationToolStripMenuItem.Text = "Reservation";
            this.reservationToolStripMenuItem.Click += new System.EventHandler(this.reservationToolStripMenuItem_Click);
            // 
            // searchCustomerIdTextBox
            // 
            this.searchCustomerIdTextBox.Location = new System.Drawing.Point(12, 291);
            this.searchCustomerIdTextBox.Name = "searchCustomerIdTextBox";
            this.searchCustomerIdTextBox.Size = new System.Drawing.Size(260, 31);
            this.searchCustomerIdTextBox.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(260, 31);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 147);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(260, 31);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Check in date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Check out date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Customer ID/Phone:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Search customer ID/Phone:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 438);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(260, 31);
            this.textBox1.TabIndex = 17;
            // 
            // BookingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 557);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.searchCustomerIdTextBox);
            this.Controls.Add(this.makeReservationBtn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchRoomNumBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookingWindow";
            this.Text = "BookingWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button searchRoomNumBtn;
        private ListView listView1;
        private Button button4;
        private Button makeReservationBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem mainToolStripMenuItem;
        private ToolStripMenuItem reservationToolStripMenuItem;
        private ColumnHeader RoomNum;
        private ColumnHeader RoomStatus;
        private TextBox searchCustomerIdTextBox;
        private ColumnHeader CheckInDate;
        private ColumnHeader CheckOutDate;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ColumnHeader Phone;
        private Label label4;
        private TextBox textBox1;
    }
}