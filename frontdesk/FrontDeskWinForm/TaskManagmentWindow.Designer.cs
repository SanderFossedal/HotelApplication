namespace FrontDeskWinForm
{
    partial class TaskManagmentWindow
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomManagmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.taskId = new System.Windows.Forms.ColumnHeader();
            this.taskType = new System.Windows.Forms.ColumnHeader();
            this.taskDesc = new System.Windows.Forms.ColumnHeader();
            this.taskStatus = new System.Windows.Forms.ColumnHeader();
            this.roomNum = new System.Windows.Forms.ColumnHeader();
            this.taskNoteColumn = new System.Windows.Forms.ColumnHeader();
            this.roomNumTextBox = new System.Windows.Forms.TextBox();
            this.selectRoomBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedRoomLabel = new System.Windows.Forms.Label();
            this.taskTypeComboBox = new System.Windows.Forms.ComboBox();
            this.taskStatusComboBox = new System.Windows.Forms.ComboBox();
            this.taskDescTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.taskNote = new System.Windows.Forms.Label();
            this.taskNoteTextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(244, 36);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(243, 32);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1222, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainWindowToolStripMenuItem,
            this.roomManagmentToolStripMenuItem,
            this.bookingToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // mainWindowToolStripMenuItem
            // 
            this.mainWindowToolStripMenuItem.Name = "mainWindowToolStripMenuItem";
            this.mainWindowToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.mainWindowToolStripMenuItem.Text = "Main Window";
            this.mainWindowToolStripMenuItem.Click += new System.EventHandler(this.mainWindowToolStripMenuItem_Click);
            // 
            // roomManagmentToolStripMenuItem
            // 
            this.roomManagmentToolStripMenuItem.Name = "roomManagmentToolStripMenuItem";
            this.roomManagmentToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.roomManagmentToolStripMenuItem.Text = "Room Management";
            this.roomManagmentToolStripMenuItem.Click += new System.EventHandler(this.roomManagementToolStripMenuItem_Click);
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            this.bookingToolStripMenuItem.Text = "Booking";
            this.bookingToolStripMenuItem.Click += new System.EventHandler(this.bookingToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskId,
            this.taskType,
            this.taskDesc,
            this.taskStatus,
            this.roomNum,
            this.taskNoteColumn});
            this.listView1.Location = new System.Drawing.Point(525, 67);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(630, 429);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // taskId
            // 
            this.taskId.Text = "RoomNum";
            this.taskId.Width = 150;
            // 
            // taskType
            // 
            this.taskType.Text = "TaskType";
            this.taskType.Width = 120;
            // 
            // taskDesc
            // 
            this.taskDesc.Text = "TaskDesc";
            this.taskDesc.Width = 250;
            // 
            // taskStatus
            // 
            this.taskStatus.Text = "TaskStatus";
            this.taskStatus.Width = 150;
            // 
            // roomNum
            // 
            this.roomNum.Text = "Task ID";
            this.roomNum.Width = 100;
            // 
            // taskNoteColumn
            // 
            this.taskNoteColumn.Text = "TaskNote";
            this.taskNoteColumn.Width = 250;
            // 
            // roomNumTextBox
            // 
            this.roomNumTextBox.Location = new System.Drawing.Point(185, 137);
            this.roomNumTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.roomNumTextBox.Name = "roomNumTextBox";
            this.roomNumTextBox.PlaceholderText = "Room Number";
            this.roomNumTextBox.Size = new System.Drawing.Size(142, 31);
            this.roomNumTextBox.TabIndex = 3;
            // 
            // selectRoomBtn
            // 
            this.selectRoomBtn.Location = new System.Drawing.Point(15, 137);
            this.selectRoomBtn.Margin = new System.Windows.Forms.Padding(4);
            this.selectRoomBtn.Name = "selectRoomBtn";
            this.selectRoomBtn.Size = new System.Drawing.Size(128, 34);
            this.selectRoomBtn.TabIndex = 4;
            this.selectRoomBtn.Text = "Select Room";
            this.selectRoomBtn.UseVisualStyleBackColor = true;
            this.selectRoomBtn.Click += new System.EventHandler(this.selectRoomBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 246);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selected Room:";
            // 
            // selectedRoomLabel
            // 
            this.selectedRoomLabel.AutoSize = true;
            this.selectedRoomLabel.Location = new System.Drawing.Point(253, 246);
            this.selectedRoomLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectedRoomLabel.Name = "selectedRoomLabel";
            this.selectedRoomLabel.Size = new System.Drawing.Size(40, 25);
            this.selectedRoomLabel.TabIndex = 6;
            this.selectedRoomLabel.Text = "null";
            // 
            // taskTypeComboBox
            // 
            this.taskTypeComboBox.FormattingEnabled = true;
            this.taskTypeComboBox.Items.AddRange(new object[] {
            "CLEANING",
            "MAINTENANCE",
            "ROOMSERVICE"});
            this.taskTypeComboBox.Location = new System.Drawing.Point(15, 302);
            this.taskTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.taskTypeComboBox.Name = "taskTypeComboBox";
            this.taskTypeComboBox.Size = new System.Drawing.Size(154, 33);
            this.taskTypeComboBox.TabIndex = 7;
            this.taskTypeComboBox.Text = "Task Type";
            // 
            // taskStatusComboBox
            // 
            this.taskStatusComboBox.FormattingEnabled = true;
            this.taskStatusComboBox.Items.AddRange(new object[] {
            "NEW"});
            this.taskStatusComboBox.Location = new System.Drawing.Point(266, 302);
            this.taskStatusComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.taskStatusComboBox.Name = "taskStatusComboBox";
            this.taskStatusComboBox.Size = new System.Drawing.Size(188, 33);
            this.taskStatusComboBox.TabIndex = 8;
            this.taskStatusComboBox.Text = "TaskStatus";
            // 
            // taskDescTextBox
            // 
            this.taskDescTextBox.Location = new System.Drawing.Point(15, 388);
            this.taskDescTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.taskDescTextBox.Multiline = true;
            this.taskDescTextBox.Name = "taskDescTextBox";
            this.taskDescTextBox.Size = new System.Drawing.Size(207, 109);
            this.taskDescTextBox.TabIndex = 9;
            this.taskDescTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 359);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Task Description";
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(125, 505);
            this.addTaskBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(204, 36);
            this.addTaskBtn.TabIndex = 11;
            this.addTaskBtn.Text = "Add Task";
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // taskNote
            // 
            this.taskNote.AutoSize = true;
            this.taskNote.Location = new System.Drawing.Point(266, 358);
            this.taskNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskNote.Name = "taskNote";
            this.taskNote.Size = new System.Drawing.Size(89, 25);
            this.taskNote.TabIndex = 13;
            this.taskNote.Text = "Task Note";
            // 
            // taskNoteTextBox
            // 
            this.taskNoteTextBox.Location = new System.Drawing.Point(266, 387);
            this.taskNoteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.taskNoteTextBox.Multiline = true;
            this.taskNoteTextBox.Name = "taskNoteTextBox";
            this.taskNoteTextBox.Size = new System.Drawing.Size(207, 109);
            this.taskNoteTextBox.TabIndex = 12;
            // 
            // TaskManagmentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 562);
            this.Controls.Add(this.taskNote);
            this.Controls.Add(this.taskNoteTextBox);
            this.Controls.Add(this.addTaskBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskDescTextBox);
            this.Controls.Add(this.taskStatusComboBox);
            this.Controls.Add(this.taskTypeComboBox);
            this.Controls.Add(this.selectedRoomLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectRoomBtn);
            this.Controls.Add(this.roomNumTextBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaskManagmentWindow";
            this.Text = "TaskManagmentWindow";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem mainWindowToolStripMenuItem;
        private ToolStripMenuItem roomManagmentToolStripMenuItem;
        private ToolStripMenuItem bookingToolStripMenuItem;
        private ListView listView1;
        private ColumnHeader taskId;
        private ColumnHeader taskType;
        private ColumnHeader taskDesc;
        private ColumnHeader taskStatus;
        private TextBox roomNumTextBox;
        private Button selectRoomBtn;
        private Label label1;
        private Label selectedRoomLabel;
        private ComboBox taskTypeComboBox;
        private ComboBox taskStatusComboBox;
        private TextBox taskDescTextBox;
        private Label label2;
        private Button addTaskBtn;
        private ColumnHeader roomNum;
        private Label taskNote;
        private TextBox taskNoteTextBox;
        private ColumnHeader taskNoteColumn;
    }
}
