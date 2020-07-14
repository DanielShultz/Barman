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
            this.Cocktail = new System.Windows.Forms.ComboBox();
            this.Ok = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).BeginInit();
            this.SuspendLayout();
            // 
            // ToIngridient
            // 
            this.ToIngridient.Location = new System.Drawing.Point(174, 12);
            this.ToIngridient.Name = "ToIngridient";
            this.ToIngridient.Size = new System.Drawing.Size(156, 23);
            this.ToIngridient.TabIndex = 12;
            this.ToIngridient.Text = "Ингридиенты";
            this.ToIngridient.UseVisualStyleBackColor = true;
            this.ToIngridient.Click += new System.EventHandler(this.ToIngridient_Click);
            // 
            // ToCoctail
            // 
            this.ToCoctail.Location = new System.Drawing.Point(12, 12);
            this.ToCoctail.Name = "ToCoctail";
            this.ToCoctail.Size = new System.Drawing.Size(156, 23);
            this.ToCoctail.TabIndex = 14;
            this.ToCoctail.Text = "Коктейли";
            this.ToCoctail.UseVisualStyleBackColor = true;
            this.ToCoctail.Click += new System.EventHandler(this.ToCoctail_Click);
            // 
            // Cocktail
            // 
            this.Cocktail.FormattingEnabled = true;
            this.Cocktail.Location = new System.Drawing.Point(12, 41);
            this.Cocktail.Name = "Cocktail";
            this.Cocktail.Size = new System.Drawing.Size(156, 21);
            this.Cocktail.TabIndex = 15;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(174, 39);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(156, 23);
            this.Ok.TabIndex = 16;
            this.Ok.Text = "Готовить";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(174, 68);
            this.Time.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(156, 20);
            this.Time.TabIndex = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 425);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cocktail);
            this.Controls.Add(this.ToCoctail);
            this.Controls.Add(this.ToIngridient);
            this.Name = "Form1";
            this.Text = "Бармен";
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Time)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Button ToIngridient;
        private System.Windows.Forms.Button ToCoctail;
        public System.Windows.Forms.ComboBox Cocktail;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Timer timer1;
        protected internal System.Windows.Forms.NumericUpDown Time;
    }
}

