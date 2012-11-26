namespace ImageConverter
{
    partial class ImageConverterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageConverterForm));
            this.resizeImageToThumbnailButton = new System.Windows.Forms.Button();
            this.controlPanelGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.thumbnailImagePreviewGroupBox = new System.Windows.Forms.GroupBox();
            this.thumbnailImagePictureBox = new System.Windows.Forms.PictureBox();
            this.imagesGroupBox = new System.Windows.Forms.GroupBox();
            this.previousImageButton = new System.Windows.Forms.Button();
            this.nextImageButton = new System.Windows.Forms.Button();
            this.loadImagesFromDirectoryButton = new System.Windows.Forms.Button();
            this.thumbnailActionsGroupBox = new System.Windows.Forms.GroupBox();
            this.saveThumbnailImageButton = new System.Windows.Forms.Button();
            this.originalImagesView = new System.Windows.Forms.GroupBox();
            this.imagesToResizeListView = new System.Windows.Forms.ListView();
            this.imagesListBox = new System.Windows.Forms.ListBox();
            this.originalImagePictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveThumbnailBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.imagesBasePathToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.imagesBasePathValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.selectBaseDirectoryToolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.selectBaseDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.loadedImageNameToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.loadedImageNameValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.controlPanelGroupBox.SuspendLayout();
            this.thumbnailImagePreviewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImagePictureBox)).BeginInit();
            this.imagesGroupBox.SuspendLayout();
            this.thumbnailActionsGroupBox.SuspendLayout();
            this.originalImagesView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalImagePictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // resizeImageToThumbnailButton
            // 
            this.resizeImageToThumbnailButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resizeImageToThumbnailButton.Location = new System.Drawing.Point(6, 19);
            this.resizeImageToThumbnailButton.Name = "resizeImageToThumbnailButton";
            this.resizeImageToThumbnailButton.Size = new System.Drawing.Size(150, 40);
            this.resizeImageToThumbnailButton.TabIndex = 0;
            this.resizeImageToThumbnailButton.Text = "Resize Image To Thumbnail";
            this.resizeImageToThumbnailButton.UseVisualStyleBackColor = true;
            this.resizeImageToThumbnailButton.Click += new System.EventHandler(this.ResizeImageToThumbnailButtonClick);
            // 
            // controlPanelGroupBox
            // 
            this.controlPanelGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanelGroupBox.Controls.Add(this.button1);
            this.controlPanelGroupBox.Controls.Add(this.thumbnailImagePreviewGroupBox);
            this.controlPanelGroupBox.Controls.Add(this.imagesGroupBox);
            this.controlPanelGroupBox.Controls.Add(this.thumbnailActionsGroupBox);
            this.controlPanelGroupBox.Controls.Add(this.originalImagesView);
            this.controlPanelGroupBox.Location = new System.Drawing.Point(12, 27);
            this.controlPanelGroupBox.Name = "controlPanelGroupBox";
            this.controlPanelGroupBox.Size = new System.Drawing.Size(1160, 710);
            this.controlPanelGroupBox.TabIndex = 1;
            this.controlPanelGroupBox.TabStop = false;
            this.controlPanelGroupBox.Text = "Control Panel";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // thumbnailImagePreviewGroupBox
            // 
            this.thumbnailImagePreviewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.thumbnailImagePreviewGroupBox.Controls.Add(this.thumbnailImagePictureBox);
            this.thumbnailImagePreviewGroupBox.Location = new System.Drawing.Point(6, 416);
            this.thumbnailImagePreviewGroupBox.Name = "thumbnailImagePreviewGroupBox";
            this.thumbnailImagePreviewGroupBox.Size = new System.Drawing.Size(162, 288);
            this.thumbnailImagePreviewGroupBox.TabIndex = 3;
            this.thumbnailImagePreviewGroupBox.TabStop = false;
            this.thumbnailImagePreviewGroupBox.Text = "Thumbnail Image Preview";
            // 
            // thumbnailImagePictureBox
            // 
            this.thumbnailImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbnailImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumbnailImagePictureBox.Location = new System.Drawing.Point(6, 19);
            this.thumbnailImagePictureBox.Name = "thumbnailImagePictureBox";
            this.thumbnailImagePictureBox.Size = new System.Drawing.Size(150, 266);
            this.thumbnailImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumbnailImagePictureBox.TabIndex = 3;
            this.thumbnailImagePictureBox.TabStop = false;
            // 
            // imagesGroupBox
            // 
            this.imagesGroupBox.Controls.Add(this.previousImageButton);
            this.imagesGroupBox.Controls.Add(this.nextImageButton);
            this.imagesGroupBox.Controls.Add(this.loadImagesFromDirectoryButton);
            this.imagesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.imagesGroupBox.Location = new System.Drawing.Point(6, 19);
            this.imagesGroupBox.Name = "imagesGroupBox";
            this.imagesGroupBox.Size = new System.Drawing.Size(162, 113);
            this.imagesGroupBox.TabIndex = 7;
            this.imagesGroupBox.TabStop = false;
            this.imagesGroupBox.Text = "Images Actions";
            // 
            // previousImageButton
            // 
            this.previousImageButton.Location = new System.Drawing.Point(6, 65);
            this.previousImageButton.Name = "previousImageButton";
            this.previousImageButton.Size = new System.Drawing.Size(72, 40);
            this.previousImageButton.TabIndex = 8;
            this.previousImageButton.Text = "< Previous";
            this.previousImageButton.UseVisualStyleBackColor = true;
            this.previousImageButton.Click += new System.EventHandler(this.PreviousImageButtonClick);
            // 
            // nextImageButton
            // 
            this.nextImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextImageButton.Location = new System.Drawing.Point(84, 65);
            this.nextImageButton.Name = "nextImageButton";
            this.nextImageButton.Size = new System.Drawing.Size(72, 40);
            this.nextImageButton.TabIndex = 7;
            this.nextImageButton.Text = "Next >";
            this.nextImageButton.UseVisualStyleBackColor = true;
            this.nextImageButton.Click += new System.EventHandler(this.NextImageButtonClick);
            // 
            // loadImagesFromDirectoryButton
            // 
            this.loadImagesFromDirectoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadImagesFromDirectoryButton.Location = new System.Drawing.Point(6, 19);
            this.loadImagesFromDirectoryButton.Name = "loadImagesFromDirectoryButton";
            this.loadImagesFromDirectoryButton.Size = new System.Drawing.Size(150, 40);
            this.loadImagesFromDirectoryButton.TabIndex = 3;
            this.loadImagesFromDirectoryButton.Text = "Load Images From Directory";
            this.loadImagesFromDirectoryButton.UseVisualStyleBackColor = true;
            this.loadImagesFromDirectoryButton.Click += new System.EventHandler(this.LoadImageButtonClick);
            // 
            // thumbnailActionsGroupBox
            // 
            this.thumbnailActionsGroupBox.Controls.Add(this.saveThumbnailImageButton);
            this.thumbnailActionsGroupBox.Controls.Add(this.resizeImageToThumbnailButton);
            this.thumbnailActionsGroupBox.Location = new System.Drawing.Point(6, 138);
            this.thumbnailActionsGroupBox.Name = "thumbnailActionsGroupBox";
            this.thumbnailActionsGroupBox.Size = new System.Drawing.Size(162, 113);
            this.thumbnailActionsGroupBox.TabIndex = 7;
            this.thumbnailActionsGroupBox.TabStop = false;
            this.thumbnailActionsGroupBox.Text = "Thumbnail Actions";
            // 
            // saveThumbnailImageButton
            // 
            this.saveThumbnailImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.saveThumbnailImageButton.Location = new System.Drawing.Point(6, 65);
            this.saveThumbnailImageButton.Name = "saveThumbnailImageButton";
            this.saveThumbnailImageButton.Size = new System.Drawing.Size(150, 40);
            this.saveThumbnailImageButton.TabIndex = 9;
            this.saveThumbnailImageButton.Text = "Save Thumbnail Image";
            this.saveThumbnailImageButton.UseVisualStyleBackColor = true;
            this.saveThumbnailImageButton.Click += new System.EventHandler(this.SaveThumbnailImageButtonClick);
            // 
            // originalImagesView
            // 
            this.originalImagesView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originalImagesView.Controls.Add(this.imagesToResizeListView);
            this.originalImagesView.Controls.Add(this.imagesListBox);
            this.originalImagesView.Controls.Add(this.originalImagePictureBox);
            this.originalImagesView.Location = new System.Drawing.Point(174, 19);
            this.originalImagesView.Name = "originalImagesView";
            this.originalImagesView.Size = new System.Drawing.Size(980, 685);
            this.originalImagesView.TabIndex = 11;
            this.originalImagesView.TabStop = false;
            this.originalImagesView.Text = "Original Images View";
            // 
            // imagesToResizeListView
            // 
            this.imagesToResizeListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesToResizeListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagesToResizeListView.GridLines = true;
            this.imagesToResizeListView.LabelWrap = false;
            this.imagesToResizeListView.Location = new System.Drawing.Point(759, 238);
            this.imagesToResizeListView.MultiSelect = false;
            this.imagesToResizeListView.Name = "imagesToResizeListView";
            this.imagesToResizeListView.Size = new System.Drawing.Size(215, 441);
            this.imagesToResizeListView.TabIndex = 3;
            this.imagesToResizeListView.TileSize = new System.Drawing.Size(168, 64);
            this.imagesToResizeListView.UseCompatibleStateImageBehavior = false;
            // 
            // imagesListBox
            // 
            this.imagesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imagesListBox.FormattingEnabled = true;
            this.imagesListBox.IntegralHeight = false;
            this.imagesListBox.Location = new System.Drawing.Point(759, 19);
            this.imagesListBox.Name = "imagesListBox";
            this.imagesListBox.Size = new System.Drawing.Size(215, 213);
            this.imagesListBox.TabIndex = 2;
            this.imagesListBox.SelectedIndexChanged += new System.EventHandler(this.ImagesListBoxSelectedIndexChanged);
            // 
            // originalImagePictureBox
            // 
            this.originalImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.originalImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalImagePictureBox.Location = new System.Drawing.Point(6, 19);
            this.originalImagePictureBox.Name = "originalImagePictureBox";
            this.originalImagePictureBox.Size = new System.Drawing.Size(747, 660);
            this.originalImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalImagePictureBox.TabIndex = 1;
            this.originalImagePictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.extrasToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveThumbnailBatchToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // saveThumbnailBatchToolStripMenuItem
            // 
            this.saveThumbnailBatchToolStripMenuItem.Name = "saveThumbnailBatchToolStripMenuItem";
            this.saveThumbnailBatchToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.saveThumbnailBatchToolStripMenuItem.Text = "Save Thumbnail Batch...";
            this.saveThumbnailBatchToolStripMenuItem.Click += new System.EventHandler(this.SaveThumbnailBatchToolStripMenuItemClick);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagesBasePathToolStripStatusLabel,
            this.imagesBasePathValueToolStripStatusLabel,
            this.selectBaseDirectoryToolStripSplitButton,
            this.separatorToolStripStatusLabel,
            this.loadedImageNameToolStripStatusLabel,
            this.loadedImageNameValueToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 740);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // imagesBasePathToolStripStatusLabel
            // 
            this.imagesBasePathToolStripStatusLabel.Name = "imagesBasePathToolStripStatusLabel";
            this.imagesBasePathToolStripStatusLabel.Size = new System.Drawing.Size(102, 17);
            this.imagesBasePathToolStripStatusLabel.Text = "Images Base Path:";
            // 
            // imagesBasePathValueToolStripStatusLabel
            // 
            this.imagesBasePathValueToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.imagesBasePathValueToolStripStatusLabel.Name = "imagesBasePathValueToolStripStatusLabel";
            this.imagesBasePathValueToolStripStatusLabel.Size = new System.Drawing.Size(51, 17);
            this.imagesBasePathValueToolStripStatusLabel.Text = "<none>";
            // 
            // selectBaseDirectoryToolStripSplitButton
            // 
            this.selectBaseDirectoryToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.selectBaseDirectoryToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectBaseDirectoryToolStripMenuItem});
            this.selectBaseDirectoryToolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("selectBaseDirectoryToolStripSplitButton.Image")));
            this.selectBaseDirectoryToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.selectBaseDirectoryToolStripSplitButton.Name = "selectBaseDirectoryToolStripSplitButton";
            this.selectBaseDirectoryToolStripSplitButton.Size = new System.Drawing.Size(32, 20);
            this.selectBaseDirectoryToolStripSplitButton.Text = "selectBaseDirectoryToolStripSplitButton";
            this.selectBaseDirectoryToolStripSplitButton.ButtonClick += new System.EventHandler(this.SelectBaseDirectoryToolStripSplitButtonClick);
            // 
            // selectBaseDirectoryToolStripMenuItem
            // 
            this.selectBaseDirectoryToolStripMenuItem.Name = "selectBaseDirectoryToolStripMenuItem";
            this.selectBaseDirectoryToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.selectBaseDirectoryToolStripMenuItem.Text = "Select Base Directory...";
            // 
            // separatorToolStripStatusLabel
            // 
            this.separatorToolStripStatusLabel.Name = "separatorToolStripStatusLabel";
            this.separatorToolStripStatusLabel.Size = new System.Drawing.Size(16, 17);
            this.separatorToolStripStatusLabel.Text = " : ";
            // 
            // loadedImageNameToolStripStatusLabel
            // 
            this.loadedImageNameToolStripStatusLabel.Name = "loadedImageNameToolStripStatusLabel";
            this.loadedImageNameToolStripStatusLabel.Size = new System.Drawing.Size(123, 17);
            this.loadedImageNameToolStripStatusLabel.Text = "Loaded Image Name: ";
            // 
            // loadedImageNameValueToolStripStatusLabel
            // 
            this.loadedImageNameValueToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.loadedImageNameValueToolStripStatusLabel.Name = "loadedImageNameValueToolStripStatusLabel";
            this.loadedImageNameValueToolStripStatusLabel.Size = new System.Drawing.Size(12, 17);
            this.loadedImageNameValueToolStripStatusLabel.Text = "-";
            // 
            // ImageConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.controlPanelGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "ImageConverterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image2Thumbnail v1.0";
            this.controlPanelGroupBox.ResumeLayout(false);
            this.thumbnailImagePreviewGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImagePictureBox)).EndInit();
            this.imagesGroupBox.ResumeLayout(false);
            this.thumbnailActionsGroupBox.ResumeLayout(false);
            this.originalImagesView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.originalImagePictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resizeImageToThumbnailButton;
        private System.Windows.Forms.GroupBox controlPanelGroupBox;
        private System.Windows.Forms.PictureBox originalImagePictureBox;
        private System.Windows.Forms.Button loadImagesFromDirectoryButton;
        private System.Windows.Forms.Button saveThumbnailImageButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel imagesBasePathToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel imagesBasePathValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem saveThumbnailBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel separatorToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel loadedImageNameToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel loadedImageNameValueToolStripStatusLabel;
        private System.Windows.Forms.GroupBox imagesGroupBox;
        private System.Windows.Forms.Button previousImageButton;
        private System.Windows.Forms.Button nextImageButton;
        private System.Windows.Forms.GroupBox thumbnailActionsGroupBox;
        private System.Windows.Forms.GroupBox originalImagesView;
        private System.Windows.Forms.ToolStripSplitButton selectBaseDirectoryToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem selectBaseDirectoryToolStripMenuItem;
        private System.Windows.Forms.GroupBox thumbnailImagePreviewGroupBox;
        private System.Windows.Forms.PictureBox thumbnailImagePictureBox;
        private System.Windows.Forms.ListBox imagesListBox;
        private System.Windows.Forms.ListView imagesToResizeListView;
        private System.Windows.Forms.Button button1;
    }
}

