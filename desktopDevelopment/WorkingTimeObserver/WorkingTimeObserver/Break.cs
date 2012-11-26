using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingTimeObserver
{    
    public sealed class Break : IDisposable, WorkingTimeObserver.IBreak
    {
        #region data_fields

        private string name;
        private TimeSpan startTime;
        private bool startSignalWasSet;
        private TimeSpan endTime;
        private bool endSignalWasSet;
        private TimeSpan duration;
        private readonly TimeSpan signalTimeslotMax;
        private readonly TimeSpan signalTimeslotMin;
        private readonly object syncRoot;
        private bool disposed;
        
        #endregion data_fields

        //=========================================================================

        #region properties

        public string Name
        {
            get { return this.name; }
        }
        
        //-----------------------------------------

        public TimeSpan StartTime
        {
            get { return this.startTime; }
        }

        //-----------------------------------------

        public TimeSpan EndTime
        {
            get { return this.endTime; }
        }

        //-----------------------------------------

        public bool IsBreakDone
        {
            get { return (this.endTime <= DateTime.Now.TimeOfDay) && this.endSignalWasSet; }
        }

        //-----------------------------------------

        public TimeSpan Duration
        {
            get { return this.duration; }
        }

        //-----------------------------------------

        public bool CanSetStartSignal
        {
            get 
            {
                lock (this.syncRoot)
                {
                    if (IsBreakDone || this.startSignalWasSet)
                        return false;

                    TimeSpan timeDifference = DateTime.Now.TimeOfDay - this.startTime;
                    bool startTimeslotActive = (timeDifference >= signalTimeslotMin) && (timeDifference <= signalTimeslotMax);
                    if (startTimeslotActive)
                        this.startSignalWasSet = true;

                    return this.startSignalWasSet;  
                }                              
            }
        }

        //-----------------------------------------

        public bool CanSetStopSignal
        {
            get
            {
                lock (this.syncRoot)
                {
                    if (this.endSignalWasSet || IsBreakDone)
                        return false;

                    TimeSpan timeDifference = DateTime.Now.TimeOfDay - this.endTime;
                    bool endTimeslotActive = (timeDifference >= signalTimeslotMin) && (timeDifference <= signalTimeslotMax);
                    if (endTimeslotActive)
                        this.endSignalWasSet = true;

                    return this.endSignalWasSet;    
                }                            
            }
        }

        //-----------------------------------------

        #endregion properties

        //=========================================================================

        #region constructors

        public Break(string name, TimeSpan startTime, TimeSpan endTime)
        {
            this.syncRoot = name;
            this.startSignalWasSet = false;
            this.endSignalWasSet = false;
            this.name = name;
            this.startTime = startTime;
            this.endTime = endTime;
            this.duration = this.endTime - this.startTime;
            this.signalTimeslotMin = new TimeSpan(0, 0, 0);
            this.signalTimeslotMax = new TimeSpan(0, 0, 59);
            this.disposed = false;
        }

        //-----------------------------------------

        #endregion contructors

        //=========================================================================

        #region destructors

        ~Break()
        {
            if (this.disposed)
                return;

            this.Dispose();
        }

        #endregion

        //=========================================================================

        #region operators

        public static TimeSpan operator+(Break summand1, Break summand2)
        {
            return summand1.Duration + summand2.Duration;
        }

        //-----------------------------------------

        public static TimeSpan operator-(Break minuend, Break subtrahend)
        {
            return minuend.Duration - subtrahend.Duration;
        }

        //-----------------------------------------

        #endregion operators

        //=========================================================================

        #region IDisposable

        public void Dispose()
        {
            throw new NotImplementedException("The method Dispose() of the interface IDisposable is not implemented yet.");
        }

        #endregion IDisposable

        //=========================================================================

        #region methods

        public void Reset()
        {
            this.startSignalWasSet = false;
            this.endSignalWasSet = false;
        }

        //-----------------------------------------

        #endregion methods

        //=========================================================================
    }
}
