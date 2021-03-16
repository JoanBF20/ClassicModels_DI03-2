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

        private void ordersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrderModel ordermodel = orders.ElementAt(ordersComboBox.SelectedIndex);
            customerOrder1.order.orderDate = ordermodel.orderDate;
            customerOrder1.order.orderNumber = ordermodel.orderNumber;
            customerOrder1.order.requiredDate = ordermodel.requiredDate;
            customerOrder1.order.shippedDate = ordermodel.shippedDate;
            customerOrder1.order.status = ordermodel.status;
            customerOrder1.updateData();
        }
    }
}
