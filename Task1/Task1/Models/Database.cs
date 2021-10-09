using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Task1.Models.Tables;

namespace Task1.Models
{
    public class Database
    {
        public Products Products { get; set; }
        public Database()
        {
            string connString = @"Data Source=SHAN\SQLEXPRESS;Initial Catalog=ASP;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connString);
            Products = new Products(connection);

        }
    }
}