﻿using System;
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
        public OrderModel order = new OrderModel();
        private List<OrderDetailModel> orderDetails;
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
            foreach (OrderDetailModel orderDetail in orderDetails){
                OrderLine orderline = new OrderLine();
                orderline.orderDetail = orderDetails.ElementAt(0);
                flowLayoutPanel1.Controls.Add(orderline);
                orderline.updateData();
            }
        }
    }
}
