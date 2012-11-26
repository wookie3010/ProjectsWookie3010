using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    using WeatherStationDatabaseDataSetTableAdapters;

    public partial class MainForm : Form
    {
        private Task temperatureMeasurementTask;
        private CancellationTokenSource tokenSource;

        public MainForm()
        {
            InitializeComponent();
            this.CreateMeasurementTasks();
        }

        private void CreateMeasurementTasks()
        {
            this.tokenSource = new CancellationTokenSource();
            CancellationToken token = this.tokenSource.Token;
            this.temperatureMeasurementTask = new Task(
                delegate(object o)
                {
                    bool b = o is CancellationToken;
                    using (TemperatureTableAdapter adapter = new TemperatureTableAdapter())
                    {
                        int counter = 0;
                        Random temperatureValue = new Random();
                        while (true)
                        {
                            if (token.IsCancellationRequested)
                                throw new OperationCanceledException();

                            int affectedRows = adapter.Insert(
                                (float?)(temperatureValue.NextDouble() * 100.0),
                                (short?)(temperatureValue.Next(0, 1023)), DateTime.Now);
                            if (affectedRows <= 0)
                                throw new Exception("The sensor data could not be inserted into the database!");
                                
                            this.Invoke(
                                (Action<int>) delegate(int cntr)
                                                {
                                                    this.dataRecordsNumValueTolStripStatusLabel.Text =
                                                        cntr.ToString(CultureInfo.InvariantCulture);
                                                }, ++counter);
                        }
                    }
                }, token);
        }

        private void ActivateMeasurementsButtonClick(object sender, EventArgs e)
        {
            this.temperatureMeasurementTask.Start();
        }

        private void StopMeasurementsButtonClick(object sender, EventArgs e)
        {
            this.tokenSource.Cancel();
        }
    }
}
