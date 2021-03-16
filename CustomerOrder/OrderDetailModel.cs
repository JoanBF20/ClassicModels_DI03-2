using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder
{
    public class OrderDetailModel
    {
        public string productCode { get; set; }
        public int quantityOrdered { get; set; }
        public float priceEach { get; set; }
    }
}
