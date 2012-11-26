using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ImageHelpers;

namespace ImageConverter
{
    public partial class ImageBatchSaverForm : Form
    {
        #region backing_data_fields

        private List<ImageData> loadedImages;
        private readonly List<ImageData> thumbnailImages;

        #endregion

        // ===================================================

        #region constructors

        public ImageBatchSaverForm()
        {
            this.InitializeComponent();
            this.loadedImages = new List<ImageData>();
            this.thumbnailImages = new List<ImageData>();
        }

        #endregion

        // ===================================================

        #region methods

        private void LoadImagesButtonClick(object sender, EventArgs e)
        {
            Cursor currentCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                this.loadedImages = ImageFileHelper.LoadImagesDialog(Environment.CurrentDirectory, true).ToList();
                foreach (ImageData imageData in this.loadedImages)
                    this.listBox.Items.Add(imageData.Name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this,
                    string.Format("Not all images could be loaded.\r\n\r\nException Message:\r\n{0}", ex.Message),
                    ex.Source,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = currentCursor;
            }
        }

        // -------------------------

        private void SaveAllImagesAsThumbnailsButtonClick(object sender, EventArgs e)
        {
            Cursor currentCursor = this.Cursor;
            this.Cursor = Cursors.WaitCursor;
            try
            {
                foreach (ImageData imageData in this.loadedImages)
                    this.thumbnailImages.Add(ImageSizeConverter.ResizeImage(imageData));
                ImageFileHelper.SaveImagesAsThumbnails(this.thumbnailImages, "thumbnails");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    this, 
                    string.Format("Not all thumbnails could be saved.\r\n\r\nException Message:\r\n{0}", ex.Message), 
                    ex.Source, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = currentCursor;    
            }
        }

        // -------------------------

        private void UnloadImagesButtonClick(object sender, EventArgs e)
        {
            this.loadedImages.Clear();
            this.thumbnailImages.Clear();
        }

        #endregion

        // ===================================================
    }
}
