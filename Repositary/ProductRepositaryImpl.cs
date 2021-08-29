using FlipCart.Connections;
using FlipCart.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FlipCart.Repositary
{
    public class ProductRepositaryImp : IProductRepositary
    {
        SqlConnection con = null;
        public Product CreateProduct(Product product)
            //Product is a class name
        {
            try
            {
                con = DBConnection.CreateConnection();
                // string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
                //SqlConnection con = new SqlConnection("data source=.; database=Filpcart;integrated security=SSPI");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Tbl_Products1(Name,Description,price)values('" + product.Name + "'," +
                    "'" + product.Description + "','" + product.price + "');", con);
                cmd.ExecuteNonQuery();
                con.Close();
                return product;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return product;
        }
        public Product findProductById(int productId)
        {
            try
            {
                con = DBConnection.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Tbl_Products1 where productId=" + productId, con);
                Product pro = new Product();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    pro = new Product();
                    pro.productId = Convert.ToInt32(sdr["productId"]);
                    pro.Name = Convert.ToString(sdr["Name"]);
                    pro.Description = Convert.ToString(sdr["Description"]);
                    pro.price = Convert.ToDecimal(sdr["price"]);
                    con.Close();

                    return pro;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public List<Product> findAllProducts()
        {
            //if we want number of values we use list
            //products --is a object
            List<Product> products = new List<Product>();
            try
            {
                Product pro = new Product();
                con = DBConnection.CreateConnection();//DBConnection connection class
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Tbl_Products1 ", con);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    pro = new Product();
                    pro.productId = Convert.ToInt32(sdr["productId"]);
                    pro.Name = Convert.ToString(sdr["Name"]);
                    pro.Description = Convert.ToString(sdr["Description"]);
                    pro.price = Convert.ToDecimal(sdr["price"]);
                    products.Add(pro);
                 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return products;
           
        }

        public Product updateProduct(int productId, Product product)
        {
            try
            {
                con = DBConnection.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Update Tbl_Products1 SET  Name = '" + product.Name + "', Description = '" + product.Description + "', price = '" + product.price + "' WHERE productId =" + productId, con);
               
                SqlDataReader sdr = cmd.ExecuteReader();
                return product;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public string DeleteProduct(int productId)
        {
            try
            {
                con = DBConnection.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Delete  from Tbl_Products1 WHERE productId=" + productId, con);
              
                SqlDataReader sdr = cmd.ExecuteReader();
                return "Product Deleted Sucessfully:" + productId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }
        public Product findProductByName(String Name)
        {
            try
            {
                con = DBConnection.CreateConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Tbl_Products1 where Name='" + Name+"'", con);
                Product pro = new Product();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    pro = new Product();
                    pro.productId = Convert.ToInt32(sdr["productId"]);
                    pro.Name = Convert.ToString(sdr["Name"]);
                    pro.Description = Convert.ToString(sdr["Description"]);
                    pro.price = Convert.ToDecimal(sdr["price"]);
                    con.Close();

                    return pro;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

          public Product SearchProductByName(string Name)
          {
              throw new NotImplementedException();
          }

        public List<Product> SearchAllProductsByName(string Name)
        {
            List<Product> products = new List<Product>();
            try
            {
                Product pro = new Product();
                con = DBConnection.CreateConnection();//DBConnection connection class
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Tbl_Products1 where Name='" + Name + "'", con);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    pro = new Product();
                    pro.productId = Convert.ToInt32(sdr["productId"]);
                    pro.Name = Convert.ToString(sdr["Name"]);
                    pro.Description = Convert.ToString(sdr["Description"]);
                    pro.price = Convert.ToDecimal(sdr["price"]);
                    products.Add(pro);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return products;
        }

        public List<Product> FindAllProductsBetweenRange(decimal MinPrice, decimal MaxPrice)
        {

            List<Product> products = new List<Product>();
            try
            {
                Product pro = new Product();
                con = DBConnection.CreateConnection();//DBConnection connection class
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Tbl_Products1 where Price  Between '"+MinPrice+"' AND '"+ MaxPrice + "'", con);

                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    pro = new Product();
                    pro.productId = Convert.ToInt32(sdr["productId"]);
                    pro.Name = Convert.ToString(sdr["Name"]);
                    pro.Description = Convert.ToString(sdr["Description"]);
                    pro.price = Convert.ToDecimal(sdr["price"]);
                    products.Add(pro);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return products;
        }

    
    }//Class Close
}//Namespace close