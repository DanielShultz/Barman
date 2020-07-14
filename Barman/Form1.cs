using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Barman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var context = new MyDbContext())
            {
                List<Cocktail> coctails = context.Cocktail.ToList();
                Cocktail.DataSource = coctails;
                Cocktail.ValueMember = "Id";
                Cocktail.DisplayMember = "Name";
            }
        }

        private void ToIngridient_Click(object sender, EventArgs e)
        {
            IngredientForm hform = new IngredientForm();
            DialogResult result = hform.ShowDialog(this);
        }

        private void ToCoctail_Click(object sender, EventArgs e)
        {
            CoctailForm oform = new CoctailForm();
            DialogResult result = oform.ShowDialog(this);
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                Cocktail cocktail = (Cocktail)Cocktail.SelectedItem;
                Time.Value = cocktail.Time;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Time.Value > 0)
            {
                Time.Value = Time.Value - 1;
                Ok.Enabled = false;
            }
            else
            {
                Ok.Enabled = true;
            }
        }
    }
}
