namespace ImageConverter
{
    partial class ImageBatchSaverForm
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
            this.controlPanelGroupBox = new System.Windows.Forms.GroupBox();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.saveAllImagesAsThumbnailsButton = new System.Windows.Forms.Button();
            this.unloadImagesButton = new System.Windows.Forms.Button();
            this.loadImagesButton = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.loadedImagesToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.loadedImagesValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.controlPanelGroupBox.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanelGroupBox
            // 
            this.controlPanelGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanelGroupBox.Controls.Add(this.controlsPanel);
            this.controlPanelGroupBox.Controls.Add(this.listBox);
            this.controlPanelGroupBox.Location = new System.Drawing.Point(12, 27);
            this.controlPanelGroupBox.Name = "controlPanelGroupBox";
            this.controlPanelGroupBox.Size = new System.Drawing.Size(560, 390);
            this.controlPanelGroupBox.TabIndex = 0;
            this.controlPanelGroupBox.TabStop = false;
            this.controlPanelGroupBox.Text = "Control Panel";
            // 
            // controlsPanel
            // 
            this.controlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.controlsPanel.Controls.Add(this.saveAllImagesAsThumbnailsButton);
            this.controlsPanel.Controls.Add(this.unloadImagesButton);
            this.controlsPanel.Controls.Add(this.loadImagesButton);
            this.controlsPanel.Location = new System.Drawing.Point(6, 19);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(184, 365);
            this.controlsPanel.TabIndex = 2;
            // 
            // saveAllImagesAsThumbnailsButton
            // 
            this.saveAllImagesAsThumbnailsButton.Location = new System.Drawing.Point(3, 63);
            this.saveAllImagesAsThumbnailsButton.Name = "saveAllImagesAsThumbnailsButton";
            this.saveAllImagesAsThumbnailsButton.Size = new System.Drawing.Size(178, 54);
            this.saveAllImagesAsThumbnailsButton.TabIndex = 3;
            this.saveAllImagesAsThumbnailsButton.Text = "Save All Images As Thumbnails ";
            this.saveAllImagesAsThumbnailsButton.UseVisualStyleBackColor = true;
            this.saveAllImagesAsThumbnailsButton.Click += new System.EventHandler(this.SaveAllImagesAsThumbnailsButtonClick);
            // 
            // unloadImagesButton
            // 
            this.unloadImagesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.unloadImagesButton.Location = new System.Drawing.Point(3, 308);
            this.unloadImagesButton.Name = "unloadImagesButton";
            this.unloadImagesButton.Size = new System.Drawing.Size(178, 54);
            this.unloadImagesButton.TabIndex = 2;
            this.unloadImagesButton.Text = "Unload Images";
            this.unloadImagesButton.UseVisualStyleBackColor = true;
            this.unloadImagesButton.Click += new System.EventHandler(this.UnloadImagesButtonClick);
            // 
            // loadImagesButton
            // 
            this.loadImagesButton.Location = new System.Drawing.Point(3, 3);
            this.loadImagesButton.Name = "loadImagesButton";
            this.loadImagesButton.Size = new System.Drawing.Size(178, 54);
            this.loadImagesButton.TabIndex = 1;
            this.loadImagesButton.Text = "Load Images...";
            this.loadImagesButton.UseVisualStyleBackColor = true;
            this.loadImagesButton.Click += new System.EventHandler(this.LoadImagesButtonClick);
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.FormattingEnabled = true;
            this.listBox.IntegralHeight = false;
            this.listBox.Location = new System.Drawing.Point(200, 22);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(354, 359);
            this.listBox.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(584, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeFormToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // closeFormToolStripMenuItem
            // 
            this.closeFormToolStripMenuItem.Name = "closeFormToolStripMenuItem";
            this.closeFormToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeFormToolStripMenuItem.Text = "Close";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadedImagesToolStripStatusLabel,
            this.loadedImagesValueToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 420);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(584, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // loadedImagesToolStripStatusLabel
            // 
            this.loadedImagesToolStripStatusLabel.Name = "loadedImagesToolStripStatusLabel";
            this.loadedImagesToolStripStatusLabel.Size = new System.Drawing.Size(90, 17);
            this.loadedImagesToolStripStatusLabel.Text = "Loaded Images:";
            // 
            // loadedImagesValueToolStripStatusLabel
            // 
            this.loadedImagesValueToolStripStatusLabel.Name = "loadedImagesValueToolStripStatusLabel";
            this.loadedImagesValueToolStripStatusLabel.Size = new System.Drawing.Size(12, 17);
            this.loadedImagesValueToolStripStatusLabel.Text = "-";
            // 
            // ImageBatchSaverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.controlPanelGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "ImageBatchSaverForm";
            this.Text = "Image2Thumbnail Batch Saver";
            this.controlPanelGroupBox.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox controlPanelGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Button loadImagesButton;
        private System.Windows.Forms.Button unloadImagesButton;
        private System.Windows.Forms.Button saveAllImagesAsThumbnailsButton;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel loadedImagesToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel loadedImagesValueToolStripStatusLabel;
    }
}