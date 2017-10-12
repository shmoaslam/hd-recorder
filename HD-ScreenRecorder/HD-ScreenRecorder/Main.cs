using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Expression.Encoder.ScreenCapture;
using System.Collections.ObjectModel;
using Microsoft.Expression.Encoder.Devices;
using System.IO;
using Microsoft.Expression.Encoder;
using Microsoft.Win32;

namespace HD_ScreenRecorder
{


    public partial class Main : Form
    {
        private ScreenCaptureJob job;
        bool drag;
        int mousex;
        int mousey;
        bool Rec=false ;
        bool mic = true;
        string OutputPath;
        string jobOutput;
        string videosOutput;

        public Main()
        {
            /* Run as administrator required here for first time to add required regestry key.
             * after that you can run your application normally 
             * or you can add this key in installation proccess*/
            AddRequiredRegestryKey();

            InitializeComponent();

            this.ClientSize = new System.Drawing.Size(330, 70);
            if (Properties.Settings.Default.OutputPath == "")
            {
                OutputPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\HD Screen Recorder";
            }
            else
            {
                OutputPath = Properties.Settings.Default.OutputPath;
            }
            jobOutput = OutputPath + "\\Screen Capture Output"; // Directory for jobs before encoding .
            videosOutput = OutputPath + "\\Videos Output";      // Directory for Videos 

            if (!Directory.Exists(jobOutput))
            {
                Directory.CreateDirectory(jobOutput);
            }
            if (!Directory.Exists(videosOutput))
            {
                Directory.CreateDirectory(videosOutput);
            }

        }

        #region" Special code for Close and Minimize Form Buttons "
        
        private void lblClose_MouseHover(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.White;
        }

        private void lblMinimize_MouseHover(object sender, EventArgs e)
        {
            lblMinimize.ForeColor = Color.White;
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            lblMinimize.ForeColor = Color.LightGray;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.ForeColor = Color.LightGray;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        #endregion

        #region" Dragging Main form without border "

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; //Sets the variable drag to true.  
            mousex = Cursor.Position.X - this.Left; // Sets variable mousex  
            mousey = Cursor.Position.Y - this.Top;  // Sets variable mousey  
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            // If drag is set to true then move the form accordingly.  
            if (drag)
            {
                this.Top = Cursor.Position.Y - mousey;
                this.Left = Cursor.Position.X - mousex;
            }
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false; // Sets drag to false, so the form does not move according to the code in MouseMove 
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; // Sets the variable drag to true.  
            mousex = Cursor.Position.X - this.Left; // Sets variable mousex  
            mousey = Cursor.Position.Y - this.Top; // Sets variable mousey  
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            // If drag is set to true then move the form accordingly.  
            if (drag)
            {
                this.Top = Cursor.Position.Y - mousey;
                this.Left =Cursor.Position.X - mousex;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true; // Sets the variable drag to true.  
            mousex = Cursor.Position.X - this.Left; // Sets variable mousex  
            mousey = Cursor.Position.Y - this.Top; // Sets variable mousey  
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            // If drag is set to true then move the form accordingly.  

            if (drag)
            {
                this.Top = Cursor.Position.Y - mousey;
                this.Left = Cursor.Position.X - mousex;
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        #endregion

        #region" Main Buttons "

        private void btn_RecStop_Click(object sender, EventArgs e)
        {
            if (!Rec)
            {
                StartRecording();
            }
            else
            {
                StopRecording();
            }

        }

        private void btn_Mic_Click(object sender, EventArgs e)
        {
            if (mic)
            {
                mic = false;
                btn_Mic.BackgroundImage = Properties.Resources.mic_off;
            }
            else
            {
                mic = true;
                btn_Mic.BackgroundImage = Properties.Resources.mic_on;
            }
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            frmSetting frm = new frmSetting();
            frm.ShowDialog();
        }

        private void btn_JopList_Click(object sender, EventArgs e)
        {
            textBox1.Text = jobOutput;
            if (this.Height == 70)
            {
                this.Height = 407;

                LoadJobsList(jobOutput, listView1);

                if (this.Bottom > SystemInformation.WorkingArea.Bottom)
                {
                    this.Top = SystemInformation.WorkingArea.Bottom - this.Height;
                }
            }
            else
            {
                this.Height = 70;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = dialog.SelectedPath;
                OutputPath = dialog.SelectedPath;
                LoadJobsList(jobOutput, listView1);
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            label3.Visible = true;
            label5.Visible = true;
            lblStage.Visible = true;
            lblValue.Visible = true;
            lblValue.Text = "0";
            lblStage.Text = "1 Of 2";
            label3.Text = "Stage";
            this.Refresh();
            Encode(listView1.FocusedItem.SubItems[1].Text);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                try
                {
                    File.Delete(listView1.FocusedItem.SubItems[1].Text.ToString());
                    listView1.FocusedItem.Remove();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        #endregion

        #region" Important Functions "
        /* the most important function. here you can set your 
         * preferred settings and properties for your ScreenCaptureJop */
        void StartCapturing(bool withAudio)
        {
            job = new ScreenCaptureJob(); // creat new job

            System.Drawing.Size FullScreen = SystemInformation.PrimaryMonitorSize; // for full screen area
            System.Drawing.Size WorkingArea = SystemInformation.WorkingArea.Size;  // for working area = (full screen - Taskbar )
            Rectangle captureRect;
            if (Properties.Settings.Default.CaptureRect == "Full Screen")
            {
                // captureRect = new Rectangle(0, 0, FullScreen.Width , FullScreen.Height); *** this line valid in Microsoft Expression Encoder 4 SP1 and invalid in SP2
                captureRect = new Rectangle(0, 0, FullScreen.Width - (FullScreen.Width % 4), FullScreen.Height - (FullScreen.Height % 4));
            }
            else
            {
                // captureRect = new Rectangle(0, 0, WorkingArea.Width , WorkingArea.Width); *** this line valid in Microsoft Expression Encoder 4 SP1 and invalid in SP2
                captureRect = new Rectangle(0, 0, WorkingArea.Width - (WorkingArea.Width % 4), WorkingArea.Height - (WorkingArea.Height % 4));
            }

            job.CaptureRectangle = captureRect;
            job.ShowFlashingBoundary = Properties.Settings.Default.ShowFlashing;
            job.ScreenCaptureVideoProfile.FrameRate = Properties.Settings.Default.FrameRate;
            job.ScreenCaptureVideoProfile.Quality = Properties.Settings.Default.Quality;
            job.CaptureMouseCursor = Properties.Settings.Default.CaptureMC;
            job.CaptureFollowCursor = Properties.Settings.Default.FollowMC;
            Point p = job.CaptureFollowLocation;
            if (withAudio)
            {
                job.AddAudioDeviceSource(AudioDevices());
            }
            job.ShowCountdown = Properties.Settings.Default.ShowCountdown;
            job.OutputPath = jobOutput;
            job.Start();
        }

        // this code to enable audio recording
        EncoderDevice AudioDevices()
        {
            EncoderDevice foundDevice = null;
            Collection<EncoderDevice> audioDevices = EncoderDevices.FindDevices(EncoderDeviceType.Audio);
            try
            {
                // you can chose yor device here 
                foundDevice = audioDevices.First();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Cannot find prefered audio device using " + audioDevices[0].Name + ex.Message);
            }
            return foundDevice;
        }

        // Encoding Function 
        void Encode(string jobPath)
        {
            using (Job j = new Job())
            {

                MediaItem mediaItem = new MediaItem(jobPath);
                var size = mediaItem.OriginalVideoSize;
                WindowsMediaOutputFormat WMV_Format = new WindowsMediaOutputFormat();
                WMV_Format.VideoProfile = new Microsoft.Expression.Encoder.Profiles.AdvancedVC1VideoProfile();
                WMV_Format.AudioProfile = new Microsoft.Expression.Encoder.Profiles.WmaAudioProfile();
                WMV_Format.VideoProfile.AspectRatio = new System.Windows.Size(16, 9);
                WMV_Format.VideoProfile.AutoFit = true;

                if (size.Width >= 1920 && size.Height >= 1080)
                {
                    WMV_Format.VideoProfile.Size = new System.Drawing.Size(1920, 1080);
                    WMV_Format.VideoProfile.Bitrate = new Microsoft.Expression.Encoder.Profiles.VariableUnconstrainedBitrate(6000);
                }
                else if (size.Width >= 1280 && size.Height >= 720)
                {
                    WMV_Format.VideoProfile.Size = new System.Drawing.Size(1280, 720);
                    WMV_Format.VideoProfile.Bitrate = new Microsoft.Expression.Encoder.Profiles.VariableUnconstrainedBitrate(4000);
                }
                else
                {
                    WMV_Format.VideoProfile.Size = new System.Drawing.Size(size.Width, size.Height);
                    WMV_Format.VideoProfile.Bitrate = new Microsoft.Expression.Encoder.Profiles.VariableUnconstrainedBitrate(2000);
                }
                mediaItem.VideoResizeMode = VideoResizeMode.Letterbox;
                mediaItem.OutputFormat = WMV_Format;
                j.MediaItems.Add(mediaItem);
                j.CreateSubfolder = false;
                j.OutputDirectory = videosOutput;
                j.EncodeProgress += new EventHandler<EncodeProgressEventArgs>(j_EncodeProgress);
                j.Encode();
            }
        }

        private void j_EncodeProgress(object sender, EncodeProgressEventArgs e)
        {
            string Status = String.Format("{0:F1}%", e.Progress);
            int progressValue = Convert.ToInt16(e.Progress);
            progressBar1.Value = progressValue;
            lblValue.Text = Status;
            if (e.CurrentPass == 2)
            {
                if (progressValue >= 100)
                {
                    lblValue.Visible = false;
                    lblStage.Visible = false;
                    label5.Visible = false;
                    label3.Text = "Encoded Successfully";
                }
                lblStage.Text = "2 Of 2";
                lblStage.Refresh();
            }

            progressBar1.Refresh();
            lblValue.Refresh();
        }

        #endregion

        #region" RegistryKey "

        private void AddRequiredRegestryKey()
        {
            var key = "SOFTWARE\\Microsoft\\Expression\\Encoder\\4.0";

            using (var registryKey = Registry.LocalMachine.OpenSubKey(key))
            {
                if (registryKey == null)
                {
                    using (var newKey = Registry.LocalMachine.CreateSubKey(key))
                    {
                        CheckInstallKey(newKey);
                    }
                }
                else
                {
                    CheckInstallKey(registryKey);
                }
            }
        }

        private void CheckInstallKey(RegistryKey registryKey)
        {
            var path = Environment.CurrentDirectory;
            var installKey = "InstallPath";

            if (registryKey != null)
            {
                string text = registryKey.GetValue(installKey) as string;
                if (string.IsNullOrEmpty(text))
                {
                    registryKey.SetValue(installKey, path);
                }
            }
        }

        #endregion

        #region " Notify Icon Codes "

        private void miPause_Resume_Click(object sender, EventArgs e)
        {
            if (job != null)
            {
                if (job.Status.ToString() == "Running")
                {
                    Pause_Resume(true);
                    miPause_Resume.Text = "Resume";
                    miPause_Resume.Image = Properties.Resources.Resume;
                }
                else
                {
                    miPause_Resume.Text = "Pause";
                    miPause_Resume.Image = Properties.Resources.Pause;
                    Pause_Resume(false);
                }

            }
        }

        private void miStop_Click(object sender, EventArgs e)
        {
            if (job != null)
            {
                StopRecording();
            }
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // checks if the job is running and if so prompts to continue
            if (job != null)
            {
                if (job.Status == RecordStatus.Running)
                {
                    DialogResult result = MessageBox.Show("Capturing in Progress. Are You Sure You Want To Quit?", "HD-Screen Recorder", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        e.Cancel = true;
                        return;
                    }
                    else
                    {
                        job.Stop();
                        job.Dispose();
                    }
                }

            }
            Properties.Settings.Default.OutputPath = OutputPath;
            Properties.Settings.Default.Save();
        }

        void StartRecording()
        {
            Rec = true;
            miPause_Resume.Enabled = true;
            miStop.Enabled = true;
            btn_RecStop.BackgroundImage = Properties.Resources.stop;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;

            StartCapturing(mic);
        }

        void StopRecording()
        {
            job.Stop();
            job.Dispose();
            Rec = false;
            miPause_Resume.Enabled = false;
            miStop.Enabled = false;
            btn_RecStop.BackgroundImage = Properties.Resources.rec;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
        }

        void Pause_Resume(bool Pause)
        {
            if (Pause)
            {
                job.Pause();
            }
            else
            {
                job.Resume();
            }
        }

        void LoadJobsList(string Path,ListView list)
        {
            list.Clear();
            if (Directory.Exists(jobOutput))
            {
                DirectoryInfo dir = new DirectoryInfo(jobOutput);
                FileInfo[] files = dir.GetFiles().OrderByDescending(p => p.CreationTime).ToArray();
                foreach (FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem(file.Name ,2);
                    item.SubItems.Add(file.FullName);
                    list.Items.Add(item);
                }
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(listView1.SelectedItems[0].SubItems[1].Text.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }     
    }
}
