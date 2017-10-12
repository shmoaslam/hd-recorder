using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HD_ScreenRecorder
{
    public partial class frmSetting : Form
    {
        bool drag;
        int mousex;
        int mousey;
        public frmSetting()
        {
           
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(330, 290);
            this.panel2.Location = new System.Drawing.Point(2, 28);
            this.panel2.Size = new System.Drawing.Size(326, 230);
            this.pnlScreen.Location = new System.Drawing.Point(3, 25);
            this.pnlScreen.Size = new System.Drawing.Size(318, 200);
            this.pnlOther.Location = new System.Drawing.Point(3, 25);
            this.pnlOther.Size = new System.Drawing.Size(318, 200);
            this.pnlAbout.Location = new System.Drawing.Point(3, 25);
            this.pnlAbout.Size = new System.Drawing.Size(318, 200);
        }

        #region" Special code for Close Form Button "

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.LightGray;
        }

        #endregion

        #region" Dragging Main form without border "

        private void frmSetting_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; //Sets the variable drag to true.  
            mousex = Cursor.Position.X - this.Left; // Sets variable mousex  
            mousey = Cursor.Position.Y - this.Top;  // Sets variable mousey  
        }

        private void frmSetting_MouseMove(object sender, MouseEventArgs e)
        {
            // If drag is set to true then move the form accordingly.  
            if (drag)
            {
                this.Top = Cursor.Position.Y - mousey;
                this.Left = Cursor.Position.X - mousex;
            }
        }

        private void frmSetting_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false; // Sets drag to false, so the form does not move according to the code in MouseMove 
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; // Sets the variable drag to true.  
            mousex = Cursor.Position.X - this.Left; // Sets variable mousex  
            mousey = Cursor.Position.Y - this.Top; // Sets variable mousey  
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            // If drag is set to true then move the form accordingly.  
            if (drag)
            {
                this.Top = Cursor.Position.Y - mousey;
                this.Left = Cursor.Position.X - mousex;
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        #endregion

        #region" Special TabPages Buttons "

        private void btnScreen_Click(object sender, EventArgs e)
        {
            ShowSelectedPanel(pnlScreen);
            MarkSelectedButton(btnScreen);
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            ShowSelectedPanel(pnlOther);
            MarkSelectedButton(btnOther);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ShowSelectedPanel(pnlAbout);
            MarkSelectedButton(btnAbout);
        }

        void MarkSelectedButton(Button selectedBtn)
        {
            btnAbout.BackColor = Color.DarkSlateGray;
            btnOther.BackColor = Color.DarkSlateGray;
            btnScreen.BackColor = Color.DarkSlateGray;
            selectedBtn.BackColor = Color.LightSeaGreen;
        }

        void ShowSelectedPanel(Panel selectedPanel)
        {
            pnlAbout.Visible = false;
            pnlOther.Visible = false;
            pnlScreen.Visible = false;
            selectedPanel.Visible = true;
        }

        #endregion

        void saveSettings()
        {
            if (int.Parse(txtQuality.Text) > 100)
            {
                MessageBox.Show(" Quality must be an integer between 1 and 100 ", "HD-Screen Recorder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuality.Focus();
                txtQuality.SelectAll();
                return;
            }
            Properties.Settings.Default.FrameRate = int.Parse(cboFrameRate.Text);
            Properties.Settings.Default.Quality = int.Parse(txtQuality.Text);
            if (cboCaptureMC.Text == "Yes")
                Properties.Settings.Default.CaptureMC = true;
            else
                Properties.Settings.Default.CaptureMC = false;
            Properties.Settings.Default.FollowMC = Convert.ToBoolean(chkFollowMC.CheckState);
            Properties.Settings.Default.CaptureRect = cboCaptureRect.Text;
            Properties.Settings.Default.ShowCountdown=Convert.ToBoolean(chkShowCountdown.CheckState);
            Properties.Settings.Default.ShowFlashing=Convert.ToBoolean(chkShowFashing.CheckState);
            Properties.Settings.Default.Save();
        }

        void resetSettings()
        {
            cboFrameRate.Text = "15";
            txtQuality.Text = "95";
            cboCaptureMC.Text="Yes";
            chkFollowMC.Checked = false;
            cboCaptureRect.Text = "Working Area";
            chkShowCountdown.Checked = true;
            chkShowFashing.Checked = true;
            saveSettings();
        }

        void loadSettings()
        {
            cboFrameRate.Text = Properties.Settings.Default.FrameRate.ToString();
            txtQuality.Text = Properties.Settings.Default.Quality.ToString();
            if (Properties.Settings.Default.CaptureMC == true)
                cboCaptureMC.Text = "Yes";
            else
                cboCaptureMC.Text = "NO";
            chkFollowMC.Checked = Properties.Settings.Default.FollowMC;
            cboCaptureRect.Text = Properties.Settings.Default.CaptureRect;
            chkShowCountdown.Checked = Properties.Settings.Default.ShowCountdown;
            chkShowFashing.Checked = Properties.Settings.Default.ShowFlashing;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            saveSettings();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetSettings();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            loadSettings();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/groups/385562694820327/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCbTYtCB4BBEKWnBIENb_LjA");
        }
    }
}
