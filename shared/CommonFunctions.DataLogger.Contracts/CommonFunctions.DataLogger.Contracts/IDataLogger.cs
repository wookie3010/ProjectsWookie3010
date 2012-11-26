using System;
using System.Collections.Generic;

namespace CommonFunctions.DataLogger.Contracts
{
    using CommonFunctions.DataLogger.Contracts.Enumerations;

    public interface IDataLogger
    {
        event EventHandler<NotifyLogElementsChangedEventArgs> LogItemsChanged;
        
        String LogFilePath { get; set; }
        IEnumerable<ILogItem> LogItems { get; }
        Boolean LoggerInitialized { get; }
        void AddLogEntry(ILogItem logItem);
        void AddLogEntry(LogItemClassifier logItemClass, String logText, String status);
        void Dispose();
    }
}