using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeLoggerProject
{
	public partial class TimerForm : Form
	{
		private Stopwatch _stopwatch;
		public TimerForm(Stopwatch mainStopwatch)
		{
			TopMost = true;
			ShowInTaskbar = false;
			InitializeComponent();
			_stopwatch = mainStopwatch;
		}

		private void ButtonStartClick(object sender, EventArgs e)
		{
			Text = "Work in progress";
			_stopwatch.Start();
		}

		private void ButtonPauseClick(object sender, EventArgs e)
		{
			Text = "Work in pause";
			_stopwatch.Stop();
			UpdateTime();
		}

		private void ButtonStopClick(object sender, EventArgs e)
		{
			Text = "Work is stopped";
			_stopwatch.Reset();
			UpdateTime();
		}

		private void UpdateTime()
		{
			var ts = _stopwatch.Elapsed;
			var elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}";
			TimerLabel.Text = elapsedTime;
		}

		private void MainTimerTick(object sender, EventArgs e)
		{
			UpdateTime();
		}

	}
}
