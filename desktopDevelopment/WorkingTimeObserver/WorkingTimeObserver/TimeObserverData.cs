using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;

namespace WorkingTimeObserver
{
    public delegate void BreakStartedEventHandler(object sender, BreakStartedEventArgs e);

    public delegate void BreakEndedEventHandler(object sender, BreakEndedEventArgs e);

    //*************************************************************************

    public abstract class BreakBaseEventArgs : EventArgs
    {
        protected Break breakData;
        protected DateTime timestamp;

        public string Name
        {
            get { return this.breakData.Name; }
        }

        public DateTime Timestamp
        {
            get { return this.timestamp; }
        }

        public BreakBaseEventArgs(Break breakData)
        {
            this.timestamp = DateTime.Now;
            this.breakData = breakData;
        }
    }

    //*************************************************************************

    public class BreakStartedEventArgs : BreakBaseEventArgs
    {
        public BreakStartedEventArgs(Break breakData)
            : base(breakData)
        {
        }
    }

    //*************************************************************************

    public sealed class BreakEndedEventArgs : BreakBaseEventArgs
    {
        public BreakEndedEventArgs(Break breakData)
            : base(breakData)
        {
        }
    }
    
    //*************************************************************************

    public sealed class TimeObserverData : IDisposable
    {
        #region data_fields

        private readonly object syncRoot;
        private TimeSpan currentTime;
        private readonly TimeSpan dailyWorkingHours;
        private TimeSpan startWorkingTime;
        private TimeSpan scheduledFinishWorkingTime;
        private TimeSpan actualFinishWorkingTime;
        private List<Break> breaksList;
        private readonly Timer updateTimer;
        private bool disposed;

        public event BreakStartedEventHandler BreakStarted;
        public event BreakEndedEventHandler BreakEnded;
                
        #endregion data_fields

        //=========================================================================

        #region properties

        public TimeSpan CurrentTime
        {
            get { return this.currentTime; }
        }

        //-----------------------------------------

        public TimeSpan StartWorkingTime
        {
            get { return this.startWorkingTime; }
        }

        //-----------------------------------------

        public TimeSpan ScheduledFinishWorkingTime
        {
            get { return this.scheduledFinishWorkingTime; }
        }

        //-----------------------------------------

        public Break[] Breaks
        {
            get { return this.breaksList.ToArray(); }
        }

        #endregion properties

        //=========================================================================

        #region constructors

        private TimeObserverData(TimeSpan startWorkingTime)
        {
            this.disposed = false;
            this.startWorkingTime = startWorkingTime;
            this.dailyWorkingHours = new TimeSpan(8,0,0); 
            this.syncRoot = new object();            
            this.startWorkingTime = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            this.updateTimer = new Timer(this.PollBreakConditionsThread, null, 1000, 1000);          
        }

        //-----------------------------------------

        public TimeObserverData(TimeSpan startWorkingTime, Break[] breaks) 
            : this(startWorkingTime)
        {
            this.breaksList = new List<Break>();
            this.breaksList.AddRange(breaks);
            TimeSpan overallBreaksDuration = new TimeSpan();
            this.breaksList.ForEach(
                delegate(Break b)
                {
                    overallBreaksDuration += b.Duration;
                });
            this.scheduledFinishWorkingTime = this.startWorkingTime + this.dailyWorkingHours + overallBreaksDuration;             
        }  

        //-----------------------------------------        

        #endregion constructors

        //=========================================================================

        #region destructor

        ~TimeObserverData()
        {
            this.Dispose();
        }

        #endregion destructor

        //=========================================================================

        #region IDisposable

        public void Dispose()
        {
            if (this.disposed)
                return;

            try
            {
                this.updateTimer.Dispose();
                this.breaksList.Clear();
                this.breaksList = null;
            }
            finally
            {
                this.disposed = true;
            }
        }

        #endregion IDisposable

        //=========================================================================

        #region event_methods

        private void OnBreakStarted(BreakStartedEventArgs e)
        {
            if (this.BreakStarted != null)
                this.BreakStarted(this, e);
        }

        //-----------------------------------------    

        private void OnBreakEnded(BreakEndedEventArgs e)
        {
            if (this.BreakEnded != null)
                this.BreakEnded(this, e);
        }

        #endregion

        //=========================================================================

        #region methods

        private void PollBreakConditionsThread(object state)
        {
            this.currentTime = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, 0);
            
            for (int i = 0; i < this.breaksList.Count; i++)
            {
                if (this.breaksList[i].CanSetStartSignal)
                {
                    Debug.WriteLine(string.Format("BREAK_STARTED: Name: {0}; IsBreakDone: {1};", 
                        this.breaksList[i].Name, 
                        this.breaksList[i].IsBreakDone));
                    this.OnBreakStarted(new BreakStartedEventArgs(this.breaksList[i]));
                }

                if (this.breaksList[i].CanSetStopSignal)
                {
                    Debug.WriteLine(string.Format("BREAK_ENDED: Name: {0}; IsBreakDone: {1};",
                        this.breaksList[i].Name,
                        this.breaksList[i].IsBreakDone));
                    this.OnBreakEnded(new BreakEndedEventArgs(this.breaksList[i]));
                }                        
            }
        }    

        #endregion methods
    }
}