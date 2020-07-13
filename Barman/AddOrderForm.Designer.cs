namespace Tourism
{
    partial class AddOrderForm
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
            this.OrderDate = new System.Windows.Forms.DateTimePicker();
            this.OrderTime = new System.Windows.Forms.NumericUpDown();
            this.OrderTour = new System.Windows.Forms.ComboBox();
            this.OrderClient = new System.Windows.Forms.ComboBox();
            this.Ok = new System.Windows.Forms.Button();
            this.OrderTimeLabel = new System.Windows.Forms.Label();
            this.OrderDateLabel = new System.Windows.Forms.Label();
            this.OrderTourLabel = new System.Windows.Forms.Label();
            this.OrderClientLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderTime)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderDate
            // 
            this.OrderDate.Location = new System.Drawing.Point(12, 108);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(200, 20);
            this.OrderDate.TabIndex = 50;
            // 
            // OrderTime
            // 
            this.OrderTime.Location = new System.Drawing.Point(12, 146);
            this.OrderTime.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.OrderTime.Name = "OrderTime";
            this.OrderTime.Size = new System.Drawing.Size(200, 20);
            this.OrderTime.TabIndex = 49;
            // 
            // OrderTour
            // 
            this.OrderTour.FormattingEnabled = true;
            this.OrderTour.Location = new System.Drawing.Point(12, 66);
            this.OrderTour.Name = "OrderTour";
            this.OrderTour.Size = new System.Drawing.Size(200, 21);
            this.OrderTour.TabIndex = 48;
            // 
            // OrderClient
            // 
            this.OrderClient.FormattingEnabled = true;
            this.OrderClient.Location = new System.Drawing.Point(12, 27);
            this.OrderClient.Name = "OrderClient";
            this.OrderClient.Size = new System.Drawing.Size(200, 21);
            this.OrderClient.TabIndex = 47;
            // 
            // Ok
            // 
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Location = new System.Drawing.Point(12, 172);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(97, 23);
            this.Ok.TabIndex = 46;
            this.Ok.Text = "Принять";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // OrderTimeLabel
            // 
            this.OrderTimeLabel.AutoSize = true;
            this.OrderTimeLabel.Location = new System.Drawing.Point(11, 131);
            this.OrderTimeLabel.Name = "OrderTimeLabel";
            this.OrderTimeLabel.Size = new System.Drawing.Size(111, 13);
            this.OrderTimeLabel.TabIndex = 45;
            this.OrderTimeLabel.Text = "Продолжительность";
            // 
            // OrderDateLabel
            // 
            this.OrderDateLabel.AutoSize = true;
            this.OrderDateLabel.Location = new System.Drawing.Point(11, 90);
            this.OrderDateLabel.Name = "OrderDateLabel";
            this.OrderDateLabel.Size = new System.Drawing.Size(78, 13);
            this.OrderDateLabel.TabIndex = 44;
            this.OrderDateLabel.Text = "Дата отъезда";
            // 
            // OrderTourLabel
            // 
            this.OrderTourLabel.AutoSize = true;
            this.OrderTourLabel.Location = new System.Drawing.Point(9, 51);
            this.OrderTourLabel.Name = "OrderTourLabel";
            this.OrderTourLabel.Size = new System.Drawing.Size(25, 13);
            this.OrderTourLabel.TabIndex = 43;
            this.OrderTourLabel.Text = "Тур";
            // 
            // OrderClientLabel
            // 
            this.OrderClientLabel.AutoSize = true;
            this.OrderClientLabel.Location = new System.Drawing.Point(9, 11);
            this.OrderClientLabel.Name = "OrderClientLabel";
            this.OrderClientLabel.Size = new System.Drawing.Size(43, 13);
            this.OrderClientLabel.TabIndex = 42;
            this.OrderClientLabel.Text = "Клиент";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(115, 172);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(97, 23);
            this.Cancel.TabIndex = 51;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // AddOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 209);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.OrderTime);
            this.Controls.Add(this.OrderTour);
            this.Controls.Add(this.OrderClient);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.OrderTimeLabel);
            this.Controls.Add(this.OrderDateLabel);
            this.Controls.Add(this.OrderTourLabel);
            this.Controls.Add(this.OrderClientLabel);
            this.Name = "AddOrderForm";
            this.Text = "Добавить заказ";
            ((System.ComponentModel.ISupportInitialize)(this.OrderTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.ComboBox OrderTour;
        protected internal System.Windows.Forms.ComboBox OrderClient;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label OrderTimeLabel;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Label OrderTourLabel;
        private System.Windows.Forms.Label OrderClientLabel;
        private System.Windows.Forms.Button Cancel;
        protected internal System.Windows.Forms.DateTimePicker OrderDate;
        protected internal System.Windows.Forms.NumericUpDown OrderTime;
    }
}