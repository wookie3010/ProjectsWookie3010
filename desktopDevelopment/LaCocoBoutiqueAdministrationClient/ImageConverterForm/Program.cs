using System;
using System.Windows.Forms;

namespace ImageConverter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new ImageConverterForm());
            }
            catch (System.InvalidOperationException)
            {
            }
            finally
            {
                Application.Exit();
            }
        }
    }
}
