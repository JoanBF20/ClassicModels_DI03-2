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
        public Form1()
        {
            customers = DataAccess.GetCustomers();
            InitializeComponent();
            customersComboBox.DataSource = customers;
            customersComboBox.DisplayMember = "customerName";
        }
    }
}
