﻿namespace Timer
{
    using System;
    using System.Threading;

    public class TimerDel
    {
        public delegate void TimerDlg();

        public TimerDlg SomeMethods { get; set; }
    
        private int timeInterval;
        
        public int TimeInterval
        {
            get { return this.timeInterval; }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("Interval must be >= 1");
                }
                this.timeInterval = value;
            }
        }

        public TimerDel(int seconds)
        {
            this.TimeInterval = seconds;
        }

        public void ExecuteMethods()
        {
            while (true)
            {
                this.SomeMethods();
                Thread.Sleep(this.timeInterval * 1000);   
            }
        }
    }
}
