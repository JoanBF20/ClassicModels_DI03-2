using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerOrder
{
    public partial class CustomerOrder : UserControl
    {
        [Description("ConnectionString"), Category("Data"), Browsable(true),]
        public string CnnString
        {
            get { return Helper.CnnVal; }
            set { Helper.CnnVal = value; }
        }
        public OrderModel order = new OrderModel();
        private List<OrderDetailModel> orderDetails;
        public float total = 0;
        public CustomerOrder()
        {
            InitializeComponent();
            updateData();
        }

        public void updateData()
        {
            status.Text = order.status;
            orderDate.Text = order.orderDate.ToString();
            requiredDate.Text = order.requiredDate.ToString();
            shippedDate.Text = order.shippedDate.ToString();
            orderNumber.Text = order.orderNumber.ToString();
            orderDetails = DataAccess.GetOrderDetails(order.orderNumber);
            flowLayoutPanel1.Controls.Clear();
            total = 0;
            foreach (OrderDetailModel orderDetail in orderDetails){
                total += orderDetail.priceEach * orderDetail.quantityOrdered;
                OrderLine orderline = new OrderLine();
                orderline.orderDetail = orderDetail;
                flowLayoutPanel1.Controls.Add(orderline);
                orderline.updateData();
            }
        }
    }
}
