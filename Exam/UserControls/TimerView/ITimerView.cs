using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.UserControls.TimerView
{
    public interface ITimerView
    {
        //int Time { get; set; }
        int TimeElapsed { get; set; }
        int TimeRemaining { get; set; }
        event EventHandler Tick;
        void StartTimer();
        void StopTimer();
        void Initialize();

    }
}
