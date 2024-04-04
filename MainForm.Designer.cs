namespace SymbiotResultStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.StatusCodeLabel = new System.Windows.Forms.Label();
            this.AggregateCheckBox = new System.Windows.Forms.CheckBox();
            this.EstimatedCheckBox = new System.Windows.Forms.CheckBox();
            this.DeliveredCheckBox = new System.Windows.Forms.CheckBox();
            this.FlagsGroupBox = new System.Windows.Forms.GroupBox();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ImportedCheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ValidatedCheckBox = new System.Windows.Forms.CheckBox();
            this.FlagsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.AllowDrop = true;
            this.StatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusTextBox.Location = new System.Drawing.Point(12, 26);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(161, 20);
            this.StatusTextBox.TabIndex = 0;
            this.StatusTextBox.TextChanged += new System.EventHandler(this.StatusTextBox_TextChanged);
            // 
            // StatusCodeLabel
            // 
            this.StatusCodeLabel.AutoSize = true;
            this.StatusCodeLabel.Location = new System.Drawing.Point(12, 10);
            this.StatusCodeLabel.Name = "StatusCodeLabel";
            this.StatusCodeLabel.Size = new System.Drawing.Size(67, 13);
            this.StatusCodeLabel.TabIndex = 1;
            this.StatusCodeLabel.Text = "Status code:";
            // 
            // AggregateCheckBox
            // 
            this.AggregateCheckBox.AutoSize = true;
            this.AggregateCheckBox.Enabled = false;
            this.AggregateCheckBox.Location = new System.Drawing.Point(12, 29);
            this.AggregateCheckBox.Name = "AggregateCheckBox";
            this.AggregateCheckBox.Size = new System.Drawing.Size(143, 17);
            this.AggregateCheckBox.TabIndex = 4;
            this.AggregateCheckBox.Tag = "536870912";
            this.AggregateCheckBox.Text = "Aggregate (0x20000000)";
            this.AggregateCheckBox.UseVisualStyleBackColor = true;
            // 
            // EstimatedCheckBox
            // 
            this.EstimatedCheckBox.AutoSize = true;
            this.EstimatedCheckBox.Enabled = false;
            this.EstimatedCheckBox.Location = new System.Drawing.Point(12, 52);
            this.EstimatedCheckBox.Name = "EstimatedCheckBox";
            this.EstimatedCheckBox.Size = new System.Drawing.Size(140, 17);
            this.EstimatedCheckBox.TabIndex = 6;
            this.EstimatedCheckBox.Tag = "1073741824";
            this.EstimatedCheckBox.Text = "Estimated (0x40000000)";
            this.EstimatedCheckBox.UseVisualStyleBackColor = true;
            // 
            // DeliveredCheckBox
            // 
            this.DeliveredCheckBox.AutoSize = true;
            this.DeliveredCheckBox.Enabled = false;
            this.DeliveredCheckBox.Location = new System.Drawing.Point(12, 75);
            this.DeliveredCheckBox.Name = "DeliveredCheckBox";
            this.DeliveredCheckBox.Size = new System.Drawing.Size(139, 17);
            this.DeliveredCheckBox.TabIndex = 7;
            this.DeliveredCheckBox.Tag = "16777216";
            this.DeliveredCheckBox.Text = "Delivered (0x01000000)";
            this.DeliveredCheckBox.UseVisualStyleBackColor = true;
            // 
            // FlagsGroupBox
            // 
            this.FlagsGroupBox.Controls.Add(this.ValidatedCheckBox);
            this.FlagsGroupBox.Controls.Add(this.checkBox1);
            this.FlagsGroupBox.Controls.Add(this.ImportedCheckBox);
            this.FlagsGroupBox.Controls.Add(this.DeliveredCheckBox);
            this.FlagsGroupBox.Controls.Add(this.EstimatedCheckBox);
            this.FlagsGroupBox.Controls.Add(this.AggregateCheckBox);
            this.FlagsGroupBox.Location = new System.Drawing.Point(12, 65);
            this.FlagsGroupBox.Name = "FlagsGroupBox";
            this.FlagsGroupBox.Size = new System.Drawing.Size(161, 180);
            this.FlagsGroupBox.TabIndex = 8;
            this.FlagsGroupBox.TabStop = false;
            this.FlagsGroupBox.Text = "Flags";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Location = new System.Drawing.Point(120, 251);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(53, 20);
            this.ClearAllButton.TabIndex = 9;
            this.ClearAllButton.Text = "Clear";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 49);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 10;
            // 
            // ImportedCheckBox
            // 
            this.ImportedCheckBox.AutoSize = true;
            this.ImportedCheckBox.Enabled = false;
            this.ImportedCheckBox.Location = new System.Drawing.Point(12, 121);
            this.ImportedCheckBox.Name = "ImportedCheckBox";
            this.ImportedCheckBox.Size = new System.Drawing.Size(138, 17);
            this.ImportedCheckBox.TabIndex = 8;
            this.ImportedCheckBox.Tag = "805306368";
            this.ImportedCheckBox.Text = "Imported (0x3000 0000)";
            this.ImportedCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(12, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Tag = "268435456";
            this.checkBox1.Text = "Manual (0x1000 0000)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ValidatedCheckBox
            // 
            this.ValidatedCheckBox.AutoSize = true;
            this.ValidatedCheckBox.Enabled = false;
            this.ValidatedCheckBox.Location = new System.Drawing.Point(12, 98);
            this.ValidatedCheckBox.Name = "ValidatedCheckBox";
            this.ValidatedCheckBox.Size = new System.Drawing.Size(138, 17);
            this.ValidatedCheckBox.TabIndex = 10;
            this.ValidatedCheckBox.Tag = "2147483648";
            this.ValidatedCheckBox.Text = "Validated (0x80000000)";
            this.ValidatedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 286);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.FlagsGroupBox);
            this.Controls.Add(this.StatusCodeLabel);
            this.Controls.Add(this.StatusTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Symbiot status decoder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FlagsGroupBox.ResumeLayout(false);
            this.FlagsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.Label StatusCodeLabel;
        private System.Windows.Forms.CheckBox AggregateCheckBox;
        private System.Windows.Forms.CheckBox EstimatedCheckBox;
        private System.Windows.Forms.CheckBox DeliveredCheckBox;
        private System.Windows.Forms.GroupBox FlagsGroupBox;
        private System.Windows.Forms.Button ClearAllButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox ImportedCheckBox;
        private System.Windows.Forms.CheckBox ValidatedCheckBox;
    }
}

