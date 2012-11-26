using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace LaCocoBoutiqueAdministration
{
    using ImageConverter;

    public partial class AdministrationClientForm : Form
    {
        #region backing_data_fields

        private readonly IDbConnection dbConnection;
        private readonly ProductsDataRelationDataContext dataContext;

        #endregion

        // ==================================================

        #region constructors

        public AdministrationClientForm()
        {
            this.InitializeComponent();
            this.productsBindingSource = new BindingSource();
            this.productCategoriesBindingSource = new BindingSource();
            this.dbConnection = GetConnectionProvider();
            this.dataContext = new ProductsDataRelationDataContext(this.dbConnection);
            this.productsBindingSource.DataSource = this.dataContext.Products;
            this.productCategoriesBindingSource.DataSource = this.dataContext.ProductCategories;
        }

        #endregion 

        // ==================================================

        #region private_methods

        private static IDbConnection GetConnectionProvider()
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = @"ITCH102\MSSQLSERVER2012";
            connectionStringBuilder.InitialCatalog = @"LaCocoBoutique";
            connectionStringBuilder.AsynchronousProcessing = true;
            connectionStringBuilder.Enlist = true;
            connectionStringBuilder.IntegratedSecurity = true;
            connectionStringBuilder.ConnectTimeout = 1000;
            return new SqlConnection(connectionStringBuilder.ToString());
        }

        // --------------------------

        private void SetProductButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.productsBindingSource.EndEdit();
                this.dataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this, string.Format("The product data record could not be inserted into the Products Data Table.\r\n\r\nException Message:\r\n{0}", ex.Message), 
                    ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                foreach(Control c in this.productPanel.Controls)
                {
                    if (c is Label)
                        continue;

                    c.ResetText();
                }
                this.productsDataGridView.Update();
            }
        }

        // --------------------------

        private void InsertProductToProductsTableFormLoad(object sender, EventArgs e)
        {
            if (this.productCategoriesBindingSource == null)
            {
                MessageBox.Show(
                    this,
                    "It was not possible to bind to the LaCocoBoutique.Products.Categories database table.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.categoryComboBox.DataSource = this.productCategoriesBindingSource;
            this.categoryComboBox.ValueMember = "CategoryId";
            this.categoryComboBox.DisplayMember = "CategoryText_enUS";
            if (this.productsBindingSource == null)
            {
                MessageBox.Show(
                    this,
                    "It was not possible to bind to the LaCocoBoutique.Products database table.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.productIdTextBox.DataBindings.Add("Text", this.productsBindingSource, "ProductId");
            this.nameTextBox.DataBindings.Add("Text", this.productsBindingSource, "Name");
            this.orderCodeTextBox.DataBindings.Add("Text", this.productsBindingSource, "OrderCode");
            this.quantityTextBox.DataBindings.Add("Text", this.productsBindingSource, "Quantity");
            this.priceTextBox.DataBindings.Add("Text", this.productsBindingSource, "Price");
            this.discountTextBox.DataBindings.Add("Text", this.productsBindingSource, "DiscountInPercentage");
            this.productsDataGridView.DataSource = this.productsBindingSource;
            this.productsDataGridView.Columns["CategoryId"].Visible = false;
            this.productsDataGridView.Columns["ProductCategory"].Visible = false;
        }

        // --------------------------

        private void MoveFirstEntityButtonClick(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveFirst();
        }

        // --------------------------

        private void MovePreviousEntityButtonClick(object sender, EventArgs e)
        {
            this.productsBindingSource.MovePrevious();
        }

        // --------------------------

        private void MoveNextEntityButtonClick(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveNext();
        }

        // --------------------------

        private void MoveLastEntityButtonClick(object sender, EventArgs e)
        {
            this.productsBindingSource.MoveLast();
        }

        // --------------------------

        private void InsertDatasetToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        // --------------------------

        private void DeleteDatasetToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        // --------------------------

        private void UpdateSelectedDiscountValuesToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.productsDataGridView.SelectedRows.Count <= 0)
                return;

            DataGridViewSelectedRowCollection dataGridViewSelectedRowCollection = this.productsDataGridView.SelectedRows;
            DataGridViewRow r = dataGridViewSelectedRowCollection[0];
            ValueSetterForm valueSetterForm = new ValueSetterForm();
            DialogResult dr = valueSetterForm.ShowDialog(this);
            if (dr != DialogResult.OK)
                return;

            try
            {
                double newValue;
                double.TryParse(valueSetterForm.NewValue.ToString(), NumberStyles.Float|NumberStyles.Number|NumberStyles.Integer|NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out newValue);
                foreach (DataGridViewRow row in dataGridViewSelectedRowCollection)
                    row.Cells["DiscountInPercentage"].Value = newValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An exception did occur while updating the selected values in the data grid view.\r\n\r\nException Message:\r\n{0}", ex.Message), ex.Source);
            }
            finally
            {
                this.productsDataGridView.Update();
            }
        }

        // --------------------------

        private void UpdateSelectedQuantityValuesToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.productsDataGridView.SelectedRows.Count <= 0)
                return;
            
            DataGridViewSelectedRowCollection dataGridViewSelectedRowCollection = this.productsDataGridView.SelectedRows;
            DataGridViewRow r = dataGridViewSelectedRowCollection[0];
            ValueSetterForm valueSetterForm = new ValueSetterForm();
            DialogResult dr = valueSetterForm.ShowDialog(this);
            if (dr != DialogResult.OK)
                return;

            try
            {
                foreach (DataGridViewRow row in dataGridViewSelectedRowCollection)
                    row.Cells["Quantity"].Value = Convert.ToInt32(valueSetterForm.NewValue);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, string.Format("An exception did occur while updating the selected values in the data grid view.\r\n\r\nException Message:\r\n{0}",ex.Message), ex.Source);
            }
            finally
            {
                this.productsDataGridView.Update();
            }
        }

        // --------------------------

        private void ImageConverterButtonClick(object sender, EventArgs e)
        {
            ImageConverterForm imageConverterForm = new ImageConverterForm();
            imageConverterForm.Show();
        }

        // --------------------------

        private void SelectMainImageButtonClick(object sender, EventArgs e)
        {
            ThumbnailImageSelectionForm thumbnailImageSelectionForm = new ThumbnailImageSelectionForm(this.dataContext);
            thumbnailImageSelectionForm.Show(this);
        }

        // --------------------------

        private void SelectThumbnailImagesButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            DialogResult dialogResult = openFileDialog.ShowDialog(this);
            if (dialogResult != DialogResult.OK)
                return;

            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(32, 32);
            List<string> fileNames = openFileDialog.FileNames.ToList();
            IEnumerable<Image> images = openFileDialog.FileNames.Select(Image.FromFile);
            imageList.Images.AddRange(images.ToArray());
            int index = 0;
            foreach (string fileName in fileNames)
                this.thumbnailsListView.Items.Add(new ListViewItem(Path.GetFileName(fileName), index++));
            this.thumbnailsListView.LargeImageList = imageList;
        }

        #endregion

        // ==================================================
    }
}
