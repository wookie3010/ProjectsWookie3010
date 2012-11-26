namespace LaCocoBoutiqueAdministration
{
    partial class ValueSetterForm
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
            this.newValueGroupBox = new System.Windows.Forms.GroupBox();
            this.applyValueButton = new System.Windows.Forms.Button();
            this.newValueTextBox = new System.Windows.Forms.TextBox();
            this.newValueLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newValueGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newValueGroupBox
            // 
            this.newValueGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newValueGroupBox.Controls.Add(this.cancelButton);
            this.newValueGroupBox.Controls.Add(this.applyValueButton);
            this.newValueGroupBox.Controls.Add(this.newValueTextBox);
            this.newValueGroupBox.Controls.Add(this.newValueLabel);
            this.newValueGroupBox.Location = new System.Drawing.Point(12, 12);
            this.newValueGroupBox.Name = "newValueGroupBox";
            this.newValueGroupBox.Size = new System.Drawing.Size(559, 59);
            this.newValueGroupBox.TabIndex = 0;
            this.newValueGroupBox.TabStop = false;
            // 
            // applyValueButton
            // 
            this.applyValueButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyValueButton.Location = new System.Drawing.Point(348, 20);
            this.applyValueButton.Name = "applyValueButton";
            this.applyValueButton.Size = new System.Drawing.Size(118, 23);
            this.applyValueButton.TabIndex = 2;
            this.applyValueButton.Text = "Apply Value";
            this.applyValueButton.UseVisualStyleBackColor = true;
            this.applyValueButton.Click += new System.EventHandler(this.ApplyValueButtonClick);
            // 
            // newValueTextBox
            // 
            this.newValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newValueTextBox.Location = new System.Drawing.Point(71, 22);
            this.newValueTextBox.Name = "newValueTextBox";
            this.newValueTextBox.Size = new System.Drawing.Size(271, 20);
            this.newValueTextBox.TabIndex = 1;
            // 
            // newValueLabel
            // 
            this.newValueLabel.AutoSize = true;
            this.newValueLabel.Location = new System.Drawing.Point(6, 25);
            this.newValueLabel.Name = "newValueLabel";
            this.newValueLabel.Size = new System.Drawing.Size(59, 13);
            this.newValueLabel.TabIndex = 0;
            this.newValueLabel.Text = "New Value";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(472, 20);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(81, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
            // 
            // ValueSetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 83);
            this.Controls.Add(this.newValueGroupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ValueSetterForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Value Setter :: ";
            this.TopMost = true;
            this.newValueGroupBox.ResumeLayout(false);
            this.newValueGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox newValueGroupBox;
        private System.Windows.Forms.TextBox newValueTextBox;
        private System.Windows.Forms.Label newValueLabel;
        private System.Windows.Forms.Button applyValueButton;
        private System.Windows.Forms.Button cancelButton;
    }
}