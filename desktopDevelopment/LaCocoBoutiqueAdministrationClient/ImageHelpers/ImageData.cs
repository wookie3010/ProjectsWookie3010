using System;
using System.Drawing;
using System.IO;

namespace ImageHelpers
{
    public class ImageData : IDisposable
    {
        #region backing_data_Fields

        private bool disposed;
        private Image image;
        private string filePath;

        #endregion

        // ============================================================

        #region properties

        public Image Image
        {
            get { return this.image; }
        }

        // ----------------------

        public string FilePath
        {
            get { return this.filePath; }
        }

        // ----------------------

        public string Name
        {
            get { return Path.GetFileName(this.filePath); }
        }

        // ----------------------

        public string NameWithoutExtension
        {
            get { return Path.GetFileNameWithoutExtension(this.filePath); }
        }

        // ----------------------

        public string Extension
        {
            get { return Path.GetExtension(this.filePath); }
        }

        // ----------------------

        public string Directory
        {
            get { return Path.GetDirectoryName(this.filePath); }
        }

        // ----------------------

        public Size Size
        {
            get { return this.image.Size; }
        }

        #endregion

        // =========================================================

        #region constructors

        public ImageData(string imageFilePath, Image image)
        {
            this.disposed = false;
            this.image = image;
            this.filePath = imageFilePath;
        }

        public ImageData(string imageFilePath)
        {
            this.disposed = false;
            this.filePath = imageFilePath;
            this.image = Image.FromFile(imageFilePath);
        }

        #endregion

        // ============================================================

        #region methods

        public void Dispose()
        {
            if (this.disposed)
                return;

            this.image.Dispose();
            this.filePath = string.Empty;
            this.disposed = true;
        }

        #endregion
    }
}
