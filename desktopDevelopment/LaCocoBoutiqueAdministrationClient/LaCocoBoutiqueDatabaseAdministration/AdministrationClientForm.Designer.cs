namespace LaCocoBoutiqueAdministration
{
    partial class AdministrationClientForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createDatabaseBackupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertDatasetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDatasetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.databaseConnectionToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.databaseConnectionValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.webPagesTabPage = new System.Windows.Forms.TabPage();
            this.toolsTabPage = new System.Windows.Forms.TabPage();
            this.externalToolsGroupBox = new System.Windows.Forms.GroupBox();
            this.imageConverterButton = new System.Windows.Forms.Button();
            this.productsTabPage = new System.Windows.Forms.TabPage();
            this.productsDataPanel = new System.Windows.Forms.Panel();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.productsDataGridViewContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateSelectedDiscountValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.updateeSelectedQuantityValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewProductGroupBox = new System.Windows.Forms.GroupBox();
            this.moveNextEntityButton = new System.Windows.Forms.Button();
            this.moveLastEntityButton = new System.Windows.Forms.Button();
            this.movePreviousEntityButton = new System.Windows.Forms.Button();
            this.moveFirstEntityButton = new System.Windows.Forms.Button();
            this.productPanel = new System.Windows.Forms.Panel();
            this.selectThumbnailImagesButton = new System.Windows.Forms.Button();
            this.selectMainImageButton = new System.Windows.Forms.Button();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.relatedThumbnailsLabel = new System.Windows.Forms.Label();
            this.thumbnailsListView = new System.Windows.Forms.ListView();
            this.mainImageLabel = new System.Windows.Forms.Label();
            this.mainImagePictureBox = new System.Windows.Forms.PictureBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.discountLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.orderCodeTextBox = new System.Windows.Forms.TextBox();
            this.orderCodeLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.setProductButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.productCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.toolsTabPage.SuspendLayout();
            this.externalToolsGroupBox.SuspendLayout();
            this.productsTabPage.SuspendLayout();
            this.productsDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.productsDataGridViewContextMenuStrip.SuspendLayout();
            this.insertNewProductGroupBox.SuspendLayout();
            this.productPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImagePictureBox)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createDatabaseBackupToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // createDatabaseBackupToolStripMenuItem
            // 
            this.createDatabaseBackupToolStripMenuItem.Name = "createDatabaseBackupToolStripMenuItem";
            this.createDatabaseBackupToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.createDatabaseBackupToolStripMenuItem.Text = "Create Database Backup";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertDatasetToolStripMenuItem,
            this.deleteDatasetToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // insertDatasetToolStripMenuItem
            // 
            this.insertDatasetToolStripMenuItem.Name = "insertDatasetToolStripMenuItem";
            this.insertDatasetToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.insertDatasetToolStripMenuItem.Text = "Insert Dataset...";
            this.insertDatasetToolStripMenuItem.Click += new System.EventHandler(this.InsertDatasetToolStripMenuItemClick);
            // 
            // deleteDatasetToolStripMenuItem
            // 
            this.deleteDatasetToolStripMenuItem.Name = "deleteDatasetToolStripMenuItem";
            this.deleteDatasetToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.deleteDatasetToolStripMenuItem.Text = "Delete Dataset...";
            this.deleteDatasetToolStripMenuItem.Click += new System.EventHandler(this.DeleteDatasetToolStripMenuItemClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseConnectionToolStripStatusLabel,
            this.databaseConnectionValueToolStripStatusLabel,
            this.toolStripStatusLabel3});
            this.statusStrip.Location = new System.Drawing.Point(0, 710);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip";
            // 
            // databaseConnectionToolStripStatusLabel
            // 
            this.databaseConnectionToolStripStatusLabel.Name = "databaseConnectionToolStripStatusLabel";
            this.databaseConnectionToolStripStatusLabel.Size = new System.Drawing.Size(123, 17);
            this.databaseConnectionToolStripStatusLabel.Text = "Database Connection:";
            // 
            // databaseConnectionValueToolStripStatusLabel
            // 
            this.databaseConnectionValueToolStripStatusLabel.Name = "databaseConnectionValueToolStripStatusLabel";
            this.databaseConnectionValueToolStripStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.databaseConnectionValueToolStripStatusLabel.Text = "<none>";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel3.Text = "||";
            // 
            // webPagesTabPage
            // 
            this.webPagesTabPage.Location = new System.Drawing.Point(4, 22);
            this.webPagesTabPage.Name = "webPagesTabPage";
            this.webPagesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.webPagesTabPage.Size = new System.Drawing.Size(1152, 654);
            this.webPagesTabPage.TabIndex = 2;
            this.webPagesTabPage.Text = "Web Pages";
            this.webPagesTabPage.UseVisualStyleBackColor = true;
            // 
            // toolsTabPage
            // 
            this.toolsTabPage.Controls.Add(this.externalToolsGroupBox);
            this.toolsTabPage.Location = new System.Drawing.Point(4, 22);
            this.toolsTabPage.Name = "toolsTabPage";
            this.toolsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.toolsTabPage.Size = new System.Drawing.Size(1152, 654);
            this.toolsTabPage.TabIndex = 1;
            this.toolsTabPage.Text = "Tools";
            this.toolsTabPage.UseVisualStyleBackColor = true;
            // 
            // externalToolsGroupBox
            // 
            this.externalToolsGroupBox.Controls.Add(this.imageConverterButton);
            this.externalToolsGroupBox.Location = new System.Drawing.Point(337, 100);
            this.externalToolsGroupBox.Name = "externalToolsGroupBox";
            this.externalToolsGroupBox.Size = new System.Drawing.Size(490, 438);
            this.externalToolsGroupBox.TabIndex = 0;
            this.externalToolsGroupBox.TabStop = false;
            this.externalToolsGroupBox.Text = "External Tools";
            // 
            // imageConverterButton
            // 
            this.imageConverterButton.Location = new System.Drawing.Point(53, 54);
            this.imageConverterButton.Name = "imageConverterButton";
            this.imageConverterButton.Size = new System.Drawing.Size(386, 66);
            this.imageConverterButton.TabIndex = 0;
            this.imageConverterButton.Text = "Image Converter";
            this.imageConverterButton.UseVisualStyleBackColor = true;
            this.imageConverterButton.Click += new System.EventHandler(this.ImageConverterButtonClick);
            // 
            // productsTabPage
            // 
            this.productsTabPage.Controls.Add(this.productsDataPanel);
            this.productsTabPage.Controls.Add(this.insertNewProductGroupBox);
            this.productsTabPage.Location = new System.Drawing.Point(4, 22);
            this.productsTabPage.Name = "productsTabPage";
            this.productsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.productsTabPage.Size = new System.Drawing.Size(1152, 654);
            this.productsTabPage.TabIndex = 0;
            this.productsTabPage.Text = "Products";
            this.productsTabPage.UseVisualStyleBackColor = true;
            // 
            // productsDataPanel
            // 
            this.productsDataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDataPanel.Controls.Add(this.moveNextEntityButton);
            this.productsDataPanel.Controls.Add(this.productsDataGridView);
            this.productsDataPanel.Controls.Add(this.moveLastEntityButton);
            this.productsDataPanel.Controls.Add(this.moveFirstEntityButton);
            this.productsDataPanel.Controls.Add(this.movePreviousEntityButton);
            this.productsDataPanel.Location = new System.Drawing.Point(6, 6);
            this.productsDataPanel.Name = "productsDataPanel";
            this.productsDataPanel.Size = new System.Drawing.Size(767, 642);
            this.productsDataPanel.TabIndex = 3;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.ContextMenuStrip = this.productsDataGridViewContextMenuStrip;
            this.productsDataGridView.Location = new System.Drawing.Point(3, 43);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsDataGridView.Size = new System.Drawing.Size(761, 593);
            this.productsDataGridView.TabIndex = 1;
            // 
            // productsDataGridViewContextMenuStrip
            // 
            this.productsDataGridViewContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateSelectedDiscountValuesToolStripMenuItem,
            this.toolStripSeparator2,
            this.updateeSelectedQuantityValuesToolStripMenuItem});
            this.productsDataGridViewContextMenuStrip.Name = "productsDataGridViewContextMenuStrip";
            this.productsDataGridViewContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.productsDataGridViewContextMenuStrip.Size = new System.Drawing.Size(209, 54);
            // 
            // updateSelectedDiscountValuesToolStripMenuItem
            // 
            this.updateSelectedDiscountValuesToolStripMenuItem.Name = "updateSelectedDiscountValuesToolStripMenuItem";
            this.updateSelectedDiscountValuesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.updateSelectedDiscountValuesToolStripMenuItem.Text = "Update Discount Values...";
            this.updateSelectedDiscountValuesToolStripMenuItem.Click += new System.EventHandler(this.UpdateSelectedDiscountValuesToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // updateeSelectedQuantityValuesToolStripMenuItem
            // 
            this.updateeSelectedQuantityValuesToolStripMenuItem.Name = "updateeSelectedQuantityValuesToolStripMenuItem";
            this.updateeSelectedQuantityValuesToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.updateeSelectedQuantityValuesToolStripMenuItem.Text = "Update Quantity Values...";
            this.updateeSelectedQuantityValuesToolStripMenuItem.Click += new System.EventHandler(this.UpdateSelectedQuantityValuesToolStripMenuItemClick);
            // 
            // insertNewProductGroupBox
            // 
            this.insertNewProductGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insertNewProductGroupBox.Controls.Add(this.productPanel);
            this.insertNewProductGroupBox.Controls.Add(this.setProductButton);
            this.insertNewProductGroupBox.Location = new System.Drawing.Point(779, 6);
            this.insertNewProductGroupBox.Name = "insertNewProductGroupBox";
            this.insertNewProductGroupBox.Size = new System.Drawing.Size(367, 642);
            this.insertNewProductGroupBox.TabIndex = 2;
            this.insertNewProductGroupBox.TabStop = false;
            this.insertNewProductGroupBox.Text = "Insert New Product";
            // 
            // moveNextEntityButton
            // 
            this.moveNextEntityButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveNextEntityButton.Location = new System.Drawing.Point(434, 3);
            this.moveNextEntityButton.Name = "moveNextEntityButton";
            this.moveNextEntityButton.Size = new System.Drawing.Size(162, 34);
            this.moveNextEntityButton.TabIndex = 19;
            this.moveNextEntityButton.Text = ">";
            this.moveNextEntityButton.UseVisualStyleBackColor = true;
            this.moveNextEntityButton.Click += new System.EventHandler(this.MoveNextEntityButtonClick);
            // 
            // moveLastEntityButton
            // 
            this.moveLastEntityButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveLastEntityButton.Location = new System.Drawing.Point(602, 3);
            this.moveLastEntityButton.Name = "moveLastEntityButton";
            this.moveLastEntityButton.Size = new System.Drawing.Size(162, 34);
            this.moveLastEntityButton.TabIndex = 18;
            this.moveLastEntityButton.Text = ">>";
            this.moveLastEntityButton.UseVisualStyleBackColor = true;
            this.moveLastEntityButton.Click += new System.EventHandler(this.MoveLastEntityButtonClick);
            // 
            // movePreviousEntityButton
            // 
            this.movePreviousEntityButton.Location = new System.Drawing.Point(171, 3);
            this.movePreviousEntityButton.Name = "movePreviousEntityButton";
            this.movePreviousEntityButton.Size = new System.Drawing.Size(162, 34);
            this.movePreviousEntityButton.TabIndex = 17;
            this.movePreviousEntityButton.Text = "<";
            this.movePreviousEntityButton.UseVisualStyleBackColor = true;
            this.movePreviousEntityButton.Click += new System.EventHandler(this.MovePreviousEntityButtonClick);
            // 
            // moveFirstEntityButton
            // 
            this.moveFirstEntityButton.Location = new System.Drawing.Point(3, 3);
            this.moveFirstEntityButton.Name = "moveFirstEntityButton";
            this.moveFirstEntityButton.Size = new System.Drawing.Size(162, 34);
            this.moveFirstEntityButton.TabIndex = 16;
            this.moveFirstEntityButton.Text = "<<";
            this.moveFirstEntityButton.UseVisualStyleBackColor = true;
            this.moveFirstEntityButton.Click += new System.EventHandler(this.MoveFirstEntityButtonClick);
            // 
            // productPanel
            // 
            this.productPanel.Controls.Add(this.selectThumbnailImagesButton);
            this.productPanel.Controls.Add(this.selectMainImageButton);
            this.productPanel.Controls.Add(this.productIdTextBox);
            this.productPanel.Controls.Add(this.productIdLabel);
            this.productPanel.Controls.Add(this.relatedThumbnailsLabel);
            this.productPanel.Controls.Add(this.thumbnailsListView);
            this.productPanel.Controls.Add(this.mainImageLabel);
            this.productPanel.Controls.Add(this.mainImagePictureBox);
            this.productPanel.Controls.Add(this.categoryComboBox);
            this.productPanel.Controls.Add(this.discountLabel);
            this.productPanel.Controls.Add(this.priceLabel);
            this.productPanel.Controls.Add(this.discountTextBox);
            this.productPanel.Controls.Add(this.priceTextBox);
            this.productPanel.Controls.Add(this.quantityLabel);
            this.productPanel.Controls.Add(this.quantityTextBox);
            this.productPanel.Controls.Add(this.orderCodeTextBox);
            this.productPanel.Controls.Add(this.orderCodeLabel);
            this.productPanel.Controls.Add(this.nameLabel);
            this.productPanel.Controls.Add(this.nameTextBox);
            this.productPanel.Controls.Add(this.categoryLabel);
            this.productPanel.Location = new System.Drawing.Point(9, 19);
            this.productPanel.Name = "productPanel";
            this.productPanel.Size = new System.Drawing.Size(351, 578);
            this.productPanel.TabIndex = 14;
            // 
            // selectThumbnailImagesButton
            // 
            this.selectThumbnailImagesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectThumbnailImagesButton.Location = new System.Drawing.Point(3, 552);
            this.selectThumbnailImagesButton.Name = "selectThumbnailImagesButton";
            this.selectThumbnailImagesButton.Size = new System.Drawing.Size(345, 23);
            this.selectThumbnailImagesButton.TabIndex = 23;
            this.selectThumbnailImagesButton.Text = "Select Thumbnail Images";
            this.selectThumbnailImagesButton.UseVisualStyleBackColor = true;
            this.selectThumbnailImagesButton.Click += new System.EventHandler(this.SelectThumbnailImagesButtonClick);
            // 
            // selectMainImageButton
            // 
            this.selectMainImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectMainImageButton.Location = new System.Drawing.Point(139, 394);
            this.selectMainImageButton.Name = "selectMainImageButton";
            this.selectMainImageButton.Size = new System.Drawing.Size(209, 23);
            this.selectMainImageButton.TabIndex = 22;
            this.selectMainImageButton.Text = "Select Main Image";
            this.selectMainImageButton.UseVisualStyleBackColor = true;
            this.selectMainImageButton.Click += new System.EventHandler(this.SelectMainImageButtonClick);
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productIdTextBox.Enabled = false;
            this.productIdTextBox.Location = new System.Drawing.Point(139, 6);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(209, 20);
            this.productIdTextBox.TabIndex = 21;
            // 
            // productIdLabel
            // 
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.Location = new System.Drawing.Point(3, 8);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(58, 13);
            this.productIdLabel.TabIndex = 20;
            this.productIdLabel.Text = "Product ID";
            // 
            // relatedThumbnailsLabel
            // 
            this.relatedThumbnailsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.relatedThumbnailsLabel.AutoSize = true;
            this.relatedThumbnailsLabel.Location = new System.Drawing.Point(4, 407);
            this.relatedThumbnailsLabel.Name = "relatedThumbnailsLabel";
            this.relatedThumbnailsLabel.Size = new System.Drawing.Size(101, 13);
            this.relatedThumbnailsLabel.TabIndex = 19;
            this.relatedThumbnailsLabel.Text = "Related Thumbnails";
            // 
            // thumbnailsListView
            // 
            this.thumbnailsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thumbnailsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thumbnailsListView.CausesValidation = false;
            this.thumbnailsListView.Location = new System.Drawing.Point(3, 423);
            this.thumbnailsListView.Name = "thumbnailsListView";
            this.thumbnailsListView.Size = new System.Drawing.Size(345, 123);
            this.thumbnailsListView.TabIndex = 18;
            this.thumbnailsListView.UseCompatibleStateImageBehavior = false;
            // 
            // mainImageLabel
            // 
            this.mainImageLabel.AutoSize = true;
            this.mainImageLabel.Location = new System.Drawing.Point(3, 189);
            this.mainImageLabel.Name = "mainImageLabel";
            this.mainImageLabel.Size = new System.Drawing.Size(62, 13);
            this.mainImageLabel.TabIndex = 17;
            this.mainImageLabel.Text = "Main Image";
            // 
            // mainImagePictureBox
            // 
            this.mainImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainImagePictureBox.Location = new System.Drawing.Point(139, 189);
            this.mainImagePictureBox.Name = "mainImagePictureBox";
            this.mainImagePictureBox.Size = new System.Drawing.Size(209, 199);
            this.mainImagePictureBox.TabIndex = 16;
            this.mainImagePictureBox.TabStop = false;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(139, 32);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(209, 21);
            this.categoryComboBox.TabIndex = 12;
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Location = new System.Drawing.Point(3, 165);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(49, 13);
            this.discountLabel.TabIndex = 11;
            this.discountLabel.Text = "Discount";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(3, 139);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 10;
            this.priceLabel.Text = "Price";
            // 
            // discountTextBox
            // 
            this.discountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountTextBox.Location = new System.Drawing.Point(139, 163);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(209, 20);
            this.discountTextBox.TabIndex = 9;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.priceTextBox.Location = new System.Drawing.Point(139, 137);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(209, 20);
            this.priceTextBox.TabIndex = 8;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(3, 113);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 7;
            this.quantityLabel.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityTextBox.Location = new System.Drawing.Point(139, 111);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(209, 20);
            this.quantityTextBox.TabIndex = 6;
            // 
            // orderCodeTextBox
            // 
            this.orderCodeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.orderCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orderCodeTextBox.Location = new System.Drawing.Point(139, 85);
            this.orderCodeTextBox.Name = "orderCodeTextBox";
            this.orderCodeTextBox.Size = new System.Drawing.Size(209, 20);
            this.orderCodeTextBox.TabIndex = 5;
            // 
            // orderCodeLabel
            // 
            this.orderCodeLabel.AutoSize = true;
            this.orderCodeLabel.Location = new System.Drawing.Point(3, 87);
            this.orderCodeLabel.Name = "orderCodeLabel";
            this.orderCodeLabel.Size = new System.Drawing.Size(61, 13);
            this.orderCodeLabel.TabIndex = 4;
            this.orderCodeLabel.Text = "Order Code";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(3, 61);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.Location = new System.Drawing.Point(139, 59);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(209, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(3, 35);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(49, 13);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category";
            // 
            // setProductButton
            // 
            this.setProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.setProductButton.Location = new System.Drawing.Point(12, 603);
            this.setProductButton.Name = "setProductButton";
            this.setProductButton.Size = new System.Drawing.Size(345, 33);
            this.setProductButton.TabIndex = 13;
            this.setProductButton.Text = "Set Product";
            this.setProductButton.UseVisualStyleBackColor = true;
            this.setProductButton.Click += new System.EventHandler(this.SetProductButtonClick);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.productsTabPage);
            this.tabControl.Controls.Add(this.webPagesTabPage);
            this.tabControl.Controls.Add(this.toolsTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1160, 680);
            this.tabControl.TabIndex = 4;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // AdministrationClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 732);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1200, 770);
            this.Name = "AdministrationClientForm";
            this.Text = "LaCocoBoutique Database Administration Client";
            this.Load += new System.EventHandler(this.InsertProductToProductsTableFormLoad);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.toolsTabPage.ResumeLayout(false);
            this.externalToolsGroupBox.ResumeLayout(false);
            this.productsTabPage.ResumeLayout(false);
            this.productsDataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.productsDataGridViewContextMenuStrip.ResumeLayout(false);
            this.insertNewProductGroupBox.ResumeLayout(false);
            this.productPanel.ResumeLayout(false);
            this.productPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainImagePictureBox)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabPage webPagesTabPage;
        private System.Windows.Forms.TabPage toolsTabPage;
        private System.Windows.Forms.TabPage productsTabPage;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.GroupBox insertNewProductGroupBox;
        private System.Windows.Forms.Button setProductButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox discountTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox orderCodeTextBox;
        private System.Windows.Forms.Label orderCodeLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Panel productPanel;
        private System.Windows.Forms.Label relatedThumbnailsLabel;
        private System.Windows.Forms.ListView thumbnailsListView;
        private System.Windows.Forms.Label mainImageLabel;
        private System.Windows.Forms.PictureBox mainImagePictureBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.BindingSource productCategoriesBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.Label productIdLabel;
        private System.Windows.Forms.Button moveNextEntityButton;
        private System.Windows.Forms.Button moveLastEntityButton;
        private System.Windows.Forms.Button movePreviousEntityButton;
        private System.Windows.Forms.Button moveFirstEntityButton;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertDatasetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDatasetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createDatabaseBackupToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel databaseConnectionToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel databaseConnectionValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ContextMenuStrip productsDataGridViewContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem updateSelectedDiscountValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem updateeSelectedQuantityValuesToolStripMenuItem;
        private System.Windows.Forms.GroupBox externalToolsGroupBox;
        private System.Windows.Forms.Button imageConverterButton;
        private System.Windows.Forms.Button selectThumbnailImagesButton;
        private System.Windows.Forms.Button selectMainImageButton;
        private System.Windows.Forms.Panel productsDataPanel;
    }
}