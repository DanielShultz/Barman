using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Tourism
{
    public partial class ToursForm : Form
    {
        public ToursForm()
        {
            InitializeComponent();

            using (var context = new MyDbContext())
            {
                context.Tours.Load();
                dataGridView1.DataSource = context.Tours.Local.ToBindingList();
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
                    Tour tour = context.Tours.Find(id);
                    context.Tours.Remove(tour);
                    context.SaveChanges();
                    context.Tours.Load();
                    dataGridView1.DataSource = context.Tours.Local.ToBindingList();
                }
            };
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddTourForm ahForm = new AddTourForm();
            DialogResult result = ahForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            var tour = new Tour
            {
                Country = ahForm.CountryTour.Text,
                Price = (int)ahForm.PriceTour.Value
            };

            using (var context = new MyDbContext())
            {
                context.Tours.Add(tour);
                context.SaveChanges();

                context.Tours.Load();
                dataGridView1.DataSource = context.Tours.Local.ToBindingList();
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
                    Tour tour = context.Tours.Find(id);

                    AddTourForm ahForm = new AddTourForm();
                    ahForm.CountryTour.Text = tour.Country;
                    ahForm.PriceTour.Value = tour.Price;

                    DialogResult result = ahForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;

                    tour.Country = ahForm.CountryTour.Text;
                    tour.Price = (int)ahForm.PriceTour.Value;

                    context.Entry(tour).State = EntityState.Modified;
                    context.SaveChanges();

                    context.Tours.Load();
                    dataGridView1.DataSource = context.Tours.Local.ToBindingList();
                }
            }
        }
    }
}
