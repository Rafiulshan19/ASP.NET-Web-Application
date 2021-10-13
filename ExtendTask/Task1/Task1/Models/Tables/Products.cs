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
        SqlConnection connection;

        public Products(SqlConnection connection)
        {
            this.connection = connection;
        }

        public void Add(Product p)
        {
            string query = string.Format("Insert into Products values ('{0}','{1}','{2}','{3}')", p.ProductName, p.Price,p.Quantity,p.Description);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public Product GetId(int id)
        {
            string query = "select *  from Products where ProductId = " + id;
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Product p = new Product();
            if (reader.Read())
            {

                p.ProductId = reader.GetInt32(reader.GetOrdinal("id"));
                p.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                p.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                p.Quantity = reader.GetInt32(reader.GetOrdinal("Quantity"));
                p.Description = reader.GetString(reader.GetOrdinal("Description"));

            }
            connection.Close();
            return p;
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
                    Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                    Description = reader.GetString(reader.GetOrdinal("Description"))

                };
                
                products.Add(p);
            }
            connection.Close();
            return products;
        }

        public void delete(int id)
        {
            string query = "Delete from Products where ProductId=" + id;
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void update(Product p, int id)
        {
            string query = "update Products set ProductName='" + p.ProductName + "', Price='" + p.Price + "',Quantity='" + p.Quantity + "' where ProductId=" + id;
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}