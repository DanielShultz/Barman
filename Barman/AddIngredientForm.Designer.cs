namespace Barman
{
    partial class AddIngredientForm
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
            this.IngredientLabel = new System.Windows.Forms.Label();
            this.Ingredient = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Ok.Location = new System.Drawing.Point(12, 51);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(100, 23);
            this.Ok.TabIndex = 32;
            this.Ok.Text = "Принять";
            this.Ok.UseVisualStyleBackColor = true;
            // 
            // IngredientLabel
            // 
            this.IngredientLabel.AutoSize = true;
            this.IngredientLabel.Location = new System.Drawing.Point(12, 9);
            this.IngredientLabel.Name = "IngredientLabel";
            this.IngredientLabel.Size = new System.Drawing.Size(67, 13);
            this.IngredientLabel.TabIndex = 28;
            this.IngredientLabel.Text = "Ингридиент";
            // 
            // Ingredient
            // 
            this.Ingredient.Location = new System.Drawing.Point(12, 25);
            this.Ingredient.Name = "Ingredient";
            this.Ingredient.Size = new System.Drawing.Size(206, 20);
            this.Ingredient.TabIndex = 27;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(118, 51);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(100, 23);
            this.Cancel.TabIndex = 34;
            this.Cancel.Text = "Отмена";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // AddIngredientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 82);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.IngredientLabel);
            this.Controls.Add(this.Ingredient);
            this.Name = "AddIngredientForm";
            this.Text = "Ингридиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Label IngredientLabel;
        private System.Windows.Forms.Button Cancel;
        protected internal System.Windows.Forms.TextBox Ingredient;
    }
}