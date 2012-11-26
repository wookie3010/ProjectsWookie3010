namespace WorkingTimeObserver
{
    partial class WorkingTimeObserverForm
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
            this.controlPanelGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentTimeLabel = new System.Windows.Forms.Label();
            this.observerDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlPanelGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.observerDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanelGroupBox
            // 
            this.controlPanelGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanelGroupBox.Controls.Add(this.panel1);
            this.controlPanelGroupBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlPanelGroupBox.Location = new System.Drawing.Point(12, 12);
            this.controlPanelGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlPanelGroupBox.Name = "controlPanelGroupBox";
            this.controlPanelGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.controlPanelGroupBox.Size = new System.Drawing.Size(232, 129);
            this.controlPanelGroupBox.TabIndex = 0;
            this.controlPanelGroupBox.TabStop = false;
            this.controlPanelGroupBox.Text = "Control Panel";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentTimeLabel);
            this.panel1.Location = new System.Drawing.Point(6, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 91);
            this.panel1.TabIndex = 1;
            // 
            // currentTimeLabel
            // 
            this.currentTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTimeLabel.AutoSize = true;
            this.currentTimeLabel.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTimeLabel.Location = new System.Drawing.Point(22, 6);
            this.currentTimeLabel.Name = "currentTimeLabel";
            this.currentTimeLabel.Size = new System.Drawing.Size(179, 78);
            this.currentTimeLabel.TabIndex = 0;
            this.currentTimeLabel.Text = "20:00";
            // 
            // observerDataBindingSource
            // 
            this.observerDataBindingSource.DataSource = typeof(WorkingTimeObserver.TimeObserverData);
            // 
            // WorkingTimeObserverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 153);
            this.Controls.Add(this.controlPanelGroupBox);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "WorkingTimeObserverForm";
            this.Text = "Working Time Observer v1.0";
            this.controlPanelGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.observerDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlPanelGroupBox;
        private System.Windows.Forms.Label currentTimeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource observerDataBindingSource;
    }
}

