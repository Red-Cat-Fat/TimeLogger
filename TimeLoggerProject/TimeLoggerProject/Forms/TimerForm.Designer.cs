namespace TimeLoggerProject
{
	partial class TimerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
			this.TimerLabel = new System.Windows.Forms.Label();
			this.ButtonPanel = new System.Windows.Forms.Panel();
			this.ButtonPause = new System.Windows.Forms.Button();
			this.ButtonStop = new System.Windows.Forms.Button();
			this.ButtonStart = new System.Windows.Forms.Button();
			this.MainTimer = new System.Windows.Forms.Timer(this.components);
			this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.ButtonPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// TimerLabel
			// 
			this.TimerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TimerLabel.AutoSize = true;
			this.TimerLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.TimerLabel.Location = new System.Drawing.Point(1, 9);
			this.TimerLabel.Name = "TimerLabel";
			this.TimerLabel.Size = new System.Drawing.Size(212, 55);
			this.TimerLabel.TabIndex = 0;
			this.TimerLabel.Text = "00:00:00";
			this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ButtonPanel
			// 
			this.ButtonPanel.Controls.Add(this.ButtonPause);
			this.ButtonPanel.Controls.Add(this.ButtonStop);
			this.ButtonPanel.Controls.Add(this.ButtonStart);
			this.ButtonPanel.Dock = System.Windows.Forms.DockStyle.Right;
			this.ButtonPanel.Location = new System.Drawing.Point(211, 0);
			this.ButtonPanel.Name = "ButtonPanel";
			this.ButtonPanel.Size = new System.Drawing.Size(97, 71);
			this.ButtonPanel.TabIndex = 2;
			// 
			// ButtonPause
			// 
			this.ButtonPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonPause.Location = new System.Drawing.Point(0, 23);
			this.ButtonPause.Name = "ButtonPause";
			this.ButtonPause.Size = new System.Drawing.Size(94, 23);
			this.ButtonPause.TabIndex = 2;
			this.ButtonPause.Text = "Pause";
			this.ButtonPause.UseVisualStyleBackColor = true;
			this.ButtonPause.Click += new System.EventHandler(this.ButtonPauseClick);
			// 
			// ButtonStop
			// 
			this.ButtonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonStop.Location = new System.Drawing.Point(0, 44);
			this.ButtonStop.Name = "ButtonStop";
			this.ButtonStop.Size = new System.Drawing.Size(94, 23);
			this.ButtonStop.TabIndex = 1;
			this.ButtonStop.Text = "Stop";
			this.ButtonStop.UseVisualStyleBackColor = true;
			this.ButtonStop.Click += new System.EventHandler(this.ButtonStopClick);
			// 
			// ButtonStart
			// 
			this.ButtonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ButtonStart.Location = new System.Drawing.Point(0, 2);
			this.ButtonStart.Name = "ButtonStart";
			this.ButtonStart.Size = new System.Drawing.Size(94, 23);
			this.ButtonStart.TabIndex = 0;
			this.ButtonStart.Text = "Start";
			this.ButtonStart.UseVisualStyleBackColor = true;
			this.ButtonStart.Click += new System.EventHandler(this.ButtonStartClick);
			// 
			// MainTimer
			// 
			this.MainTimer.Enabled = true;
			this.MainTimer.Interval = 10;
			this.MainTimer.Tick += new System.EventHandler(this.MainTimerTick);
			// 
			// NotifyIcon
			// 
			this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
			this.NotifyIcon.Text = "Time Logger";
			this.NotifyIcon.Visible = true;
			this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIconMouseClick);
			// 
			// TimerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 71);
			this.Controls.Add(this.ButtonPanel);
			this.Controls.Add(this.TimerLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TimerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Time Logger";
			this.SizeChanged += new System.EventHandler(this.FormResize);
			this.ButtonPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TimerLabel;
		private System.Windows.Forms.Panel ButtonPanel;
		private System.Windows.Forms.Button ButtonStop;
		private System.Windows.Forms.Button ButtonStart;
		private System.Windows.Forms.Timer MainTimer;
		private System.Windows.Forms.Button ButtonPause;
		private System.Windows.Forms.NotifyIcon NotifyIcon;
	}
}