namespace FrontDeskWinForm
{
    partial class RoomEditWindow
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
            this.roomNrLabel = new System.Windows.Forms.Label();
            this.changeStatus = new System.Windows.Forms.Label();
            this.changeNumBedsButton = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveChangesBtn = new System.Windows.Forms.Button();
            this.numBedsComboBox = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomNrLabel
            // 
            this.roomNrLabel.AutoSize = true;
            this.roomNrLabel.Location = new System.Drawing.Point(208, 7);
            this.roomNrLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roomNrLabel.Name = "roomNrLabel";
            this.roomNrLabel.Size = new System.Drawing.Size(69, 20);
            this.roomNrLabel.TabIndex = 0;
            this.roomNrLabel.Text = "Room Nr";
            this.roomNrLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // changeStatus
            // 
            this.changeStatus.AutoSize = true;
            this.changeStatus.Location = new System.Drawing.Point(10, 61);
            this.changeStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.changeStatus.Name = "changeStatus";
            this.changeStatus.Size = new System.Drawing.Size(103, 20);
            this.changeStatus.TabIndex = 1;
            this.changeStatus.Text = "Change Status";
            // 
            // changeNumBedsButton
            // 
            this.changeNumBedsButton.Location = new System.Drawing.Point(10, 102);
            this.changeNumBedsButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeNumBedsButton.Name = "changeNumBedsButton";
            this.changeNumBedsButton.Size = new System.Drawing.Size(100, 50);
            this.changeNumBedsButton.TabIndex = 2;
            this.changeNumBedsButton.Text = "Change num beds";
            this.changeNumBedsButton.UseVisualStyleBackColor = true;
            this.changeNumBedsButton.Click += new System.EventHandler(this.ChangeNumBedsButton_Click);
            // 
            // status
            // 
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "AVAILABLE",
            "OCCUPIED"});
            this.status.Location = new System.Drawing.Point(151, 61);
            this.status.Margin = new System.Windows.Forms.Padding(2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(192, 28);
            this.status.TabIndex = 4;
            this.status.Text = "Status";
            this.status.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(410, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.mainToolStripMenuItem.Text = "Main";
            this.mainToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Location = new System.Drawing.Point(151, 174);
            this.saveChangesBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(191, 27);
            this.saveChangesBtn.TabIndex = 6;
            this.saveChangesBtn.Text = "Save Changes";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // numBedsComboBox
            // 
            this.numBedsComboBox.FormattingEnabled = true;
            this.numBedsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.numBedsComboBox.Location = new System.Drawing.Point(151, 114);
            this.numBedsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.numBedsComboBox.Name = "numBedsComboBox";
            this.numBedsComboBox.Size = new System.Drawing.Size(192, 28);
            this.numBedsComboBox.TabIndex = 7;
            this.numBedsComboBox.Text = "Number beds";
            // 
            // RoomEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 210);
            this.Controls.Add(this.numBedsComboBox);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.status);
            this.Controls.Add(this.changeNumBedsButton);
            this.Controls.Add(this.changeStatus);
            this.Controls.Add(this.roomNrLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RoomEditWindow";
            this.Text = "RoomEditWindow";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label roomNrLabel;
        private Label changeStatus;
        private Button changeNumBedsButton;
        private ComboBox status;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem mainToolStripMenuItem;
        private Button saveChangesBtn;
        private ComboBox numBedsComboBox;
    }
}