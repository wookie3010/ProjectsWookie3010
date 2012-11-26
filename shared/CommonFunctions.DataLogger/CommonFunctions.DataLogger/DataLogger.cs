using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;

namespace CommonFunctions.DataLogger
{
    using CommonFunctions.DataLogger.Contracts;
    using CommonFunctions.DataLogger.Contracts.Enumerations;

    public struct LogItem : ILogItem
    {
        // ===============================================================

        #region backing_data_fields

        private static UInt32 idCounter;
        private readonly object syncObject;

        #endregion

        // ===============================================================

        #region proeprties

        public UInt32 Id { get; private set; }

        public DateTime Timestamp { get; private set; }

        public LogItemClassifier ItemClass { get; private set; }

        public String Text { get; private set; }

        public String Status { get; private set; }

        public Exception CaughtException { get; private set; }

        #endregion
        // ===============================================================

        #region constructors

        static LogItem()
        {
            idCounter = 0;
        }

        public LogItem(LogItemClassifier logItemClass, String text, String status) 
            : this()
        {
            this.syncObject = new object();
            this.Id = idCounter++;
            this.Timestamp = DateTime.Now;
            this.ItemClass = logItemClass;
            this.Text = text;
            this.Status = status;
        }

        public LogItem(LogItemClassifier logItemClassifier, String text, String status, Exception caughtException)
            : this(logItemClassifier, text, status)
        {
            this.CaughtException = caughtException;
        }

        #endregion

        // ===============================================================

        #region public_methods

        /// <caughtException cref="InvalidDataException"></caughtException>
        /// <caughtException cref="System.FormatException"></caughtException>
        public override string ToString()
        {
            lock (this.syncObject)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("[");
                sb.Append(this.Id.ToString("d4"));
                sb.Append(" :: ");
                sb.Append(this.Timestamp.ToString("yyyy-MM-dd HH:mm:ss"));
                sb.Append(".");
                sb.Append(this.Timestamp.Millisecond.ToString("d3"));
                sb.Append("]");
                sb.Append(" - ");
                sb.Append(this.ItemClass);
                sb.Append(" - ");
                sb.Append("\"");
                sb.Append(this.Text);
                sb.Append("\"");
                sb.Append(" - ");
                sb.Append(this.Status);

                return sb.ToString();
            }
        }

        #endregion

        // ===============================================================
    }

    // *******************************************************************************************
    // *******************************************************************************************

    public sealed class DataLogger : IDataLogger, IDisposable
    {
        // ===============================================================

        #region backing_data_fields

        private bool disposed;
        private readonly object syncRoot;
        private ObservableCollection<ILogItem> logItems;
        private String logFilePath;
        private TextWriter logFileWriter;

        public event EventHandler<NotifyLogElementsChangedEventArgs> LogElementsChanged; 
        
        #endregion

        // ===============================================================

        #region containments

        /// <summary>
        /// Accessor object for instantiating and retrieving the singleton object.
        /// </summary>
        private static class DataLoggerInstanceAccessor
        {
            public static readonly DataLogger NestedInstance;

            static DataLoggerInstanceAccessor()
            {
                NestedInstance = new DataLogger();    
            }
        }

        #endregion

        // ===============================================================

        #region finalizer

        ~DataLogger()
        {
            this.Dispose(false);
        }

        #endregion

        // ===============================================================

        #region properties

        public event EventHandler<NotifyLogElementsChangedEventArgs> LogItemsChanged;

        /// <caughtException cref="FileNotFoundException"></caughtException>
        /// <exception cref="FileNotFoundException"></exception>
        public String LogFilePath
        {
            get { return this.logFilePath; }
            set
            {
                this.logFilePath = value;
                string logFileDirectory = Path.GetDirectoryName(this.logFilePath);
                bool isLogFileDirectoryExisting = logFileDirectory != null && Directory.Exists(logFileDirectory);
                if (!isLogFileDirectoryExisting)
                {
                    throw new FileNotFoundException(string.Format("The specified log file directory does not exist: {0}", this.logFilePath));
                }

                this.logFileWriter = new StreamWriter(new FileStream(this.logFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite), Encoding.UTF8);
            }
        }

        // ---------------------------
        
        public IEnumerable<ILogItem> LogItems
        {
            get { return this.logItems; }
        }

        // ---------------------------

        public static DataLogger Instance
        {
            get { return DataLoggerInstanceAccessor.NestedInstance; }
        }

        public Boolean LoggerInitialized
        {
            get { return this.logFileWriter != null; }
        }

        #endregion

        // ===============================================================

        #region constructors

        /// <caughtException cref="FileNotFoundException"></caughtException>
        private DataLogger()
        {
            this.disposed = false;
            this.syncRoot = new object();
            this.logItems = new ObservableCollection<ILogItem>();
            this.logItems.CollectionChanged += OnLogItemsCollectionChanged;
        }

        #endregion

        // =============================================================== 

        #region private_methods
        
        private void OnLogItemsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (this.LogElementsChanged == null)
            {
                return;
            }

            IEnumerable<ILogItem> newLogItems = e.NewItems.Cast<ILogItem>();
            NotifyLogElementsChangedEventArgs notifyLogElementsChangedEventArgs = new NotifyLogElementsChangedEventArgs(newLogItems);
            this.LogElementsChanged(this, notifyLogElementsChangedEventArgs);
        }

        // ---------------------------------

        private void Dispose(bool disposing)
        {
            lock (this.syncRoot)
            {
                if (this.disposed)
                {
                    return;
                }

                if (disposing)
                {
                    try
                    {
                        this.logFileWriter.Flush();
                        this.logItems.Clear();
                    }
                    finally
                    {
                        this.logFileWriter.Dispose();
                        this.logFileWriter = null;
                        this.logItems = null;
                    }
                }

                this.disposed = true;
            }
        }

        #endregion

        // =============================================================== 

        #region public_methods
        
        public void AddLogEntry(ILogItem logItem)
        {
            this.logItems.Add(logItem);
            this.logFileWriter.WriteLine(logItem.ToString());
        }

        public void AddLogEntry(LogItemClassifier logItemClass, String logText, String status)
        {
            LogItem le = new LogItem(logItemClass, logText, status);
            this.AddLogEntry(le);
        }

        #endregion

        // =============================================================== 

        #region IDisposable

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
