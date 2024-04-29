namespace FrontDeskWinForm
{
    partial class RoomManagementWindow
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
            this.bedNumSearchBtn = new System.Windows.Forms.Button();
            this.roomStatusSearchBtn = new System.Windows.Forms.Button();
            this.roomNumSearchBtn = new System.Windows.Forms.Button();
            this.roomSizeSearchBtn = new System.Windows.Forms.Button();
            this.searchRoomNumTextBox = new System.Windows.Forms.TextBox();
            this.searchRoomStatusTextBox = new System.Windows.Forms.TextBox();
            this.searchBedsNumberTextBox = new System.Windows.Forms.TextBox();
            this.searchRoomSizeTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.RoomNum = new System.Windows.Forms.ColumnHeader();
            this.RoomStat = new System.Windows.Forms.ColumnHeader();
            this.BedNum = new System.Windows.Forms.ColumnHeader();
            this.RoomSize = new System.Windows.Forms.ColumnHeader();
            this.editRoomBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bedNumSearchBtn
            // 
            this.bedNumSearchBtn.Location = new System.Drawing.Point(10, 169);
            this.bedNumSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bedNumSearchBtn.Name = "bedNumSearchBtn";
            this.bedNumSearchBtn.Size = new System.Drawing.Size(92, 28);
            this.bedNumSearchBtn.TabIndex = 3;
            this.bedNumSearchBtn.Text = "Search";
            this.bedNumSearchBtn.UseVisualStyleBackColor = true;
            this.bedNumSearchBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // roomStatusSearchBtn
            // 
            this.roomStatusSearchBtn.Location = new System.Drawing.Point(10, 113);
            this.roomStatusSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.roomStatusSearchBtn.Name = "roomStatusSearchBtn";
            this.roomStatusSearchBtn.Size = new System.Drawing.Size(92, 28);
            this.roomStatusSearchBtn.TabIndex = 4;
            this.roomStatusSearchBtn.Text = "Search";
            this.roomStatusSearchBtn.UseVisualStyleBackColor = true;
            this.roomStatusSearchBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // roomNumSearchBtn
            // 
            this.roomNumSearchBtn.Location = new System.Drawing.Point(10, 56);
            this.roomNumSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.roomNumSearchBtn.Name = "roomNumSearchBtn";
            this.roomNumSearchBtn.Size = new System.Drawing.Size(92, 28);
            this.roomNumSearchBtn.TabIndex = 5;
            this.roomNumSearchBtn.Text = "Search";
            this.roomNumSearchBtn.UseVisualStyleBackColor = true;
            this.roomNumSearchBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // roomSizeSearchBtn
            // 
            this.roomSizeSearchBtn.Location = new System.Drawing.Point(10, 229);
            this.roomSizeSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.roomSizeSearchBtn.Name = "roomSizeSearchBtn";
            this.roomSizeSearchBtn.Size = new System.Drawing.Size(92, 28);
            this.roomSizeSearchBtn.TabIndex = 6;
            this.roomSizeSearchBtn.Text = "Search";
            this.roomSizeSearchBtn.UseVisualStyleBackColor = true;
            this.roomSizeSearchBtn.Click += new System.EventHandler(this.button_Click);
            // 
            // searchRoomNumTextBox
            // 
            this.searchRoomNumTextBox.Location = new System.Drawing.Point(134, 59);
            this.searchRoomNumTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchRoomNumTextBox.Name = "searchRoomNumTextBox";
            this.searchRoomNumTextBox.PlaceholderText = "Room Nr";
            this.searchRoomNumTextBox.Size = new System.Drawing.Size(121, 27);
            this.searchRoomNumTextBox.TabIndex = 7;
            // 
            // searchRoomStatusTextBox
            // 
            this.searchRoomStatusTextBox.Location = new System.Drawing.Point(134, 116);
            this.searchRoomStatusTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchRoomStatusTextBox.Name = "searchRoomStatusTextBox";
            this.searchRoomStatusTextBox.PlaceholderText = "Room Status";
            this.searchRoomStatusTextBox.Size = new System.Drawing.Size(121, 27);
            this.searchRoomStatusTextBox.TabIndex = 8;
            // 
            // searchBedsNumberTextBox
            // 
            this.searchBedsNumberTextBox.Location = new System.Drawing.Point(134, 172);
            this.searchBedsNumberTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBedsNumberTextBox.Name = "searchBedsNumberTextBox";
            this.searchBedsNumberTextBox.PlaceholderText = "Bed Number";
            this.searchBedsNumberTextBox.Size = new System.Drawing.Size(121, 27);
            this.searchBedsNumberTextBox.TabIndex = 9;
            // 
            // searchRoomSizeTextBox
            // 
            this.searchRoomSizeTextBox.Location = new System.Drawing.Point(134, 232);
            this.searchRoomSizeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchRoomSizeTextBox.Name = "searchRoomSizeTextBox";
            this.searchRoomSizeTextBox.PlaceholderText = "Room Size";
            this.searchRoomSizeTextBox.Size = new System.Drawing.Size(121, 27);
            this.searchRoomSizeTextBox.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(707, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainWindowToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.roomEditToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mainWindowToolStripMenuItem
            // 
            this.mainWindowToolStripMenuItem.Name = "mainWindowToolStripMenuItem";
            this.mainWindowToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.mainWindowToolStripMenuItem.Text = "Main";
            this.mainWindowToolStripMenuItem.Click += new System.EventHandler(this.mainWindowToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // roomEditToolStripMenuItem
            // 
            this.roomEditToolStripMenuItem.Name = "roomEditToolStripMenuItem";
            this.roomEditToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.roomEditToolStripMenuItem.Text = "RoomEdit";
            this.roomEditToolStripMenuItem.Click += new System.EventHandler(this.roomEditToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RoomNum,
            this.RoomStat,
            this.BedNum,
            this.RoomSize});
            this.listView1.Location = new System.Drawing.Point(308, 56);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(374, 261);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // RoomNum
            // 
            this.RoomNum.Text = "RoomNum";
            this.RoomNum.Width = 100;
            // 
            // RoomStat
            // 
            this.RoomStat.Text = "RoomStat";
            this.RoomStat.Width = 100;
            // 
            // BedNum
            // 
            this.BedNum.Text = "BedNum";
            this.BedNum.Width = 80;
            // 
            // RoomSize
            // 
            this.RoomSize.Text = "RoomSize";
            this.RoomSize.Width = 80;
            // 
            // editRoomBtn
            // 
            this.editRoomBtn.Location = new System.Drawing.Point(332, 321);
            this.editRoomBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editRoomBtn.Name = "editRoomBtn";
            this.editRoomBtn.Size = new System.Drawing.Size(322, 27);
            this.editRoomBtn.TabIndex = 13;
            this.editRoomBtn.Text = "Edit Room";
            this.editRoomBtn.UseVisualStyleBackColor = true;
            this.editRoomBtn.Click += new System.EventHandler(this.editRoomBtn_Click);
            // 
            // RoomManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 415);
            this.Controls.Add(this.editRoomBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.searchRoomSizeTextBox);
            this.Controls.Add(this.searchBedsNumberTextBox);
            this.Controls.Add(this.searchRoomStatusTextBox);
            this.Controls.Add(this.searchRoomNumTextBox);
            this.Controls.Add(this.roomSizeSearchBtn);
            this.Controls.Add(this.roomNumSearchBtn);
            this.Controls.Add(this.roomStatusSearchBtn);
            this.Controls.Add(this.bedNumSearchBtn);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomManagementWindow";
            this.Text = "RoomManagementWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button bedNumSearchBtn;
        private Button roomStatusSearchBtn;
        private Button roomNumSearchBtn;
        private Button roomSizeSearchBtn;
        private TextBox searchRoomNumTextBox;
        private TextBox searchRoomStatusTextBox;
        private TextBox searchBedsNumberTextBox;
        private TextBox searchRoomSizeTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem mainWindowToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ListView listView1;
        private Button editRoomBtn;
        private ToolStripMenuItem roomEditToolStripMenuItem;
        private ColumnHeader RoomNum;
        private ColumnHeader RoomStat;
        private ColumnHeader BedNum;
        private ColumnHeader RoomSize;
    }
}