using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopwatchSim
{
    class Stopwatch
    {
        private TimeSpan _duration;
        private DateTime _start;
        private DateTime _stop;
        private bool _isRunning;

        public Stopwatch()
        {
            _duration = new TimeSpan(0, 0, 0, 0, 0);
            _isRunning = false;
        }

        public void SetDuration()
        {
            _duration = _duration + (this.GetStop() - this.GetStart());
        }

        public TimeSpan GetDuration()
        {
            return _duration;
        }

        public void SetStart()
        {
            if (_isRunning)
                throw new InvalidOperationException("StopwatchAlreadyStartedException");

            _start = DateTime.Now;
            _isRunning = true;
        }

        public DateTime GetStart()
        {
            return _start;
        }

        public void SetStop()
        {
            if (!_isRunning)
                throw new InvalidOperationException("Stopwatch is not running");
            _stop = DateTime.Now;
            this.SetDuration();
            _isRunning = false;
        }

        public DateTime GetStop()
        {
            return _stop;
        }

        public void Reset()
        {
            _duration = new TimeSpan(0, 0, 0, 0);
            _isRunning = false;
        }
    }
}
