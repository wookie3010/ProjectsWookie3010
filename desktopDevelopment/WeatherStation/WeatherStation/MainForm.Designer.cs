namespace WeatherStation
{
    partial class MainForm
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
            this.stopMeasurementsButton = new System.Windows.Forms.Button();
            this.activateMeasurementsButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.dataRecordsNumTolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataRecordsNumValueTolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.controlPanelGroupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanelGroupBox
            // 
            this.controlPanelGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanelGroupBox.Controls.Add(this.stopMeasurementsButton);
            this.controlPanelGroupBox.Controls.Add(this.activateMeasurementsButton);
            this.controlPanelGroupBox.Location = new System.Drawing.Point(12, 27);
            this.controlPanelGroupBox.Name = "controlPanelGroupBox";
            this.controlPanelGroupBox.Size = new System.Drawing.Size(562, 404);
            this.controlPanelGroupBox.TabIndex = 0;
            this.controlPanelGroupBox.TabStop = false;
            this.controlPanelGroupBox.Text = "Control Panel";
            // 
            // stopMeasurementsButton
            // 
            this.stopMeasurementsButton.Location = new System.Drawing.Point(436, 52);
            this.stopMeasurementsButton.Name = "stopMeasurementsButton";
            this.stopMeasurementsButton.Size = new System.Drawing.Size(94, 46);
            this.stopMeasurementsButton.TabIndex = 1;
            this.stopMeasurementsButton.Text = "Stop";
            this.stopMeasurementsButton.UseVisualStyleBackColor = true;
            this.stopMeasurementsButton.Click += new System.EventHandler(this.StopMeasurementsButtonClick);
            // 
            // activateMeasurementsButton
            // 
            this.activateMeasurementsButton.Location = new System.Drawing.Point(60, 52);
            this.activateMeasurementsButton.Name = "activateMeasurementsButton";
            this.activateMeasurementsButton.Size = new System.Drawing.Size(340, 46);
            this.activateMeasurementsButton.TabIndex = 0;
            this.activateMeasurementsButton.Text = "Activate Measurements";
            this.activateMeasurementsButton.UseVisualStyleBackColor = true;
            this.activateMeasurementsButton.Click += new System.EventHandler(this.ActivateMeasurementsButtonClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(586, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataRecordsNumTolStripStatusLabel,
            this.dataRecordsNumValueTolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 434);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(586, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // dataRecordsNumTolStripStatusLabel
            // 
            this.dataRecordsNumTolStripStatusLabel.Name = "dataRecordsNumTolStripStatusLabel";
            this.dataRecordsNumTolStripStatusLabel.Size = new System.Drawing.Size(109, 17);
            this.dataRecordsNumTolStripStatusLabel.Text = "Num Data Records:";
            // 
            // dataRecordsNumValueTolStripStatusLabel
            // 
            this.dataRecordsNumValueTolStripStatusLabel.Name = "dataRecordsNumValueTolStripStatusLabel";
            this.dataRecordsNumValueTolStripStatusLabel.Size = new System.Drawing.Size(12, 17);
            this.dataRecordsNumValueTolStripStatusLabel.Text = "-";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 456);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.controlPanelGroupBox);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Weather Station 0.1";
            this.controlPanelGroupBox.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox controlPanelGroupBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button activateMeasurementsButton;
        private System.Windows.Forms.Button stopMeasurementsButton;
        private System.Windows.Forms.ToolStripStatusLabel dataRecordsNumTolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel dataRecordsNumValueTolStripStatusLabel;
    }
}

