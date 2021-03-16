using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassicModels
{
    public partial class Form1 : Form
    {
        private List<CustomerModel> customers;
        private List<OrderModel> orders;
        public Form1()
        {
            customers = DataAccess.GetCustomers();
            InitializeComponent();
            customersComboBox.DataSource = customers;
            customersComboBox.DisplayMember = "customerName";
        }

        private void customersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            orders = DataAccess.GetOrdersByUser(customers.ElementAt(customersComboBox.SelectedIndex).customerNumber);
            ordersComboBox.DataSource = orders;
            ordersComboBox.DisplayMember = "orderNumber";
        }
    }
}
