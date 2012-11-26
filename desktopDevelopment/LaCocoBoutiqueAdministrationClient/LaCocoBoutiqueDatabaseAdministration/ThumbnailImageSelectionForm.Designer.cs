namespace LaCocoBoutiqueAdministration
{
    partial class ThumbnailImageSelectionForm
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
            this.components = new System.ComponentModel.Container();
            this.selectedThumbnailImagesListView = new System.Windows.Forms.ListView();
            this.thumbnailImagePictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.applySelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.thumbnailImagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thumbnailImagesTableDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImagePictureBox)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImagesTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectedThumbnailImagesListView
            // 
            this.selectedThumbnailImagesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedThumbnailImagesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectedThumbnailImagesListView.LargeImageList = this.imageList;
            this.selectedThumbnailImagesListView.Location = new System.Drawing.Point(522, 300);
            this.selectedThumbnailImagesListView.Name = "selectedThumbnailImagesListView";
            this.selectedThumbnailImagesListView.Size = new System.Drawing.Size(203, 224);
            this.selectedThumbnailImagesListView.TabIndex = 1;
            this.selectedThumbnailImagesListView.UseCompatibleStateImageBehavior = false;
            // 
            // thumbnailImagePictureBox
            // 
            this.thumbnailImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbnailImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumbnailImagePictureBox.Location = new System.Drawing.Point(522, 27);
            this.thumbnailImagePictureBox.Name = "thumbnailImagePictureBox";
            this.thumbnailImagePictureBox.Size = new System.Drawing.Size(203, 267);
            this.thumbnailImagePictureBox.TabIndex = 2;
            this.thumbnailImagePictureBox.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applySelectionToolStripMenuItem,
            this.cancelSelectionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(737, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // applySelectionToolStripMenuItem
            // 
            this.applySelectionToolStripMenuItem.Name = "applySelectionToolStripMenuItem";
            this.applySelectionToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.applySelectionToolStripMenuItem.Text = "Apply";
            // 
            // cancelSelectionToolStripMenuItem
            // 
            this.cancelSelectionToolStripMenuItem.Name = "cancelSelectionToolStripMenuItem";
            this.cancelSelectionToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.cancelSelectionToolStripMenuItem.Text = "Discard";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(32, 32);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // thumbnailImagesTableDataGridView
            // 
            this.thumbnailImagesTableDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbnailImagesTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.thumbnailImagesTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.thumbnailImagesTableDataGridView.Location = new System.Drawing.Point(12, 27);
            this.thumbnailImagesTableDataGridView.Name = "thumbnailImagesTableDataGridView";
            this.thumbnailImagesTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.thumbnailImagesTableDataGridView.Size = new System.Drawing.Size(504, 497);
            this.thumbnailImagesTableDataGridView.TabIndex = 4;
            // 
            // ThumbnailImageSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 536);
            this.Controls.Add(this.thumbnailImagesTableDataGridView);
            this.Controls.Add(this.thumbnailImagePictureBox);
            this.Controls.Add(this.selectedThumbnailImagesListView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ThumbnailImageSelectionForm";
            this.Text = "Thumbnail Image Selection";
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImagePictureBox)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImagesTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView selectedThumbnailImagesListView;
        private System.Windows.Forms.PictureBox thumbnailImagePictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem applySelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelSelectionToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.BindingSource thumbnailImagesBindingSource;
        private System.Windows.Forms.DataGridView thumbnailImagesTableDataGridView;
    }
}