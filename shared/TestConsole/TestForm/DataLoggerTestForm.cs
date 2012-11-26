using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TestForm
{
    using CommonFunctions.DataLogger;
    using CommonFunctions.DataLogger.Contracts;

    public partial class DataLoggerTestForm : Form
    {
        private readonly IDataLogger logger;

        public DataLoggerTestForm()
        {
            this.InitializeComponent();

            this.logger = DataLogger.Instance;
            this.logger.LogFilePath = Path.Combine(Environment.CurrentDirectory, "log.mylog");
            this.logger.LogItemsChanged += UpdateLog;
        }

        private void UpdateLog(object sender, NotifyLogElementsChangedEventArgs e)
        {
            object[] logElements = e.ChangedLogElements.Select(delegate(ILogItem le) { return le.ToString(); }).ToArray<object>();
            this.logListBox.Items.AddRange(logElements);
        }
    }
}
