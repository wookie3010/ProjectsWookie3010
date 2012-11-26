using System;
using System.Windows.Forms;

namespace LaCocoBoutiqueAdministration
{
    static class Program
    {
        private static AdministrationClientForm productsTableDataManipulationForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            productsTableDataManipulationForm = new AdministrationClientForm();
            Application.Run(productsTableDataManipulationForm);
        }
    }
}
