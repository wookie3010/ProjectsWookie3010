using System;
using System.Globalization;
using System.Windows.Forms;

namespace LaCocoBoutiqueAdministration
{
    public partial class ValueSetterForm : Form
    {
        private object newValue;
        
        public object NewValue
        {
            get { return this.newValue; }
        }

        public ValueSetterForm()
        {
            this.InitializeComponent();
            this.newValueTextBox.Text = string.Empty;
        }

        private void ApplyValueButtonClick(object sender, EventArgs e)
        {
            this.newValue = this.newValueTextBox.Text.ToString(CultureInfo.CurrentCulture);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
