namespace Tourism
{
    partial class AddClientForm
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
            this.Ok = new System.Windows.Forms.Button();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.SecondNameLabel = new System.Windows.Forms.Label();
            this.SecondName = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Location = new System.Drawing.Point(12, 209);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(119, 23);
            this.Ok.TabIndex = 21;
            this.Ok.Text = "Принять";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 167);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 20;
            this.EmailLabel.Text = "E-mail";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(12, 183);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(237, 20);
            this.Email.TabIndex = 19;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(12, 126);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(95, 13);
            this.PhoneNumberLabel.TabIndex = 18;
            this.PhoneNumberLabel.Text = "Номер Телефона";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(12, 142);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(237, 20);
            this.PhoneNumber.TabIndex = 17;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(12, 87);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
            this.SurnameLabel.TabIndex = 16;
            this.SurnameLabel.Text = "Фамилия";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(12, 103);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(237, 20);
            this.Surname.TabIndex = 15;
            // 
            // SecondNameLabel
            // 
            this.SecondNameLabel.AutoSize = true;
            this.SecondNameLabel.Location = new System.Drawing.Point(12, 47);
            this.SecondNameLabel.Name = "SecondNameLabel";
            this.SecondNameLabel.Size = new System.Drawing.Size(54, 13);
            this.SecondNameLabel.TabIndex = 14;
            this.SecondNameLabel.Text = "Отчество";
            // 
            // SecondName
            // 
            this.SecondName.Location = new System.Drawing.Point(12, 63);
            this.SecondName.Name = "SecondName";
            this.SecondName.Size = new System.Drawing.Size(237, 20);
            this.SecondName.TabIndex = 13;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 8);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(29, 13);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "Имя";
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(12, 24);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(237, 20);
            this.Name.TabIndex = 11;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(137, 209);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(112, 23);
            this.Cancel.TabIndex = 22;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 244);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.SurnameLabel);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.SecondNameLabel);
            this.Controls.Add(this.SecondName);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Name);
            this.Text = "Добавить клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label SecondNameLabel;
        private System.Windows.Forms.Label NameLabel;
        protected internal System.Windows.Forms.TextBox Email;
        protected internal System.Windows.Forms.TextBox PhoneNumber;
        protected internal System.Windows.Forms.TextBox Surname;
        protected internal System.Windows.Forms.TextBox SecondName;
        protected internal System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Button Cancel;
    }
}