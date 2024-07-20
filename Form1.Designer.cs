namespace Job_Timer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CurrentWorkTime = new System.Windows.Forms.Label();
            this.DragBorder = new System.Windows.Forms.Panel();
            this.Close_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.MinimizeToTray_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Minimize_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Job_Timer = new System.Windows.Forms.Timer(this.components);
            this.PlayTimer_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Pause_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Stop_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Repeat_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.BreakTime_Label = new System.Windows.Forms.Label();
            this.TimeStarted_Label = new System.Windows.Forms.Label();
            this.Notify_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.Denotify_Button = new Bunifu.Framework.UI.BunifuImageButton();
            this.WorkTime_ProgressBar = new Bunifu.Framework.UI.BunifuProgressBar();
            this.WorkTime_NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.CurrentWorkTime_Panel = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.Timerwatch_Panel = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.MinimizeTimer_Label = new System.Windows.Forms.Label();
            this.Rest_PictureBox = new System.Windows.Forms.PictureBox();
            this.Work_Picturebox = new System.Windows.Forms.PictureBox();
            this.StopBlurred_DisabledButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.RepeatBlurred_DisabledButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.DragBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeToTray_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayTimer_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repeat_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notify_Button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Denotify_Button)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.CurrentWorkTime_Panel.SuspendLayout();
            this.Timerwatch_Panel.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rest_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Work_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBlurred_DisabledButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatBlurred_DisabledButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time Started :";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(380, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Work Time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentWorkTime
            // 
            this.CurrentWorkTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentWorkTime.Font = new System.Drawing.Font("Century Gothic", 54.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentWorkTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.CurrentWorkTime.Location = new System.Drawing.Point(0, 0);
            this.CurrentWorkTime.Name = "CurrentWorkTime";
            this.CurrentWorkTime.Size = new System.Drawing.Size(380, 86);
            this.CurrentWorkTime.TabIndex = 3;
            this.CurrentWorkTime.Text = "00:00:00";
            this.CurrentWorkTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DragBorder
            // 
            this.DragBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(81)))), ((int)(((byte)(202)))));
            this.DragBorder.Controls.Add(this.Close_Button);
            this.DragBorder.Controls.Add(this.MinimizeToTray_Button);
            this.DragBorder.Controls.Add(this.Minimize_Button);
            this.DragBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DragBorder.ForeColor = System.Drawing.Color.Cornsilk;
            this.DragBorder.Location = new System.Drawing.Point(0, 0);
            this.DragBorder.Name = "DragBorder";
            this.DragBorder.Size = new System.Drawing.Size(400, 25);
            this.DragBorder.TabIndex = 4;
            // 
            // Close_Button
            // 
            this.Close_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_Button.BackColor = System.Drawing.Color.Transparent;
            this.Close_Button.Image = ((System.Drawing.Image)(resources.GetObject("Close_Button.Image")));
            this.Close_Button.ImageActive = null;
            this.Close_Button.Location = new System.Drawing.Point(372, 6);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(15, 15);
            this.Close_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_Button.TabIndex = 19;
            this.Close_Button.TabStop = false;
            this.toolTip1.SetToolTip(this.Close_Button, "Exit");
            this.Close_Button.Zoom = 10;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // MinimizeToTray_Button
            // 
            this.MinimizeToTray_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeToTray_Button.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeToTray_Button.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeToTray_Button.Image")));
            this.MinimizeToTray_Button.ImageActive = null;
            this.MinimizeToTray_Button.Location = new System.Drawing.Point(330, 6);
            this.MinimizeToTray_Button.Name = "MinimizeToTray_Button";
            this.MinimizeToTray_Button.Size = new System.Drawing.Size(15, 15);
            this.MinimizeToTray_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizeToTray_Button.TabIndex = 18;
            this.MinimizeToTray_Button.TabStop = false;
            this.toolTip1.SetToolTip(this.MinimizeToTray_Button, "Minimize To Tray");
            this.MinimizeToTray_Button.Zoom = 10;
            this.MinimizeToTray_Button.Click += new System.EventHandler(this.MinimizeToTray_Button_Click);
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize_Button.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_Button.Image = ((System.Drawing.Image)(resources.GetObject("Minimize_Button.Image")));
            this.Minimize_Button.ImageActive = null;
            this.Minimize_Button.Location = new System.Drawing.Point(351, 6);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(15, 15);
            this.Minimize_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize_Button.TabIndex = 17;
            this.Minimize_Button.TabStop = false;
            this.toolTip1.SetToolTip(this.Minimize_Button, "Minimize ");
            this.Minimize_Button.Zoom = 10;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Job_Timer
            // 
            this.Job_Timer.Interval = 1000;
            this.Job_Timer.Tick += new System.EventHandler(this.Job_Timer_Tick);
            // 
            // PlayTimer_Button
            // 
            this.PlayTimer_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PlayTimer_Button.BackColor = System.Drawing.Color.Transparent;
            this.PlayTimer_Button.Image = ((System.Drawing.Image)(resources.GetObject("PlayTimer_Button.Image")));
            this.PlayTimer_Button.ImageActive = null;
            this.PlayTimer_Button.Location = new System.Drawing.Point(6, 3);
            this.PlayTimer_Button.Name = "PlayTimer_Button";
            this.PlayTimer_Button.Size = new System.Drawing.Size(30, 30);
            this.PlayTimer_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PlayTimer_Button.TabIndex = 5;
            this.PlayTimer_Button.TabStop = false;
            this.toolTip1.SetToolTip(this.PlayTimer_Button, "Resume");
            this.PlayTimer_Button.Zoom = 10;
            this.PlayTimer_Button.Click += new System.EventHandler(this.PlayTimer_Button_Click);
            // 
            // Pause_Button
            // 
            this.Pause_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Pause_Button.BackColor = System.Drawing.Color.Transparent;
            this.Pause_Button.Image = ((System.Drawing.Image)(resources.GetObject("Pause_Button.Image")));
            this.Pause_Button.ImageActive = null;
            this.Pause_Button.Location = new System.Drawing.Point(6, 3);
            this.Pause_Button.Name = "Pause_Button";
            this.Pause_Button.Size = new System.Drawing.Size(30, 30);
            this.Pause_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pause_Button.TabIndex = 6;
            this.Pause_Button.TabStop = false;
            this.toolTip1.SetToolTip(this.Pause_Button, "Pause");
            this.Pause_Button.Zoom = 10;
            this.Pause_Button.Click += new System.EventHandler(this.Pause_Button_Click);
            // 
            // Stop_Button
            // 
            this.Stop_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Stop_Button.BackColor = System.Drawing.Color.Transparent;
            this.Stop_Button.Image = ((System.Drawing.Image)(resources.GetObject("Stop_Button.Image")));
            this.Stop_Button.ImageActive = null;
            this.Stop_Button.Location = new System.Drawing.Point(78, 3);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(30, 30);
            this.Stop_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Stop_Button.TabIndex = 7;
            this.Stop_Button.TabStop = false;
            this.Stop_Button.Visible = false;
            this.Stop_Button.Zoom = 10;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Repeat_Button
            // 
            this.Repeat_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Repeat_Button.BackColor = System.Drawing.Color.Transparent;
            this.Repeat_Button.Image = ((System.Drawing.Image)(resources.GetObject("Repeat_Button.Image")));
            this.Repeat_Button.ImageActive = null;
            this.Repeat_Button.Location = new System.Drawing.Point(42, 3);
            this.Repeat_Button.Name = "Repeat_Button";
            this.Repeat_Button.Size = new System.Drawing.Size(30, 30);
            this.Repeat_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Repeat_Button.TabIndex = 8;
            this.Repeat_Button.TabStop = false;
            this.toolTip1.SetToolTip(this.Repeat_Button, "Restart");
            this.Repeat_Button.Visible = false;
            this.Repeat_Button.Zoom = 10;
            this.Repeat_Button.Click += new System.EventHandler(this.Repeat_Button_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.DragBorder;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total Break Time :";
            // 
            // BreakTime_Label
            // 
            this.BreakTime_Label.AutoSize = true;
            this.BreakTime_Label.Dock = System.Windows.Forms.DockStyle.Right;
            this.BreakTime_Label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BreakTime_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(159)))), ((int)(((byte)(91)))));
            this.BreakTime_Label.Location = new System.Drawing.Point(4, 0);
            this.BreakTime_Label.Name = "BreakTime_Label";
            this.BreakTime_Label.Size = new System.Drawing.Size(56, 16);
            this.BreakTime_Label.TabIndex = 11;
            this.BreakTime_Label.Text = "00:00:00";
            this.BreakTime_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeStarted_Label
            // 
            this.TimeStarted_Label.AutoSize = true;
            this.TimeStarted_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.TimeStarted_Label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStarted_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(159)))), ((int)(((byte)(91)))));
            this.TimeStarted_Label.Location = new System.Drawing.Point(0, 0);
            this.TimeStarted_Label.Name = "TimeStarted_Label";
            this.TimeStarted_Label.Size = new System.Drawing.Size(75, 16);
            this.TimeStarted_Label.TabIndex = 12;
            this.TimeStarted_Label.Text = "00:00:00 XX";
            this.TimeStarted_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Notify_Button
            // 
            this.Notify_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Notify_Button.BackColor = System.Drawing.Color.Transparent;
            this.Notify_Button.Image = ((System.Drawing.Image)(resources.GetObject("Notify_Button.Image")));
            this.Notify_Button.ImageActive = null;
            this.Notify_Button.Location = new System.Drawing.Point(6, 3);
            this.Notify_Button.Name = "Notify_Button";
            this.Notify_Button.Size = new System.Drawing.Size(30, 30);
            this.Notify_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Notify_Button.TabIndex = 13;
            this.Notify_Button.TabStop = false;
            this.toolTip1.SetToolTip(this.Notify_Button, "Alarm Mode : Off");
            this.Notify_Button.Zoom = 10;
            this.Notify_Button.Click += new System.EventHandler(this.Notify_Button_Click);
            // 
            // Denotify_Button
            // 
            this.Denotify_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Denotify_Button.BackColor = System.Drawing.Color.Transparent;
            this.Denotify_Button.Image = ((System.Drawing.Image)(resources.GetObject("Denotify_Button.Image")));
            this.Denotify_Button.ImageActive = null;
            this.Denotify_Button.Location = new System.Drawing.Point(6, 3);
            this.Denotify_Button.Name = "Denotify_Button";
            this.Denotify_Button.Size = new System.Drawing.Size(30, 30);
            this.Denotify_Button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Denotify_Button.TabIndex = 14;
            this.Denotify_Button.TabStop = false;
            this.toolTip1.SetToolTip(this.Denotify_Button, "Alarm Mode : On");
            this.Denotify_Button.Zoom = 10;
            this.Denotify_Button.Click += new System.EventHandler(this.Denotify_Button_Click);
            // 
            // WorkTime_ProgressBar
            // 
            this.WorkTime_ProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(54)))), ((int)(((byte)(128)))));
            this.WorkTime_ProgressBar.BorderRadius = 5;
            this.WorkTime_ProgressBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkTime_ProgressBar.Location = new System.Drawing.Point(0, 0);
            this.WorkTime_ProgressBar.MaximumValue = 28800;
            this.WorkTime_ProgressBar.Name = "WorkTime_ProgressBar";
            this.WorkTime_ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.WorkTime_ProgressBar.Size = new System.Drawing.Size(380, 10);
            this.WorkTime_ProgressBar.TabIndex = 16;
            this.WorkTime_ProgressBar.Value = 0;
            // 
            // WorkTime_NotifyIcon
            // 
            this.WorkTime_NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("WorkTime_NotifyIcon.Icon")));
            this.WorkTime_NotifyIcon.Text = "Work Timer";
            this.WorkTime_NotifyIcon.Visible = true;
            this.WorkTime_NotifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.WorkTime_NotifyIcon_MouseDoubleClick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(136)))), ((int)(((byte)(243)))));
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.toolTip1_Draw);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 215);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(390, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 215);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DragBorder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 25);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 26);
            this.panel4.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(380, 5);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(90, 21);
            this.panel6.TabIndex = 19;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TimeStarted_Label);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(90, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(79, 21);
            this.panel7.TabIndex = 20;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.BreakTime_Label);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(320, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(60, 21);
            this.panel8.TabIndex = 21;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.label1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(209, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(111, 21);
            this.panel9.TabIndex = 22;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(10, 51);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(380, 5);
            this.panel10.TabIndex = 21;
            // 
            // CurrentWorkTime_Panel
            // 
            this.CurrentWorkTime_Panel.Controls.Add(this.label3);
            this.CurrentWorkTime_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CurrentWorkTime_Panel.Location = new System.Drawing.Point(10, 56);
            this.CurrentWorkTime_Panel.Name = "CurrentWorkTime_Panel";
            this.CurrentWorkTime_Panel.Size = new System.Drawing.Size(380, 35);
            this.CurrentWorkTime_Panel.TabIndex = 22;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(10, 91);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(380, 5);
            this.panel12.TabIndex = 23;
            // 
            // Timerwatch_Panel
            // 
            this.Timerwatch_Panel.Controls.Add(this.CurrentWorkTime);
            this.Timerwatch_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Timerwatch_Panel.Location = new System.Drawing.Point(10, 96);
            this.Timerwatch_Panel.Name = "Timerwatch_Panel";
            this.Timerwatch_Panel.Size = new System.Drawing.Size(380, 86);
            this.Timerwatch_Panel.TabIndex = 24;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.WorkTime_ProgressBar);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(10, 182);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(380, 12);
            this.panel11.TabIndex = 25;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel13.Location = new System.Drawing.Point(10, 194);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(380, 5);
            this.panel13.TabIndex = 26;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(10, 198);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(380, 42);
            this.panel14.TabIndex = 27;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.StopBlurred_DisabledButton);
            this.panel15.Controls.Add(this.RepeatBlurred_DisabledButton);
            this.panel15.Controls.Add(this.Stop_Button);
            this.panel15.Controls.Add(this.PlayTimer_Button);
            this.panel15.Controls.Add(this.Repeat_Button);
            this.panel15.Controls.Add(this.Pause_Button);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(118, 42);
            this.panel15.TabIndex = 18;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.MinimizeTimer_Label);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(118, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(223, 42);
            this.panel16.TabIndex = 19;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.Notify_Button);
            this.panel17.Controls.Add(this.Rest_PictureBox);
            this.panel17.Controls.Add(this.Work_Picturebox);
            this.panel17.Controls.Add(this.Denotify_Button);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(341, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(39, 42);
            this.panel17.TabIndex = 20;
            // 
            // MinimizeTimer_Label
            // 
            this.MinimizeTimer_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinimizeTimer_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeTimer_Label.Location = new System.Drawing.Point(0, 0);
            this.MinimizeTimer_Label.Name = "MinimizeTimer_Label";
            this.MinimizeTimer_Label.Size = new System.Drawing.Size(223, 42);
            this.MinimizeTimer_Label.TabIndex = 4;
            this.MinimizeTimer_Label.Text = "00:00:00";
            this.MinimizeTimer_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimizeTimer_Label.Visible = false;
            this.MinimizeTimer_Label.Click += new System.EventHandler(this.MinimizeTimer_Label_Click);
            // 
            // Rest_PictureBox
            // 
            this.Rest_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Rest_PictureBox.Image")));
            this.Rest_PictureBox.Location = new System.Drawing.Point(6, 3);
            this.Rest_PictureBox.Name = "Rest_PictureBox";
            this.Rest_PictureBox.Size = new System.Drawing.Size(30, 30);
            this.Rest_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rest_PictureBox.TabIndex = 4;
            this.Rest_PictureBox.TabStop = false;
            this.toolTip1.SetToolTip(this.Rest_PictureBox, "Currently On Break");
            this.Rest_PictureBox.Visible = false;
            // 
            // Work_Picturebox
            // 
            this.Work_Picturebox.Image = ((System.Drawing.Image)(resources.GetObject("Work_Picturebox.Image")));
            this.Work_Picturebox.Location = new System.Drawing.Point(6, 3);
            this.Work_Picturebox.Name = "Work_Picturebox";
            this.Work_Picturebox.Size = new System.Drawing.Size(30, 30);
            this.Work_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Work_Picturebox.TabIndex = 9;
            this.Work_Picturebox.TabStop = false;
            this.toolTip1.SetToolTip(this.Work_Picturebox, "Currently Working");
            this.Work_Picturebox.Visible = false;
            // 
            // StopBlurred_DisabledButton
            // 
            this.StopBlurred_DisabledButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StopBlurred_DisabledButton.BackColor = System.Drawing.Color.Transparent;
            this.StopBlurred_DisabledButton.Enabled = false;
            this.StopBlurred_DisabledButton.Image = ((System.Drawing.Image)(resources.GetObject("StopBlurred_DisabledButton.Image")));
            this.StopBlurred_DisabledButton.ImageActive = null;
            this.StopBlurred_DisabledButton.Location = new System.Drawing.Point(78, 3);
            this.StopBlurred_DisabledButton.Name = "StopBlurred_DisabledButton";
            this.StopBlurred_DisabledButton.Size = new System.Drawing.Size(30, 30);
            this.StopBlurred_DisabledButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StopBlurred_DisabledButton.TabIndex = 8;
            this.StopBlurred_DisabledButton.TabStop = false;
            this.StopBlurred_DisabledButton.Zoom = 10;
            // 
            // RepeatBlurred_DisabledButton
            // 
            this.RepeatBlurred_DisabledButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RepeatBlurred_DisabledButton.BackColor = System.Drawing.Color.Transparent;
            this.RepeatBlurred_DisabledButton.Enabled = false;
            this.RepeatBlurred_DisabledButton.Image = ((System.Drawing.Image)(resources.GetObject("RepeatBlurred_DisabledButton.Image")));
            this.RepeatBlurred_DisabledButton.ImageActive = null;
            this.RepeatBlurred_DisabledButton.Location = new System.Drawing.Point(42, 3);
            this.RepeatBlurred_DisabledButton.Name = "RepeatBlurred_DisabledButton";
            this.RepeatBlurred_DisabledButton.Size = new System.Drawing.Size(30, 30);
            this.RepeatBlurred_DisabledButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RepeatBlurred_DisabledButton.TabIndex = 9;
            this.RepeatBlurred_DisabledButton.TabStop = false;
            this.RepeatBlurred_DisabledButton.Zoom = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.panel14);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.Timerwatch_Panel);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.CurrentWorkTime_Panel);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.DragBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Close_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeToTray_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayTimer_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pause_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stop_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Repeat_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Notify_Button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Denotify_Button)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.CurrentWorkTime_Panel.ResumeLayout(false);
            this.Timerwatch_Panel.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Rest_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Work_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StopBlurred_DisabledButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatBlurred_DisabledButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel DragBorder;
        private System.Windows.Forms.Label CurrentWorkTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Job_Timer;
        private Bunifu.Framework.UI.BunifuImageButton PlayTimer_Button;
        private Bunifu.Framework.UI.BunifuImageButton Repeat_Button;
        private Bunifu.Framework.UI.BunifuImageButton Stop_Button;
        private Bunifu.Framework.UI.BunifuImageButton Pause_Button;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label TimeStarted_Label;
        private System.Windows.Forms.Label BreakTime_Label;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton Denotify_Button;
        private Bunifu.Framework.UI.BunifuImageButton Notify_Button;
        private Bunifu.Framework.UI.BunifuProgressBar WorkTime_ProgressBar;
        private Bunifu.Framework.UI.BunifuImageButton Minimize_Button;
        private System.Windows.Forms.NotifyIcon WorkTime_NotifyIcon;
        private Bunifu.Framework.UI.BunifuImageButton Close_Button;
        private Bunifu.Framework.UI.BunifuImageButton MinimizeToTray_Button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel Timerwatch_Panel;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel CurrentWorkTime_Panel;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label MinimizeTimer_Label;
        private System.Windows.Forms.PictureBox Work_Picturebox;
        private System.Windows.Forms.PictureBox Rest_PictureBox;
        private Bunifu.Framework.UI.BunifuImageButton StopBlurred_DisabledButton;
        private Bunifu.Framework.UI.BunifuImageButton RepeatBlurred_DisabledButton;
    }
}

