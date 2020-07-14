using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Barman
{
    public partial class IngredientForm : Form
    {
        public IngredientForm()
        {
            InitializeComponent();

            using (var context = new MyDbContext())
            {
                context.Ingredient.Load();
                dataGridView1.DataSource = context.Ingredient.Local.ToBindingList();
            };
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;
                using (var context = new MyDbContext())
                {
                    Ingredient ingredient = context.Ingredient.Find(id);
                    context.Ingredient.Remove(ingredient);

                    context.SaveChanges();
                    context.Ingredient.Load();
                    dataGridView1.DataSource = context.Ingredient.Local.ToBindingList();
                }
            };
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddIngredientForm aiForm = new AddIngredientForm();
            DialogResult result = aiForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            var ingredient = new Ingredient
            {
                Name = aiForm.Ingredient.Text,
            };

            using (var context = new MyDbContext())
            {
                context.Ingredient.Add(ingredient);
                context.SaveChanges();

                context.Ingredient.Load();
                dataGridView1.DataSource = context.Ingredient.Local.ToBindingList();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = 0;
                bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                if (converted == false)
                    return;

                using (var context = new MyDbContext())
                {
                    Ingredient ingredient = context.Ingredient.Find(id);

                    AddIngredientForm aiForm = new AddIngredientForm();
                    aiForm.Ingredient.Text = ingredient.Name;

                    DialogResult result = aiForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;

                    ingredient.Name = aiForm.Ingredient.Text;

                    context.Entry(ingredient).State = EntityState.Modified;
                    context.SaveChanges();

                    context.Ingredient.Load();
                    dataGridView1.DataSource = context.Ingredient.Local.ToBindingList();
                }
            }
        }
    }
}
