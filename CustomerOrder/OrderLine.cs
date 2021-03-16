using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CustomerOrder
{
    public partial class OrderLine : UserControl
    {
        public OrderDetailModel orderDetail = new OrderDetailModel();
        private ProductModel product;
        public OrderLine()
        {
            InitializeComponent();
            updateData();
        }
        public void updateData()
        {
            qtyOrdered.Text = "x" + orderDetail.quantityOrdered;
            priceEach.Text = orderDetail.priceEach + "€";
            total.Text = (orderDetail.priceEach * orderDetail.quantityOrdered) + "€";
            Console.Out.WriteLine(orderDetail.productCode);
            if (orderDetail.productCode != null)
            {
                product = DataAccess.GetProduct(orderDetail.productCode);
                productName.Text = product.productName;
                MemoryStream ms = new MemoryStream(product.image);
                Image image = Image.FromStream(ms);
                pictureBox1.Image = image;
            }
        }
    }
}
