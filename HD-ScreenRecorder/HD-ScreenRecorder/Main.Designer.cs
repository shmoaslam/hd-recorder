namespace HD_ScreenRecorder
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_JopList = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.btn_Mic = new System.Windows.Forms.Button();
            this.btn_RecStop = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.miPause_Resume = new System.Windows.Forms.ToolStripMenuItem();
            this.miStop = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_About);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMinimize);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 407);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Controls.Add(this.lblValue);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.lblStage);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnBrowse);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnEncode);
            this.panel3.Controls.Add(this.progressBar1);
            this.panel3.Controls.Add(this.listView1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(3, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 330);
            this.panel3.TabIndex = 12;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.ForeColor = System.Drawing.Color.White;
            this.lblValue.Location = new System.Drawing.Point(41, 313);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(13, 13);
            this.lblValue.TabIndex = 17;
            this.lblValue.Text = "0";
            this.lblValue.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Value";
            this.label5.Visible = false;
            // 
            // lblStage
            // 
            this.lblStage.AutoSize = true;
            this.lblStage.ForeColor = System.Drawing.Color.White;
            this.lblStage.Location = new System.Drawing.Point(41, 298);
            this.lblStage.Name = "lblStage";
            this.lblStage.Size = new System.Drawing.Size(37, 13);
            this.lblStage.TabIndex = 15;
            this.lblStage.Text = "1 Of 2";
            this.lblStage.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Stage";
            this.label3.Visible = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Gray;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.ForeColor = System.Drawing.Color.LightGray;
            this.btnBrowse.Location = new System.Drawing.Point(262, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(58, 21);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "....";
            this.btnBrowse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gray;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.LightGray;
            this.btnDelete.Location = new System.Drawing.Point(134, 299);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 21);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.Color.Gray;
            this.btnEncode.FlatAppearance.BorderSize = 0;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.ForeColor = System.Drawing.Color.LightGray;
            this.btnEncode.Location = new System.Drawing.Point(230, 299);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(90, 21);
            this.btnEncode.TabIndex = 11;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.progressBar1.Location = new System.Drawing.Point(3, 288);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(317, 5);
            this.progressBar1.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DimGray;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.ForeColor = System.Drawing.Color.LightGray;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(4, 35);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(316, 247);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Your Job List";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "StateIndicatorModels.Icon.png");
            this.imageList1.Images.SetKeyName(1, "Action_Debug_Start_32x32.png");
            this.imageList1.Images.SetKeyName(2, "play.png");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Andalus", 10F);
            this.textBox1.ForeColor = System.Drawing.Color.LightGray;
            this.textBox1.Location = new System.Drawing.Point(4, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(255, 21);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "HD-Screen Recorder";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // lblMinimize
            // 
            this.lblMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimize.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblMinimize.ForeColor = System.Drawing.Color.LightGray;
            this.lblMinimize.Location = new System.Drawing.Point(279, 5);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(20, 20);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "_";
            this.lblMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            this.lblMinimize.MouseHover += new System.EventHandler(this.lblMinimize_MouseHover);
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblClose.ForeColor = System.Drawing.Color.LightGray;
            this.lblClose.Location = new System.Drawing.Point(305, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 20);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "x";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.lblClose_MouseHover);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.btn_JopList);
            this.panel2.Controls.Add(this.btn_Setting);
            this.panel2.Controls.Add(this.btn_Mic);
            this.panel2.Controls.Add(this.btn_RecStop);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 38);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "mydReam\r\nHD-Screen Recorder";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "HD-Screen Recorder";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPause_Resume,
            this.miStop,
            this.toolStripSeparator1,
            this.miExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 76);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(98, 22);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // btn_JopList
            // 
            this.btn_JopList.BackgroundImage = global::HD_ScreenRecorder.Properties.Resources.joplist;
            this.btn_JopList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_JopList.FlatAppearance.BorderSize = 0;
            this.btn_JopList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JopList.Location = new System.Drawing.Point(182, 6);
            this.btn_JopList.Name = "btn_JopList";
            this.btn_JopList.Size = new System.Drawing.Size(25, 25);
            this.btn_JopList.TabIndex = 7;
            this.btn_JopList.UseVisualStyleBackColor = true;
            this.btn_JopList.Click += new System.EventHandler(this.btn_JopList_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackgroundImage = global::HD_ScreenRecorder.Properties.Resources.setting;
            this.btn_Setting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Location = new System.Drawing.Point(219, 6);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(25, 25);
            this.btn_Setting.TabIndex = 6;
            this.btn_Setting.UseVisualStyleBackColor = true;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // btn_Mic
            // 
            this.btn_Mic.BackgroundImage = global::HD_ScreenRecorder.Properties.Resources.mic_on;
            this.btn_Mic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Mic.FlatAppearance.BorderSize = 0;
            this.btn_Mic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mic.Location = new System.Drawing.Point(256, 6);
            this.btn_Mic.Name = "btn_Mic";
            this.btn_Mic.Size = new System.Drawing.Size(25, 25);
            this.btn_Mic.TabIndex = 5;
            this.btn_Mic.UseVisualStyleBackColor = true;
            this.btn_Mic.Click += new System.EventHandler(this.btn_Mic_Click);
            // 
            // btn_RecStop
            // 
            this.btn_RecStop.BackgroundImage = global::HD_ScreenRecorder.Properties.Resources.rec;
            this.btn_RecStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_RecStop.FlatAppearance.BorderSize = 0;
            this.btn_RecStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RecStop.Location = new System.Drawing.Point(293, 6);
            this.btn_RecStop.Name = "btn_RecStop";
            this.btn_RecStop.Size = new System.Drawing.Size(25, 25);
            this.btn_RecStop.TabIndex = 4;
            this.btn_RecStop.UseVisualStyleBackColor = true;
            this.btn_RecStop.Click += new System.EventHandler(this.btn_RecStop_Click);
            // 
            // btn_About
            // 
            this.btn_About.BackgroundImage = global::HD_ScreenRecorder.Properties.Resources.StateIndicatorModels_Icon;
            this.btn_About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_About.FlatAppearance.BorderSize = 0;
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Location = new System.Drawing.Point(3, 3);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(25, 25);
            this.btn_About.TabIndex = 5;
            this.btn_About.UseVisualStyleBackColor = true;
            // 
            // miPause_Resume
            // 
            this.miPause_Resume.Enabled = false;
            this.miPause_Resume.Image = global::HD_ScreenRecorder.Properties.Resources.Pause;
            this.miPause_Resume.Name = "miPause_Resume";
            this.miPause_Resume.ShowShortcutKeys = false;
            this.miPause_Resume.Size = new System.Drawing.Size(98, 22);
            this.miPause_Resume.Text = "Pause";
            this.miPause_Resume.Click += new System.EventHandler(this.miPause_Resume_Click);
            // 
            // miStop
            // 
            this.miStop.Enabled = false;
            this.miStop.Image = global::HD_ScreenRecorder.Properties.Resources.stop;
            this.miStop.Name = "miStop";
            this.miStop.Size = new System.Drawing.Size(98, 22);
            this.miStop.Text = "Stop";
            this.miStop.Click += new System.EventHandler(this.miStop_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Main_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_RecStop;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.Button btn_Mic;
        private System.Windows.Forms.Button btn_JopList;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStage;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miPause_Resume;
        private System.Windows.Forms.ToolStripMenuItem miStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miExit;
    }
}

