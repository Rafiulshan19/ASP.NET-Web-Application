using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Task1.Models.Entity;

namespace Task1.Models.Tables
{
    public class Products
    {
        private SqlConnection connection;

        public Products(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void Add(Product p)
        {
            string query = string.Format("Insert into Products values ('{0}','{1}','{2}')", p.ProductId, p.ProductName, p.Price);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            int r = command.ExecuteNonQuery();
            connection.Close();
        }
        public Product Get(int id)
        {
            return null;
        }
        public List<Product> GetAll()
        {
            string query = "select * from Products";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> students = new List<Product>();
            while (reader.Read())
            {
                Product p = new Product()
                {
                    ProductId = reader.GetInt32(reader.GetOrdinal("ProductId")),
                    ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                    Price = reader.GetInt32(reader.GetOrdinal("Price")),
                    
                };
                
                products.Add(p);
            }
            connection.Close();
            return products;
        }
    }
}