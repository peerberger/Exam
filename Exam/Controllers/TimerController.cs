using Exam.UserControls.TimerView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exam.Controllers
{
    class TimerController
    {
        private ITimerView _view;
        public int TimeRemaining { get; set; }
        public int timeElapsed;

        public event EventHandler TimeOver;

        public TimerController(int time, ITimerView view)
        {
            TimeRemaining = time;
            _view = view;
            timeElapsed = 0;
            InitializeView();
        }

        private void InitializeView()
        {
            _view.Tick += _view_Tick;
            SetTimeToView();
            _view.Initialize();
            _view.StartTimer();

        }
        
        private void SetTimeToView()
        {
            _view.TimeRemaining = TimeRemaining;
            _view.TimeElapsed = timeElapsed;
        }

        private void _view_Tick(object sender, EventArgs e)
        {
            TimeRemaining--;
            timeElapsed++;
            SetTimeToView();
            if (TimeRemaining == 0)
            {
                _view.StopTimer();
                TimeOver.Invoke(this, null);
            }
        }

    }
}
