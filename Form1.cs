using System;
using System.Drawing;
using System.Windows.Forms;

namespace Job_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();

            toolTip1.OwnerDraw = true;
            toolTip1.BackColor = Color.Black;
        }

        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void WorkTime_NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            WorkTime_NotifyIcon.Visible = false;
        }

        //-----------------------------------------------------------------------------------
        bool isMinimized = false;
        
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void MinimizeToTray_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            WorkTime_NotifyIcon.Visible = true;
            this.ShowInTaskbar = false;
        }
        private void Minimize_Button_Click(object sender, EventArgs e)
        {
            isMinimized = true;

            // Resizing Form
            this.Size = new Size(300, 45);

            // Recoloring Specific controls
            DragBorder.BackColor = Color.Transparent;
            MinimizeTimer_Label.ForeColor = has_Resumed ? Color.FromArgb(187, 136, 243) : Color.FromArgb(247, 159, 91);

            // Hiding and Showing controls
            MinimizeTimer_Label.Visible = true;
            Work_Picturebox.Visible = true;
            Rest_PictureBox.Visible = true;
            Denotify_Button.Visible = false;
            Notify_Button.Visible = false;

            // Work or Rest
            if (has_Resumed) Work_Picturebox.BringToFront();
            if (has_Paused) Rest_PictureBox.BringToFront();

            // Setting Working Area to Bottom Right
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width, workingArea.Bottom - Size.Height);
            this.TopMost = true;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            ResizingForm();
        }
        private void MinimizeTimer_Label_Click(object sender, EventArgs e)
        {
            ResizingForm();
        }

        private void ResizingForm()
        {
            if (isMinimized)
            {
                isMinimized = false;

                // Resizing Form
                this.Size = new Size(400, 240);

                // Recoloring Specific controls
                DragBorder.BackColor = Color.FromArgb(141, 81, 202);

                // Hiding and Showing controls
                MinimizeTimer_Label.Visible = false;
                Work_Picturebox.Visible = false;
                Rest_PictureBox.Visible = false;
                Denotify_Button.Visible = true;
                Notify_Button.Visible = true;

                // Work or Rest
                if (is_Notified) Notify_Button.BringToFront();
                else Denotify_Button.BringToFront();

                // Setting Working Area to Bottom Right
                this.CenterToScreen();
                this.TopMost = false;
            }
        }

        //-------------------------------------------------------------------------------------
        int work_seconds = 0;
        int break_seconds = 0;
        bool has_Started = false;
        bool has_Resumed = false;
        bool has_Paused = true;
       
        private void Job_Timer_Tick(object sender, EventArgs e)
        {
            if(has_Resumed)
            {
                work_seconds++;
                TimeSpan time = TimeSpan.FromSeconds(work_seconds);
                WorkTime_ProgressBar.Value = work_seconds;

                if (!isMinimized) CurrentWorkTime.Text = time.ToString(@"hh\:mm\:ss");
                else MinimizeTimer_Label.Text = time.ToString(@"hh\:mm\:ss");

                if (is_Notified)
                {

                }
            }

            if(has_Paused)
            {
                break_seconds++;
                TimeSpan time = TimeSpan.FromSeconds(break_seconds);

                if (!isMinimized) BreakTime_Label.Text = time.ToString(@"hh\:mm\:ss");
                else MinimizeTimer_Label.Text = time.ToString(@"hh\:mm\:ss");

                if (is_Notified)
                {

                }
            }
        }

        private void PlayTimer_Button_Click(object sender, EventArgs e)
        {
            Job_Timer.Enabled = true;

            if(!has_Started)
            {
                TimeStarted_Label.Text = DateTime.Now.ToString("h:mm:ss tt");

                Stop_Button.Visible = true;
                Stop_Button.BringToFront();
                Repeat_Button.Visible = true;
                Repeat_Button.BringToFront();
            }
            
            has_Started = true;
            has_Resumed = true;
            has_Paused = false;

            Pause_Button.Visible = true;
            Pause_Button.BringToFront();
            PlayTimer_Button.Visible = false;

            if (isMinimized)
            {
                MinimizeTimer_Label.ForeColor = Color.FromArgb(187, 136, 243);
                Work_Picturebox.BringToFront();
            }
        }
        private void Pause_Button_Click(object sender, EventArgs e)
        {
            Job_Timer.Enabled = true;

            has_Started = true;
            has_Resumed = false;
            has_Paused = true;

            PlayTimer_Button.Visible = true;
            PlayTimer_Button.BringToFront();
            Pause_Button.Visible = false;

            if (isMinimized)
            {
                MinimizeTimer_Label.ForeColor = Color.FromArgb(247, 159, 91);
                Rest_PictureBox.BringToFront();
            }   
        }

        //---------------------------------------------------------------------------------
        bool is_Notified = false;

        private void Notify_Button_Click(object sender, EventArgs e)
        {
            Denotify_Button.Visible = true;
            Denotify_Button.BringToFront();
            is_Notified = true;
            Notify_Button.Visible = false;
        }
        private void Denotify_Button_Click(object sender, EventArgs e)
        {
            Notify_Button.Visible = true;
            Notify_Button.BringToFront();
            is_Notified = false;
            Denotify_Button.Visible = false;
        }

        private void Repeat_Button_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Button_Click(object sender, EventArgs e)
        {
            Job_Timer.Enabled = false;
            has_Started = false;
            has_Resumed = false;
            has_Paused = true;

            work_seconds = 0;
            break_seconds = 0;
            
            CurrentWorkTime.Text = "00:00:00";
            BreakTime_Label.Text = "00:00:00";
            MinimizeTimer_Label.Text = "00:00:00";
            
            PlayTimer_Button.BringToFront();

            RepeatBlurred_DisabledButton.BringToFront();
            StopBlurred_DisabledButton.BringToFront();
            Repeat_Button.Visible = false;
            Stop_Button.Visible = false;

           
        }
    }
}
