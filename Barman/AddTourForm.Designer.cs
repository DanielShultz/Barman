namespace Tourism
{
    partial class AddTourForm
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
            this.PriceTour = new System.Windows.Forms.NumericUpDown();
            this.Ok = new System.Windows.Forms.Button();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.CountryTour = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriceTour)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceTour
            // 
            this.PriceTour.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.PriceTour.Location = new System.Drawing.Point(12, 65);
            this.PriceTour.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PriceTour.Name = "PriceTour";
            this.PriceTour.Size = new System.Drawing.Size(206, 20);
            this.PriceTour.TabIndex = 33;
            // 
            // Ok
            // 
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Location = new System.Drawing.Point(12, 91);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(100, 23);
            this.Ok.TabIndex = 32;
            this.Ok.Text = "Принять";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(12, 48);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(79, 13);
            this.PriceLabel.TabIndex = 31;
            this.PriceLabel.Text = "Цена за сутки";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(12, 9);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(43, 13);
            this.CountryLabel.TabIndex = 28;
            this.CountryLabel.Text = "Страна";
            // 
            // CountryTour
            // 
            this.CountryTour.Location = new System.Drawing.Point(12, 25);
            this.CountryTour.Name = "CountryTour";
            this.CountryTour.Size = new System.Drawing.Size(206, 20);
            this.CountryTour.TabIndex = 27;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(118, 91);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 23);
            this.Cancel.TabIndex = 34;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // AddTourForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 124);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.PriceTour);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.CountryTour);
            this.Name = "AddTourForm";
            this.Text = "Добавить тур";
            ((System.ComponentModel.ISupportInitialize)(this.PriceTour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Button Cancel;
        protected internal System.Windows.Forms.NumericUpDown PriceTour;
        protected internal System.Windows.Forms.TextBox CountryTour;
    }
}