using System;
using System.Collections.Generic;

namespace CommonFunctions.DataLogger.Contracts
{
    public sealed class NotifyLogElementsChangedEventArgs : EventArgs
    {
        public readonly IEnumerable<ILogItem> ChangedLogElements;

        public NotifyLogElementsChangedEventArgs(IEnumerable<ILogItem> changedLogElements)
        {
            this.ChangedLogElements = changedLogElements;
        }
    }
}