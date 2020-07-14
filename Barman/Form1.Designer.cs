namespace Barman
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ToIngridient = new System.Windows.Forms.Button();
            this.ToCoctail = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ToIngridient
            // 
            this.ToIngridient.Location = new System.Drawing.Point(12, 9);
            this.ToIngridient.Name = "ToIngridient";
            this.ToIngridient.Size = new System.Drawing.Size(149, 23);
            this.ToIngridient.TabIndex = 12;
            this.ToIngridient.Text = "Ингридиенты";
            this.ToIngridient.UseVisualStyleBackColor = true;
            this.ToIngridient.Click += new System.EventHandler(this.ToIngridient_Click);
            // 
            // ToCoctail
            // 
            this.ToCoctail.Location = new System.Drawing.Point(12, 38);
            this.ToCoctail.Name = "ToCoctail";
            this.ToCoctail.Size = new System.Drawing.Size(149, 23);
            this.ToCoctail.TabIndex = 14;
            this.ToCoctail.Text = "Коктейли";
            this.ToCoctail.UseVisualStyleBackColor = true;
            this.ToCoctail.Click += new System.EventHandler(this.ToCoctail_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 70);
            this.Controls.Add(this.ToCoctail);
            this.Controls.Add(this.ToIngridient);
            this.Name = "Form1";
            this.Text = "Бармен";
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Button ToIngridient;
        private System.Windows.Forms.Button ToCoctail;
    }
}

