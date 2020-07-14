using System;
using System.Windows.Forms;

namespace Barman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
