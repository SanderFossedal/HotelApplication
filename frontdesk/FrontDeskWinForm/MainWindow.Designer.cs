namespace FrontDeskWinForm
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.RoomNum = new System.Windows.Forms.ColumnHeader();
            this.RoomSize = new System.Windows.Forms.ColumnHeader();
            this.RoomStatus = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1040, 44);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.roomManagementToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.taskManagementToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(97, 38);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // roomManagementToolStripMenuItem
            // 
            this.roomManagementToolStripMenuItem.Name = "roomManagementToolStripMenuItem";
            this.roomManagementToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.roomManagementToolStripMenuItem.Text = "Room Management";
            this.roomManagementToolStripMenuItem.Click += new System.EventHandler(this.roomManagementToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // taskManagementToolStripMenuItem
            // 
            this.taskManagementToolStripMenuItem.Name = "taskManagementToolStripMenuItem";
            this.taskManagementToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.taskManagementToolStripMenuItem.Text = "Task Management";
            this.taskManagementToolStripMenuItem.Click += new System.EventHandler(this.taskManagementToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RoomNum,
            this.RoomSize,
            this.RoomStatus});
            this.listView1.Location = new System.Drawing.Point(393, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(618, 506);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // RoomNum
            // 
            this.RoomNum.Text = "RoomNum";
            this.RoomNum.Width = 100;
            // 
            // RoomSize
            // 
            this.RoomSize.Text = "RoomSize";
            this.RoomSize.Width = 100;
            // 
            // RoomStatus
            // 
            this.RoomStatus.Text = "RoomStatus";
            this.RoomStatus.Width = 100;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 576);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem roomManagementToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ListView listView1;
        private ColumnHeader RoomNum;
        private ColumnHeader RoomSize;
        private ColumnHeader RoomStatus;
        private ToolStripMenuItem taskManagementToolStripMenuItem;
    }
}