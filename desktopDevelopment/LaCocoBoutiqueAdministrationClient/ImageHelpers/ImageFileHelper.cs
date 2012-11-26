using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageHelpers
{
    public static class ImageFileHelper
    {
        #region backing_data_fields

        //

        #endregion

        // ============================================================

        #region constructors

        static ImageFileHelper() {}

        #endregion

        // ============================================================

        #region methods

        public static ImageData LoadImage(string imageFilePath)
        {
            return new ImageData(imageFilePath);
        }

        // --------------------------------

        public static IEnumerable<ImageData> LoadImagesDialog(string initialDirectory, bool dialogMultiselect)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = dialogMultiselect,
                InitialDirectory = initialDirectory,
                Filter = "Jpg files (*.jpg)|*.jpg|All files (*.*)|*.*"
            };
            if (dialog.ShowDialog() != DialogResult.OK)
                return null;
            
            List<string> imageFileNames = dialog.FileNames.ToList();
            return LoadImages(imageFileNames).ToList();
        }

        // --------------------------------

        public static IEnumerable<ImageData> LoadImages(IEnumerable<string> imagesPathsToLoad)
        {
            List<ImageData> loadedImagesList = new List<ImageData>(imagesPathsToLoad.Count());
            loadedImagesList.AddRange(imagesPathsToLoad.Select(LoadImage));
            return loadedImagesList;
        }

        // --------------------------------

        public static void SaveImage(ImageData imageData)
        {
            using (FileStream fs = File.OpenWrite(Path.Combine(imageData.Directory, imageData.NameWithoutExtension + "_tn" + imageData.Extension)))
            {
                imageData.Image.Save(fs, ImageFormat.Jpeg);
            }
        }

        // --------------------------------

        public static void SaveImages(IEnumerable<ImageData> imagesData)
        {
            foreach (ImageData image in imagesData)
                SaveImage(image);
        }

        // --------------------------------

        public static void SaveImageAsThumbnail(ImageData imageData, string relativeThumbnailImagesSubDirectory)
        {
            using (FileStream fs = File.OpenWrite(Path.Combine(imageData.Directory, relativeThumbnailImagesSubDirectory, imageData.NameWithoutExtension + "_tn" + imageData.Extension)))
            {
                imageData.Image.Save(fs, ImageFormat.Jpeg);
            }
        }

        // --------------------------------

        public static void SaveImagesAsThumbnails(IEnumerable<ImageData> imagesData, string relativeThumbnailImagesSubDirectory)
        {
            foreach (ImageData image in imagesData)
                SaveImageAsThumbnail(image, relativeThumbnailImagesSubDirectory);
        }

        #endregion
    }
}
