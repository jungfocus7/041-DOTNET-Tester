using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace TesterDXApplication71.Tools
{
    public static class TimerTool
    {
        static TimerTool()
        {
            _timer = new Timer();
            _timer.Tick += prTimerTick;
        }
        private static readonly Timer _timer;
        private static void prTimerTick(object sd, EventArgs ea)
        {
            _cbf?.Invoke();
            ClearCall();
        }

        private static Action _cbf;
        public static void ClearCall()
        {
            if (_cbf == null) return;
            _timer.Stop();
            _cbf = null;            
        }
        public static void DelayCall(Action cbf, int time = 3000)
        {
            ClearCall();
            _cbf = cbf;
            _timer.Interval = time;
            _timer.Start();
        }
    }
}
