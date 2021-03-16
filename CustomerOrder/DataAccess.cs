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
        static string cnnString = "Server=localhost;Port=3306;Database=classicmodels;Uid=admin;Pwd=12345678;";
        public static List<OrderDetailModel> GetOrderDetails(int orderNumber)
        {
            using (MySqlConnection connection = new MySqlConnection(cnnString))
            {
                string select = "select productCode, quantityOrdered, priceEach from orderdetails Where orderNumber = " + orderNumber;

                return connection.Query<OrderDetailModel>(select).ToList();
            }
        }
        public static ProductModel GetProduct(string productCode)
        {
            using (MySqlConnection connection = new MySqlConnection(cnnString))
            {
                string select = "select productName, products.productCode, image from products " +
                    "inner join productlines on products.productLine = productlines.productLine " +
                    "where products.productCode = '" + productCode +"'";

                return connection.Query<ProductModel>(select).FirstOrDefault();
            }
        }
    }
}
