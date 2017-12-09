namespace IPHistogram
{
    partial class frmMain
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistogramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdMedian = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.picturePreview = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdAverage = new System.Windows.Forms.Button();
            this.cmdLOG = new System.Windows.Forms.Button();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboColors = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblSize = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.editToolStripMenuItem,
            this.heToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(660, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.SaveStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // SaveStripMenuItem
            // 
            this.SaveStripMenuItem.Name = "SaveStripMenuItem";
            this.SaveStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.SaveStripMenuItem.Text = "Save as...";
            this.SaveStripMenuItem.Click += new System.EventHandler(this.SaveStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = "Alt +X";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHistogramToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearHistogramToolStripMenuItem
            // 
            this.clearHistogramToolStripMenuItem.Name = "clearHistogramToolStripMenuItem";
            this.clearHistogramToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.clearHistogramToolStripMenuItem.Text = "Clear histogram";
            this.clearHistogramToolStripMenuItem.Click += new System.EventHandler(this.clearHistogramToolStripMenuItem_Click);
            // 
            // heToolStripMenuItem
            // 
            this.heToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.heToolStripMenuItem.Name = "heToolStripMenuItem";
            this.heToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.heToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblLine
            // 
            this.lblLine.BackColor = System.Drawing.Color.Black;
            this.lblLine.Location = new System.Drawing.Point(-3, 24);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(667, 2);
            this.lblLine.TabIndex = 4;
            this.lblLine.Text = "label1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-3, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 2);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // cmdMedian
            // 
            this.cmdMedian.Enabled = false;
            this.cmdMedian.Location = new System.Drawing.Point(134, 50);
            this.cmdMedian.Name = "cmdMedian";
            this.cmdMedian.Size = new System.Drawing.Size(72, 23);
            this.cmdMedian.TabIndex = 13;
            this.cmdMedian.Text = "Median";
            this.cmdMedian.UseVisualStyleBackColor = true;
            this.cmdMedian.Click += new System.EventHandler(this.cmdMedian_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 330);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Picture";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(6, 19);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(300, 300);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picturePreview);
            this.groupBox2.Location = new System.Drawing.Point(333, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 330);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // picturePreview
            // 
            this.picturePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picturePreview.Location = new System.Drawing.Point(6, 19);
            this.picturePreview.Name = "picturePreview";
            this.picturePreview.Size = new System.Drawing.Size(300, 300);
            this.picturePreview.TabIndex = 4;
            this.picturePreview.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSize);
            this.groupBox3.Controls.Add(this.cmdAverage);
            this.groupBox3.Controls.Add(this.cmdLOG);
            this.groupBox3.Controls.Add(this.txtSize);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmdMedian);
            this.groupBox3.Location = new System.Drawing.Point(16, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 85);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filters";
            // 
            // cmdAverage
            // 
            this.cmdAverage.Enabled = false;
            this.cmdAverage.Location = new System.Drawing.Point(6, 50);
            this.cmdAverage.Name = "cmdAverage";
            this.cmdAverage.Size = new System.Drawing.Size(99, 23);
            this.cmdAverage.TabIndex = 28;
            this.cmdAverage.Text = "Local Averaging";
            this.cmdAverage.UseVisualStyleBackColor = true;
            this.cmdAverage.Click += new System.EventHandler(this.cmdAverage_Click);
            // 
            // cmdLOG
            // 
            this.cmdLOG.Enabled = false;
            this.cmdLOG.Location = new System.Drawing.Point(244, 50);
            this.cmdLOG.Name = "cmdLOG";
            this.cmdLOG.Size = new System.Drawing.Size(60, 23);
            this.cmdLOG.TabIndex = 24;
            this.cmdLOG.Text = "LOG";
            this.cmdLOG.UseVisualStyleBackColor = true;
            this.cmdLOG.Click += new System.EventHandler(this.cmdLOG_Click);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(156, 21);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(25, 20);
            this.txtSize.TabIndex = 23;
            this.txtSize.Text = "3";
            this.txtSize.TextChanged += new System.EventHandler(this.txtSize_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Size:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lblWidth);
            this.groupBox4.Controls.Add(this.lblHeight);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.lblColor);
            this.groupBox4.Controls.Add(this.lblValue);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.comboColors);
            this.groupBox4.Location = new System.Drawing.Point(333, 379);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 85);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Histogram";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Height:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(193, 22);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(13, 13);
            this.lblWidth.TabIndex = 22;
            this.lblWidth.Text = "--";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(193, 40);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(13, 13);
            this.lblHeight.TabIndex = 21;
            this.lblHeight.Text = "--";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Maximum Value:";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(99, 22);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(13, 13);
            this.lblColor.TabIndex = 18;
            this.lblColor.Text = "--";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(99, 40);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(13, 13);
            this.lblValue.TabIndex = 17;
            this.lblValue.Text = "--";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Maximum Color:";
            // 
            // comboColors
            // 
            this.comboColors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboColors.FormattingEnabled = true;
            this.comboColors.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue"});
            this.comboColors.Location = new System.Drawing.Point(242, 16);
            this.comboColors.Name = "comboColors";
            this.comboColors.Size = new System.Drawing.Size(64, 21);
            this.comboColors.TabIndex = 11;
            this.comboColors.SelectedIndexChanged += new System.EventHandler(this.comboColors_SelectedIndexChanged_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 477);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(660, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(350, 17);
            this.lblStatus.Text = "Done";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(186, 25);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(21, 13);
            this.lblSize.TabIndex = 29;
            this.lblSize.Text = "x 3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 499);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Histogram";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePreview)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearHistogramToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdMedian;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picturePreview;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboColors;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem SaveStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripMenuItem heToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdLOG;
        private System.Windows.Forms.Button cmdAverage;
        private System.Windows.Forms.Label lblSize;
    }
}

