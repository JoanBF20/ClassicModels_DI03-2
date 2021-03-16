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
    public partial class OrderLine : UserControl
    {
        public OrderDetailModel orderDetail = new OrderDetailModel();
        public OrderLine()
        {
            InitializeComponent();
        }
        public void updateData()
        {
            qtyOrdered.Text = "x" + orderDetail.quantityOrdered;
            priceEach.Text = orderDetail.priceEach + "€";
            total.Text = (orderDetail.priceEach * orderDetail.quantityOrdered) + "€";
        }
    }
}