namespace Barman
{
    partial class AddCoctailForm
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
            this.Time = new System.Windows.Forms.NumericUpDown();
            this.Ok = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ingridient = new System.Windows.Forms.ListBox();
            this.LabelIngridient = new System.Windows.Forms.Label();
            this.CoctailLabel = new System.Windows.Forms.Label();
            this.Coctail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(6, 64);
            this.Time.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(206, 20);
            this.Time.TabIndex = 49;
            // 
            // Ok
            // 
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Location = new System.Drawing.Point(6, 243);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(97, 23);
            this.Ok.TabIndex = 46;
            this.Ok.Text = "Принять";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(3, 48);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(83, 13);
            this.TimeLabel.TabIndex = 45;
            this.TimeLabel.Text = "Время готовки";
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(115, 243);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(97, 23);
            this.Cancel.TabIndex = 51;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // Ingridient
            // 
            this.Ingridient.FormattingEnabled = true;
            this.Ingridient.Location = new System.Drawing.Point(6, 103);
            this.Ingridient.Name = "Ingridient";
            this.Ingridient.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Ingridient.Size = new System.Drawing.Size(206, 134);
            this.Ingridient.TabIndex = 53;
            // 
            // LabelIngridient
            // 
            this.LabelIngridient.AutoSize = true;
            this.LabelIngridient.Location = new System.Drawing.Point(3, 87);
            this.LabelIngridient.Name = "LabelIngridient";
            this.LabelIngridient.Size = new System.Drawing.Size(75, 13);
            this.LabelIngridient.TabIndex = 52;
            this.LabelIngridient.Text = "Ингридиенты";
            // 
            // CoctailLabel
            // 
            this.CoctailLabel.AutoSize = true;
            this.CoctailLabel.Location = new System.Drawing.Point(3, 9);
            this.CoctailLabel.Name = "CoctailLabel";
            this.CoctailLabel.Size = new System.Drawing.Size(55, 13);
            this.CoctailLabel.TabIndex = 55;
            this.CoctailLabel.Text = "Коктейль";
            // 
            // Coctail
            // 
            this.Coctail.Location = new System.Drawing.Point(6, 25);
            this.Coctail.Name = "Coctail";
            this.Coctail.Size = new System.Drawing.Size(206, 20);
            this.Coctail.TabIndex = 54;
            // 
            // AddCoctailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 277);
            this.Controls.Add(this.CoctailLabel);
            this.Controls.Add(this.Coctail);
            this.Controls.Add(this.Ingridient);
            this.Controls.Add(this.LabelIngridient);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.TimeLabel);
            this.Name = "AddCoctailForm";
            this.Text = "Добавить заказ";
            ((System.ComponentModel.ISupportInitialize)(this.Time)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button Cancel;
        protected internal System.Windows.Forms.NumericUpDown Time;
        public System.Windows.Forms.ListBox Ingridient;
        private System.Windows.Forms.Label LabelIngridient;
        private System.Windows.Forms.Label CoctailLabel;
        protected internal System.Windows.Forms.TextBox Coctail;
    }
}