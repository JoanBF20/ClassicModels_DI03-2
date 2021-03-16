using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ClassicModels
{
    class DataAccess
    {
        public static List<CustomerModel> GetCustomers()
        {
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("ClassicModels")))
            {
                string select = "select distinct customers.customerNumber, customerName from customers inner join orders on customers.customerNumber = orders.customerNumber";

                return connection.Query<CustomerModel>(select).ToList();
            }
        }
        public static List<OrderModel> GetOrdersByUser(int customerNumber)
        {
            using (MySqlConnection connection = new MySqlConnection(Helper.CnnVal("ClassicModels")))
            {
                string select = "select orderNumber, orderDate, requiredDate, shippedDate, status from orders Where customerNumber = " + customerNumber;

                return connection.Query<OrderModel>(select).ToList();
            }
        }
    }
}
