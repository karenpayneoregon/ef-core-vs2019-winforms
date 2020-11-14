namespace NorthWindApplication
{
    partial class CustomersTestForm
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
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExportByCountryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Location = new System.Drawing.Point(12, 32);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(337, 23);
            this.CountryComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Country list";
            // 
            // ExportByCountryButton
            // 
            this.ExportByCountryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExportByCountryButton.Location = new System.Drawing.Point(12, 75);
            this.ExportByCountryButton.Name = "ExportByCountryButton";
            this.ExportByCountryButton.Size = new System.Drawing.Size(337, 30);
            this.ExportByCountryButton.TabIndex = 0;
            this.ExportByCountryButton.Text = "Export by country to comma delimited .csv file";
            this.ExportByCountryButton.UseVisualStyleBackColor = true;
            this.ExportByCountryButton.Click += new System.EventHandler(this.ExportByCountryButton_Click);
            // 
            // CustomersTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 120);
            this.Controls.Add(this.ExportByCountryButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CountryComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomersTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# 8 Code sample: Using declarations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ExportByCountryButton;
    }
}