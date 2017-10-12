namespace HD_ScreenRecorder
{
    partial class frmSetting
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
            this.pnlScreen = new System.Windows.Forms.Panel();
            this.cboCaptureRect = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkFollowMC = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboCaptureMC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFrameRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnScreen = new System.Windows.Forms.Button();
            this.btnOther = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlAbout = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.chkShowFashing = new System.Windows.Forms.CheckBox();
            this.chkShowCountdown = new System.Windows.Forms.CheckBox();
            this.lblClose = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlScreen.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlOther.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScreen
            // 
            this.pnlScreen.BackColor = System.Drawing.Color.DimGray;
            this.pnlScreen.Controls.Add(this.cboCaptureRect);
            this.pnlScreen.Controls.Add(this.label9);
            this.pnlScreen.Controls.Add(this.chkFollowMC);
            this.pnlScreen.Controls.Add(this.label8);
            this.pnlScreen.Controls.Add(this.cboCaptureMC);
            this.pnlScreen.Controls.Add(this.label7);
            this.pnlScreen.Controls.Add(this.txtQuality);
            this.pnlScreen.Controls.Add(this.label2);
            this.pnlScreen.Controls.Add(this.label6);
            this.pnlScreen.Controls.Add(this.cboFrameRate);
            this.pnlScreen.Controls.Add(this.label3);
            this.pnlScreen.Location = new System.Drawing.Point(3, 25);
            this.pnlScreen.Name = "pnlScreen";
            this.pnlScreen.Size = new System.Drawing.Size(289, 200);
            this.pnlScreen.TabIndex = 0;
            // 
            // cboCaptureRect
            // 
            this.cboCaptureRect.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cboCaptureRect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaptureRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaptureRect.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboCaptureRect.ForeColor = System.Drawing.Color.White;
            this.cboCaptureRect.FormattingEnabled = true;
            this.cboCaptureRect.Items.AddRange(new object[] {
            "Full Screen",
            "Working Area"});
            this.cboCaptureRect.Location = new System.Drawing.Point(139, 133);
            this.cboCaptureRect.Name = "cboCaptureRect";
            this.cboCaptureRect.Size = new System.Drawing.Size(113, 21);
            this.cboCaptureRect.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(32, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Capture Rectangle :";
            // 
            // chkFollowMC
            // 
            this.chkFollowMC.AutoSize = true;
            this.chkFollowMC.ForeColor = System.Drawing.Color.White;
            this.chkFollowMC.Location = new System.Drawing.Point(139, 107);
            this.chkFollowMC.Name = "chkFollowMC";
            this.chkFollowMC.Size = new System.Drawing.Size(15, 14);
            this.chkFollowMC.TabIndex = 9;
            this.chkFollowMC.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Follow mouse cursor :";
            // 
            // cboCaptureMC
            // 
            this.cboCaptureMC.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cboCaptureMC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaptureMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCaptureMC.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboCaptureMC.ForeColor = System.Drawing.Color.White;
            this.cboCaptureMC.FormattingEnabled = true;
            this.cboCaptureMC.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboCaptureMC.Location = new System.Drawing.Point(139, 75);
            this.cboCaptureMC.Name = "cboCaptureMC";
            this.cboCaptureMC.Size = new System.Drawing.Size(113, 21);
            this.cboCaptureMC.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Capture mouse cursor :";
            // 
            // txtQuality
            // 
            this.txtQuality.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtQuality.ForeColor = System.Drawing.Color.White;
            this.txtQuality.Location = new System.Drawing.Point(139, 46);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(68, 20);
            this.txtQuality.TabIndex = 5;
            this.txtQuality.Text = "95";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quality (1-100) :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(230, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "fps";
            // 
            // cboFrameRate
            // 
            this.cboFrameRate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.cboFrameRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrameRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFrameRate.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboFrameRate.ForeColor = System.Drawing.Color.White;
            this.cboFrameRate.FormattingEnabled = true;
            this.cboFrameRate.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "60"});
            this.cboFrameRate.Location = new System.Drawing.Point(139, 17);
            this.cboFrameRate.Name = "cboFrameRate";
            this.cboFrameRate.Size = new System.Drawing.Size(85, 21);
            this.cboFrameRate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Frame Rate :";
            // 
            // btnScreen
            // 
            this.btnScreen.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnScreen.FlatAppearance.BorderSize = 0;
            this.btnScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreen.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnScreen.ForeColor = System.Drawing.Color.White;
            this.btnScreen.Location = new System.Drawing.Point(3, 3);
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.Size = new System.Drawing.Size(50, 23);
            this.btnScreen.TabIndex = 1;
            this.btnScreen.Text = "Screen";
            this.btnScreen.UseVisualStyleBackColor = false;
            this.btnScreen.Click += new System.EventHandler(this.btnScreen_Click);
            // 
            // btnOther
            // 
            this.btnOther.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOther.FlatAppearance.BorderSize = 0;
            this.btnOther.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOther.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnOther.ForeColor = System.Drawing.Color.White;
            this.btnOther.Location = new System.Drawing.Point(55, 3);
            this.btnOther.Name = "btnOther";
            this.btnOther.Size = new System.Drawing.Size(50, 23);
            this.btnOther.TabIndex = 3;
            this.btnOther.Text = "Other";
            this.btnOther.UseVisualStyleBackColor = false;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(107, 3);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(50, 23);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pnlAbout);
            this.panel2.Controls.Add(this.pnlOther);
            this.panel2.Controls.Add(this.pnlScreen);
            this.panel2.Controls.Add(this.btnAbout);
            this.panel2.Controls.Add(this.btnScreen);
            this.panel2.Controls.Add(this.btnOther);
            this.panel2.Location = new System.Drawing.Point(2, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 349);
            this.panel2.TabIndex = 5;
            // 
            // pnlAbout
            // 
            this.pnlAbout.BackColor = System.Drawing.Color.DimGray;
            this.pnlAbout.Controls.Add(this.label10);
            this.pnlAbout.Controls.Add(this.linkLabel2);
            this.pnlAbout.Controls.Add(this.pictureBox3);
            this.pnlAbout.Controls.Add(this.pictureBox2);
            this.pnlAbout.Controls.Add(this.linkLabel1);
            this.pnlAbout.Controls.Add(this.pictureBox1);
            this.pnlAbout.Controls.Add(this.label5);
            this.pnlAbout.Controls.Add(this.label4);
            this.pnlAbout.Location = new System.Drawing.Point(298, 110);
            this.pnlAbout.Name = "pnlAbout";
            this.pnlAbout.Size = new System.Drawing.Size(261, 196);
            this.pnlAbout.TabIndex = 7;
            this.pnlAbout.Visible = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("AR BERKLEY", 10F);
            this.linkLabel2.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel2.Location = new System.Drawing.Point(82, 132);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(96, 19);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Youtube Chanel";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HD_ScreenRecorder.Properties.Resources.facebook_c3eh;
            this.pictureBox3.Location = new System.Drawing.Point(44, 98);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HD_ScreenRecorder.Properties.Resources.youtube_a_512;
            this.pictureBox2.Location = new System.Drawing.Point(44, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("AR BERKLEY", 10F);
            this.linkLabel1.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linkLabel1.Location = new System.Drawing.Point(82, 102);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 19);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Facebook Group";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HD_ScreenRecorder.Properties.Resources.HD_icon;
            this.pictureBox1.Location = new System.Drawing.Point(23, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("AR BERKLEY", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "By Michael Azzer .. 7/21/2016";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "-Screen Recorder";
            // 
            // pnlOther
            // 
            this.pnlOther.BackColor = System.Drawing.Color.DimGray;
            this.pnlOther.Controls.Add(this.chkShowFashing);
            this.pnlOther.Controls.Add(this.chkShowCountdown);
            this.pnlOther.Location = new System.Drawing.Point(298, 25);
            this.pnlOther.Name = "pnlOther";
            this.pnlOther.Size = new System.Drawing.Size(261, 154);
            this.pnlOther.TabIndex = 6;
            this.pnlOther.Visible = false;
            // 
            // chkShowFashing
            // 
            this.chkShowFashing.AutoSize = true;
            this.chkShowFashing.ForeColor = System.Drawing.Color.White;
            this.chkShowFashing.Location = new System.Drawing.Point(44, 49);
            this.chkShowFashing.Name = "chkShowFashing";
            this.chkShowFashing.Size = new System.Drawing.Size(141, 17);
            this.chkShowFashing.TabIndex = 11;
            this.chkShowFashing.Text = "Show flashing boundary";
            this.chkShowFashing.UseVisualStyleBackColor = true;
            // 
            // chkShowCountdown
            // 
            this.chkShowCountdown.AutoSize = true;
            this.chkShowCountdown.ForeColor = System.Drawing.Color.White;
            this.chkShowCountdown.Location = new System.Drawing.Point(44, 24);
            this.chkShowCountdown.Name = "chkShowCountdown";
            this.chkShowCountdown.Size = new System.Drawing.Size(191, 17);
            this.chkShowCountdown.TabIndex = 10;
            this.chkShowCountdown.Text = "Show countdown before recording";
            this.chkShowCountdown.UseVisualStyleBackColor = true;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lblClose.ForeColor = System.Drawing.Color.LightGray;
            this.lblClose.Location = new System.Drawing.Point(567, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 20);
            this.lblClose.TabIndex = 5;
            this.lblClose.Text = "x";
            this.lblClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            this.lblClose.MouseHover += new System.EventHandler(this.lblClose_MouseHover);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 408);
            this.panel3.TabIndex = 6;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.LightGray;
            this.btnReset.Location = new System.Drawing.Point(6, 383);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(55, 21);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.LightGray;
            this.btnSave.Location = new System.Drawing.Point(476, 383);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(55, 21);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancel.Location = new System.Drawing.Point(537, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(55, 21);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Options";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(26, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "email : michael.mydreamvb2010@gmail.com";
            // 
            // frmSetting
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(595, 408);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmSetting_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmSetting_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmSetting_MouseUp);
            this.pnlScreen.ResumeLayout(false);
            this.pnlScreen.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlAbout.ResumeLayout(false);
            this.pnlAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlOther.ResumeLayout(false);
            this.pnlOther.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlScreen;
        private System.Windows.Forms.Button btnScreen;
        private System.Windows.Forms.Button btnOther;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlAbout;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFrameRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboCaptureMC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkFollowMC;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboCaptureRect;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkShowFashing;
        private System.Windows.Forms.CheckBox chkShowCountdown;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label10;
    }
}