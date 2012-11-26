using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Forms;

using WorkingTimeObserver.Properties;
using System.Media;

namespace WorkingTimeObserver
{
    public partial class WorkingTimeObserverForm : Form
    {
        private TimeObserverData timeObserverData;
        private Timer updateTimer;
        
        public WorkingTimeObserverForm()
        {
            InitializeComponent();

            this.timeObserverData = new TimeObserverData(new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second), GetBreakArrayFromSettings());
            this.timeObserverData.BreakStarted += ShowMessageBreakStarted;
            this.timeObserverData.BreakEnded += ShowMessageBreakEnded;
            this.currentTimeLabel.Text = DateTime.Now.ToShortTimeString();
            this.updateTimer = new Timer();
            this.updateTimer.Interval = 10000;
            this.updateTimer.Tick +=
                delegate(object sender, EventArgs e)
                {
                    this.currentTimeLabel.Text = DateTime.Now.ToShortTimeString();
                    this.LogData();
                };
            this.updateTimer.Start();

            XmlWriterTraceListener traceListener = new XmlWriterTraceListener(@"C:\_temp\logfile.xml");
            traceListener.IndentLevel = 4;
            traceListener.
            Trace.Listeners.Add(traceListener);
            
        }

        private void LogData()
        {
            Trace.WriteLine(DateTime.Now);
        }

        private Break[] GetBreakArrayFromSettings()
        {
            Break breakfastBreak = new Break("Breakfast Break", Settings.Default.BreakfastStart, Settings.Default.BreakfastEnd);
            Break lunchBreak = new Break("Lunch Break", Settings.Default.LunchStart, Settings.Default.LunchEnd);

            return new Break[] { breakfastBreak, lunchBreak };
        }

        private void ShowMessageBreakStarted(object sender, BreakStartedEventArgs e)
        {
            MessageBox.Show(string.Format("This break did START right now: {0}; Timestamp: {1}", e.Name, e.Timestamp));
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            simpleSound.Play();

        }

        private void ShowMessageBreakEnded(object sender, BreakEndedEventArgs e)
        {
            MessageBox.Show(string.Format("This break did END right now: {0}; Timestamp: {1}", e.Name, e.Timestamp));
        }
    }
}