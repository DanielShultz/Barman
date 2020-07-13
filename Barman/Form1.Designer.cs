namespace Tourism
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
            this.ToTours = new System.Windows.Forms.Button();
            this.ToClients = new System.Windows.Forms.Button();
            this.ToOrders = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ToTours
            // 
            this.ToTours.Location = new System.Drawing.Point(12, 9);
            this.ToTours.Name = "ToTours";
            this.ToTours.Size = new System.Drawing.Size(149, 23);
            this.ToTours.TabIndex = 12;
            this.ToTours.Text = "Туры";
            this.ToTours.UseVisualStyleBackColor = true;
            this.ToTours.Click += new System.EventHandler(this.ToTours_Click);
            // 
            // ToClients
            // 
            this.ToClients.Location = new System.Drawing.Point(12, 38);
            this.ToClients.Name = "ToClients";
            this.ToClients.Size = new System.Drawing.Size(149, 23);
            this.ToClients.TabIndex = 13;
            this.ToClients.Text = "Клиенты";
            this.ToClients.UseVisualStyleBackColor = true;
            this.ToClients.Click += new System.EventHandler(this.ToClients_Click);
            // 
            // ToOrders
            // 
            this.ToOrders.Location = new System.Drawing.Point(12, 67);
            this.ToOrders.Name = "ToOrders";
            this.ToOrders.Size = new System.Drawing.Size(149, 23);
            this.ToOrders.TabIndex = 14;
            this.ToOrders.Text = "Продажи";
            this.ToOrders.UseVisualStyleBackColor = true;
            this.ToOrders.Click += new System.EventHandler(this.ToOrders_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(Tourism.Client);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 99);
            this.Controls.Add(this.ToOrders);
            this.Controls.Add(this.ToClients);
            this.Controls.Add(this.ToTours);
            this.Name = "Form1";
            this.Text = "Туризм";
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.Button ToTours;
        private System.Windows.Forms.Button ToClients;
        private System.Windows.Forms.Button ToOrders;
    }
}

