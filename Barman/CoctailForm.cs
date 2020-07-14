using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Barman
{
    public partial class CoctailForm : Form
    {
        public CoctailForm()
        {
            InitializeComponent();
            using (var context = new MyDbContext())
            {
                context.Cocktail.Load();
                context.Ingredient.Load();
                dataGridView1.DataSource = context.Cocktail.Local.ToBindingList();
            };
        }

        private void DeleteOrder_Click(object sender, EventArgs e)
        {
            using (var context = new MyDbContext())
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int index = dataGridView1.SelectedRows[0].Index;
                    int id = 0;
                    bool converted = Int32.TryParse(dataGridView1[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;

                    Cocktail cocktail = context.Cocktail.Find(id);
                    context.Cocktail.Remove(cocktail);
                    context.SaveChanges();

                    context.Cocktail.Load();
                    context.Ingredient.Load();
                    dataGridView1.DataSource = context.Cocktail.Local.ToBindingList();
                }
            };
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddCoctailForm acForm = new AddCoctailForm();

            using (var context = new MyDbContext())
            {
                List<Ingredient> ingredients = context.Ingredient.ToList();
                acForm.Ingridient.DataSource = ingredients;
                acForm.Ingridient.ValueMember = "Id";
                acForm.Ingridient.DisplayMember = "Name";

                DialogResult result = acForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                var cocktail = new Cocktail
                {
                    Name = acForm.Coctail.Text,
                    Time = (int)acForm.Time.Value
                };

                context.Cocktail.Add(cocktail);
                context.SaveChanges();

                context.Cocktail.Load();
                context.Ingredient.Load();
                dataGridView1.DataSource = context.Cocktail.Local.ToBindingList();
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
                    Cocktail cocktail = context.Cocktail.Find(id);

                    AddCoctailForm acForm = new AddCoctailForm();

                    List<Ingredient> ingredients = context.Ingredient.ToList();
                    acForm.Ingridient.DataSource = ingredients;
                    acForm.Ingridient.ValueMember = "Id";
                    acForm.Ingridient.DisplayMember = "Name";
                    acForm.Ingridient.SelectedItem = null;
                    foreach (Ingredient i in cocktail.Ingredient)
                        acForm.Ingridient.SelectedItem = i;

                    acForm.Coctail.Text = cocktail.Name;
                    acForm.Time.Value = cocktail.Time;

                    DialogResult result = acForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;

                    cocktail.Name = acForm.Coctail.Text;
                    cocktail.Time = (int)acForm.Time.Value;

                    foreach (var ingredient in ingredients)
                    {
                        if (acForm.Ingridient.SelectedItems.Contains(ingredient))
                        {
                            if (!cocktail.Ingredient.Contains(ingredient))
                                cocktail.Ingredient.Add(ingredient);
                        }
                        else
                        {
                            if (cocktail.Ingredient.Contains(ingredient))
                                cocktail.Ingredient.Remove(ingredient);
                        }
                    }

                    context.Entry(cocktail).State = EntityState.Modified;
                    context.SaveChanges();

                    context.Cocktail.Load();
                    context.Ingredient.Load();
                    dataGridView1.DataSource = context.Cocktail.Local.ToBindingList();
                }
            }
        }
    }
}
