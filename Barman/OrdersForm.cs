using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace Tourism
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            using (var context = new MyDbContext())
            {
                context.Orders.Load();
                context.Clients.Load();
                context.Tours.Load();
                dataGridView1.DataSource = context.Orders.Local.ToBindingList();
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

                    Order order = context.Orders.Find(id);
                    context.Orders.Remove(order);
                    context.SaveChanges();

                    context.Clients.Load();
                    context.Tours.Load();
                    context.Orders.Load();
                    dataGridView1.DataSource = context.Orders.Local.ToBindingList();
                }
            };
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddOrderForm aoForm = new AddOrderForm();

            using (var context = new MyDbContext())
            {
                List<Client> clients = context.Clients.ToList();
                aoForm.OrderClient.DataSource = clients;
                aoForm.OrderClient.ValueMember = "Id";
                aoForm.OrderClient.DisplayMember = "FullName";

                List<Tour> tours = context.Tours.ToList();
                aoForm.OrderTour.DataSource = tours;
                aoForm.OrderTour.ValueMember = "Id";
                aoForm.OrderTour.DisplayMember = "Country";

                DialogResult result = aoForm.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                var order = new Order
                {
                    Client = (Client)aoForm.OrderClient.SelectedItem,
                    Tour = (Tour)aoForm.OrderTour.SelectedItem,
                    Date = aoForm.OrderDate.Value.ToString(),
                    Time = (int)aoForm.OrderTime.Value
                };

                context.Orders.Add(order);
                context.SaveChanges();

                context.Clients.Load();
                context.Tours.Load();
                context.Orders.Load();
                dataGridView1.DataSource = context.Orders.Local.ToBindingList();
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
                    Order order = context.Orders.Find(id);

                    AddOrderForm aoForm = new AddOrderForm();

                    List<Client> clients = context.Clients.ToList();
                    aoForm.OrderClient.DataSource = clients;
                    aoForm.OrderClient.ValueMember = "Id";
                    aoForm.OrderClient.DisplayMember = "FullName";

                    List<Tour> tours = context.Tours.ToList();
                    aoForm.OrderTour.DataSource = tours;
                    aoForm.OrderTour.ValueMember = "Id";
                    aoForm.OrderTour.DisplayMember = "Country";

                    if (order.Client != null)
                        aoForm.OrderClient.SelectedValue = order.Client.Id;

                    if (order.Tour != null)
                        aoForm.OrderTour.SelectedValue = order.Tour.Id;

                    aoForm.OrderTime.Value = order.Time;
                    aoForm.OrderDate.Value = Convert.ToDateTime(order.Date);

                    DialogResult result = aoForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;

                    order.Client = (Client)aoForm.OrderClient.SelectedItem;
                    order.Tour = (Tour)aoForm.OrderTour.SelectedItem;
                    order.Date = aoForm.OrderDate.Value.ToString();
                    order.Time = (int)aoForm.OrderTime.Value;

                    context.Entry(order).State = EntityState.Modified;
                    context.SaveChanges();

                    context.Orders.Load();
                    context.Clients.Load();
                    context.Tours.Load();
                    dataGridView1.DataSource = context.Orders.Local.ToBindingList();
                }
            }
        }
    }
}
