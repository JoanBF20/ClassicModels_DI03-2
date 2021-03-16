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
                string select = "select customerNumber, customerName from customers";

                return connection.Query<CustomerModel>(select).ToList();
            }
        }
    }
}
