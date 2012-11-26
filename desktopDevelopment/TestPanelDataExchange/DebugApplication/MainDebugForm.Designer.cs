namespace TestPanelCommLib
{
    partial class MainDebugForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.controlPanelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanelGroupBox
            // 
            this.controlPanelGroupBox.Controls.Add(this.listBox1);
            this.controlPanelGroupBox.Location = new System.Drawing.Point(12, 12);
            this.controlPanelGroupBox.Name = "controlPanelGroupBox";
            this.controlPanelGroupBox.Size = new System.Drawing.Size(888, 521);
            this.controlPanelGroupBox.TabIndex = 0;
            this.controlPanelGroupBox.TabStop = false;
            this.controlPanelGroupBox.Text = "Control Panel";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(287, 496);
            this.listBox1.TabIndex = 0;
            // 
            // MainDebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 545);
            this.Controls.Add(this.controlPanelGroupBox);
            this.Name = "MainDebugForm";
            this.Text = "Debug Application";
            this.controlPanelGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlPanelGroupBox;
        private System.Windows.Forms.ListBox listBox1;
    }
}

