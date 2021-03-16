using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace CustomerOrder
{
    class DataAccess
    {
        public static List<OrderDetailModel> GetOrderDetails(int orderNumber)
        {
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal))
            {
                string select = "select productCode, quantityOrdered, priceEach from orderdetails Where orderNumber = " + orderNumber;

                return connection.Query<OrderDetailModel>(select).ToList();
            }
        }
        public static ProductModel GetProduct(string productCode)
        {
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal))
            {
                string select = "select productName, products.productCode, image from products " +
                    "inner join productlines on products.productLine = productlines.productLine " +
                    "where products.productCode = '" + productCode +"'";

                return connection.Query<ProductModel>(select).FirstOrDefault();
            }
        }
    }
}
