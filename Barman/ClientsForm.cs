using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace Tourism
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            using (var context = new MyDbContext())
            {
                context.Clients.Load();
                dataGridView1.DataSource = context.Clients.Local.ToBindingList();
            };
        }

        private void DeleteClient_Click(object sender, EventArgs e)
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
                    Client client = context.Clients.Find(id);
                    context.Clients.Remove(client);
                    context.SaveChanges();

                    context.Clients.Load();
                    dataGridView1.DataSource = context.Clients.Local.ToBindingList();
                }
            }
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            AddClientForm acForm = new AddClientForm();
            DialogResult result = acForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            var client = new Client
            {
                Name = acForm.Name.Text,
                SecondName = acForm.SecondName.Text,
                Surname = acForm.Surname.Text,
                Email = acForm.Email.Text,
                PhoneNumber = acForm.PhoneNumber.Text
            };

            using (var context = new MyDbContext())
            {
                context.Clients.Add(client);
                context.SaveChanges();

                context.Clients.Load();
                dataGridView1.DataSource = context.Clients.Local.ToBindingList();
            }

        }

        private void EditClient_Click(object sender, EventArgs e)
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
                    Client client = context.Clients.Find(id);

                    AddClientForm acForm = new AddClientForm();
                    acForm.Name.Text = client.Name;
                    acForm.SecondName.Text = client.SecondName;
                    acForm.Surname.Text = client.Surname;
                    acForm.Email.Text = client.Email;
                    acForm.PhoneNumber.Text = client.PhoneNumber;

                    DialogResult result = acForm.ShowDialog(this);
                    if (result == DialogResult.Cancel)
                        return;

                    client.Name = acForm.Name.Text;
                    client.SecondName = acForm.SecondName.Text;
                    client.Surname = acForm.Surname.Text;
                    client.Email = acForm.Email.Text;
                    client.PhoneNumber = client.PhoneNumber;

                    context.Entry(client).State = EntityState.Modified;
                    context.SaveChanges();

                    context.Clients.Load();
                    dataGridView1.DataSource = context.Clients.Local.ToBindingList();
                }
            }
        }
    }
}
