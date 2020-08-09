using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.UserControls.TimerView;

namespace Exam
{
    public partial class TimeBarUC : UserControl, ITimerView
    {
        Timer examTimer;
        private int timeElapsed;
        private int timeRemaining;
        public int TimeElapsed
        {
            get { return timeElapsed; }
            set
            {
                TimeElapsedLbl.Text = TimeIntToString(value);
                timeElapsed = value;
            }
        }
        public int TimeRemaining
        {
            get { return timeRemaining; }
            set
            {
                TimeRemainingLbl.Text = TimeIntToString(value);
                timeRemaining = value;
            }
        }

        private EventHandler tick;
        public event EventHandler Tick
        {
            add { tick += value; }
            remove { tick -= value; }
        }

        public TimeBarUC()
        {
            InitializeComponent();
        }
        public void Initialize()
        {
            InitializeTimer();
            InitializeProgressBar();
            this.TimeElapsed = 0;

        }
        private void InitializeTimer()
        {
            examTimer = new Timer();
            examTimer.Interval = 1000;
            examTimer.Enabled = false;
            examTimer.Tick += ExamTimer_Tick;
        }
        private void InitializeProgressBar()
        {
            this.TimeProgressBar.Minimum = 0;
            this.TimeProgressBar.Maximum = timeRemaining;
            this.TimeProgressBar.Value = timeRemaining;
            this.TimeProgressBar.Visible = true;
            TimeProgressBar.Step = -1;
        }

        private void ExamTimer_Tick(object sender, EventArgs e)
        {
            TimeProgressBar.PerformStep();
            tick.Invoke(sender, e);
        }

        public void StartTimer()
        {
            examTimer.Enabled = true;
        }

        public void StopTimer()
        {
            examTimer.Enabled = false;
        }

        private string TimeIntToString(int time)
        {
            int hours = time / 3600;
            int minutes = (time-(hours*3600)) / 60;
            int seconds = time % 60;
            return $"{hours.ToString("00")}:{minutes.ToString("00")}:{seconds.ToString("00")}";
        }
    }
}
