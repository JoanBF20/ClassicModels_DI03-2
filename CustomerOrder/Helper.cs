using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerOrder
{
    class Helper
    {
        private static string cnnVal = "Server=localhost;Port=3306;Database=classicmodels;Uid=admin;Pwd=12345678;";
        public static string CnnVal
        {
            get { return cnnVal; }
            set { cnnVal = value; }
        }
    }
}
