using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaCocoBoutiqueAdministration
{
    public partial class ThumbnailImageSelectionForm : Form
    {
        public ThumbnailImageSelectionForm(ProductsDataRelationDataContext dataContext)
        {
            this.InitializeComponent();
            this.thumbnailImagesBindingSource.DataSource = dataContext.ProductImageThumbnails;
            this.thumbnailImagesTableDataGridView.DataSource = this.thumbnailImagesBindingSource;
        }
    }
}
