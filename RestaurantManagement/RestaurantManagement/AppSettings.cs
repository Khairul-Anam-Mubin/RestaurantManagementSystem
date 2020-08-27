using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    public static class AppSettings
    {
        public static string ConnectionString()
        {
            string constring = "server=localhost;port=3306;username=root;password=;database=restaurant";

            return constring;
        }
    }
}
