using System;
using System.Windows.Forms;

namespace Tourism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToTours_Click(object sender, EventArgs e)
        {
            ToursForm hform = new ToursForm();
            DialogResult result = hform.ShowDialog(this);
        }

        private void ToClients_Click(object sender, EventArgs e)
        {
            ClientsForm cform = new ClientsForm();
            DialogResult result = cform.ShowDialog(this);
        }

        private void ToOrders_Click(object sender, EventArgs e)
        {
            OrdersForm oform = new OrdersForm();
            DialogResult result = oform.ShowDialog(this);
        }
    }
}
