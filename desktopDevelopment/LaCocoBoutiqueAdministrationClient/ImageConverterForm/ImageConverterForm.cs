using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageConverter
{
    using ImageHelpers; 
    using Properties;

    public partial class ImageConverterForm : Form
    {
        // ===========================================================================================

        #region data_fields

        // ----------------------------------------------

        private readonly List<string> imageFilePathsInBaseDirectory;
        private ImageData originalImageData;
        private ImageData thumbnailImageData;
        private readonly DataTable imagesDataTable;
        private int imagePositionPointer;

        // ----------------------------------------------

        #endregion

        // ===========================================================================================

        #region constructors

        public ImageConverterForm()
        {
            this.InitializeComponent();
            bool initializeStatus = false;
            DialogResult dr = DialogResult.None;
            do
            {
                this.imagesBasePathValueToolStripStatusLabel.Text = Settings.Default.OriginalImagesBaseDirectory;
                this.imageFilePathsInBaseDirectory = new List<string>();
                try
                {
                    string originalImagesBaseDirectory = Settings.Default.OriginalImagesBaseDirectory;
                    this.imageFilePathsInBaseDirectory.AddRange(this.GetImageFilePathsFromSpecifiedDirectory(originalImagesBaseDirectory));
                    initializeStatus = true;
                }
                catch (Exception ex)
                {
                    dr = MessageBox.Show(
                        string.Format("An exception did occur while getting the image files informations in the specified base directory which are configured in the settings!\r\n\r\nException Message:\r\n{0}", ex.Message),
                        ex.Source,
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.Cancel)
                        this.Close();
                }
            } while (!initializeStatus && (dr != DialogResult.Cancel));
            this.imagePositionPointer = 0;
            this.imagesDataTable = new DataTable("OriginalImages");
            this.imagesDataTable.Columns.Add("Image", typeof (Image));
            this.imagesDataTable.Columns.Add("ImagePath", typeof(string));
            this.imagesDataTable.Columns.Add("ImageIndex", typeof(int));
            this.UpdateImagesDataTable(imageFilePathsInBaseDirectory);
            this.AddImagePathsToImagesListBox(Settings.Default.OriginalImagesBaseDirectory);
            this.originalImagePictureBox.DataBindings.Add("Image", this.imagesDataTable, "Image");
        }

        #endregion

        // ===========================================================================================

        #region methods

        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="Exception"></exception>
        private IEnumerable<string> GetImageFilePathsFromSpecifiedDirectory(string baseDirectory)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(baseDirectory);
            IEnumerable<FileInfo> directoryFiles = directoryInfo.EnumerateFiles();
            IEnumerable<string> filteredDirectoryFiles = directoryFiles
                .Where(fileInfo => fileInfo.Extension.ToLower() == ".jpg" || fileInfo.Extension == ".jpeg" || fileInfo.Extension == ".bmp")
                .Select(fileInfo => fileInfo.FullName);
            return filteredDirectoryFiles;
        }

        // ----------------------------------------------

        private void UpdateImagesDataTable(IEnumerable<string> imageFilePaths)
        {
            this.imagesDataTable.Clear();
            int index = 0;
            foreach (string filePath in imageFilePaths)
                this.imagesDataTable.Rows.Add(Image.FromFile(filePath), filePath, index++);
        }

        // ----------------------------------------------

        private void AddImagePathsToImagesListBox(string selectedDirectoryPath)
        {
            IEnumerable<string> imageFilePathsFromSpecifiedDirectory =
                    this.GetImageFilePathsFromSpecifiedDirectory(selectedDirectoryPath);
            this.imagesListBox.Items.AddRange(imageFilePathsFromSpecifiedDirectory.Select(
                delegate(string imagePath) { return string.Format("..\\{0}", Path.GetFileName(imagePath)); }).ToArray<object>());
            this.UpdateImagesDataTable(imageFilePathsFromSpecifiedDirectory);
        }

        // ----------------------------------------------

        private void NextImageByIncrement()
        {
            CurrencyManager currencyManager = (CurrencyManager)base.BindingContext[this.imagesDataTable];
            if ((currencyManager.Position < 0) || (currencyManager.Position >= this.imagesDataTable.Rows.Count))
                return;

            currencyManager.Position += 1;
            this.imagePositionPointer = currencyManager.Position;
        }

        // ----------------------------------------------

        private void PreviousImageByDecrement()
        {
            CurrencyManager currencyManager = (CurrencyManager)base.BindingContext[imagesDataTable];
            if ((currencyManager.Position <= 0) || (currencyManager.Position > this.imagesDataTable.Rows.Count))
                return;

            currencyManager.Position -= 1;
            this.imagePositionPointer = currencyManager.Position;
        }

        //-----------------------------------------------

        private void SelectImageByAbsoluteIndex(int index)
        {
            CurrencyManager currencyManager = (CurrencyManager)base.BindingContext[this.imagesDataTable];
            currencyManager.Position = index;
            this.imagePositionPointer = currencyManager.Position;
        }

        // ----------------------------------------------

        /// <exception cref="NotFiniteNumberException" />
        private void LoadImageButtonClick(object sender, EventArgs e)
        {
            try
            {
                throw new NotImplementedException("Implement file dialog browser for single images.");
            }
            catch (Exception ex)
            {
                this.ShowException(
                    string.Format("The image could not be loaded from the specified path: {0}\r\n\r\nException Message:\r\n{1}", string.Empty, ex.Message),
                    ex.Source);
            }
        }

        // ----------------------------------------------

        private void ResizeImageToThumbnailButtonClick(object sender, EventArgs e)
        {
            try
            {
                this.thumbnailImageData = ImageSizeConverter.ResizeImage(this.originalImageData, new Size((int)(this.originalImageData.Size.Width * 0.15), (int)(this.originalImageData.Size.Height * 0.15)));
                this.thumbnailImagePictureBox.Image = this.thumbnailImageData.Image;
            }
            catch (Exception ex)
            {
                this.ShowException(
                    string.Format("The image could not be resized.\r\n\r\nException Message:\r\n{0}", ex.Message),
                    ex.Source);
            }
        }

        // ----------------------------------------------

        private void SaveThumbnailImageButtonClick(object sender, EventArgs e)
        {
            try
            {
                ImageFileHelper.SaveImageAsThumbnail(this.thumbnailImageData, Settings.Default.ThumbnailImagesBaseDirectory);
            }
            catch (Exception ex)
            {
                this.ShowException(
                    string.Format("The thumbnail image could not be saved to the specified location.\r\n\r\nException Message:\r\n{0}", ex.Message),
                    ex.Source);
            }
        }

        // ----------------------------------------------

        private void SaveThumbnailBatchToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                ImageBatchSaverForm batchSaver = new ImageBatchSaverForm();
                batchSaver.ShowDialog(this);
            }
            catch (Exception ex)
            {
                this.ShowException(
                    string.Format("The thumbnail images could not be saved to the specified location.\r\n\r\nException Message:\r\n{0}", ex.Message),
                    ex.Source);
            }
        }

        // ----------------------------------------------

        private void NextImageButtonClick(object sender, EventArgs e)
        {
            this.NextImageByIncrement();
            this.imagesListBox.SelectedIndex = this.imagePositionPointer;
            this.originalImageData = new ImageData(this.imagesDataTable.Rows[this.imagePositionPointer].ItemArray[1].ToString());
        }

        // ----------------------------------------------

        private void PreviousImageButtonClick(object sender, EventArgs e)
        {
            this.PreviousImageByDecrement();
            this.imagesListBox.SelectedIndex = this.imagePositionPointer;
            this.originalImageData = new ImageData(this.imagesDataTable.Rows[this.imagePositionPointer].ItemArray[1].ToString());
        }

        // ----------------------------------------------

        private void SelectBaseDirectoryToolStripSplitButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = false;
            DialogResult dialogResult = folderBrowserDialog.ShowDialog(this);
            if (dialogResult == DialogResult.Cancel)
                return;

            string selectedDirectoryPath = folderBrowserDialog.SelectedPath;
            try
            {
                this.AddImagePathsToImagesListBox(selectedDirectoryPath);
            }
            catch (Exception ex)
            {
                this.ShowException(
                    string.Format("The selected folder was not valid: {0}. Please try again!\r\n\r\nException Message:\r\n{1}", selectedDirectoryPath, ex.Message),
                    ex.Source);
            }
        }

        // ----------------------------------------------

        private void ImagesListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ((ListBox)sender).SelectedIndex;
            this.SelectImageByAbsoluteIndex(selectedIndex);
            this.originalImageData = new ImageData(this.imagesDataTable.Rows[this.imagePositionPointer].ItemArray[1].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageList imageList= new ImageList();
            imageList.ImageSize = new Size(48, 48);
            for (int i = 0; i < this.imageFilePathsInBaseDirectory.Count; i++)
            {
                imageList.Images.Add(new ImageData(this.imageFilePathsInBaseDirectory[i]).Image);
                imagesToResizeListView.Items.Add(new ListViewItem(Path.GetFileName(this.imageFilePathsInBaseDirectory[i]), i));
            }
            imagesToResizeListView.LargeImageList = imageList;
        }

        // ----------------------------------------------

        private void ShowException(string exceptionText, string captionText)
        {
            MessageBox.Show(this, exceptionText, captionText, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        // ===========================================================================================
    }
}
