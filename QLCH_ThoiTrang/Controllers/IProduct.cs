using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Collections;
namespace Controllers
{
    public interface IProduct
    {
        List<Product> LoadAllProduct();
        int GetCurrId(List<Product> products);
        void CreateNewProduct(Product product);
        void EditProductInfo(Product product);
    }
    public class ProductController : IProduct
    {
        private string connStr = "Data Source=hoangminhtri;Initial Catalog=HatiShop;Integrated Security=True";
        public int GetCurrId(List<Product> products)
        {
            if (products.Count == 0)
                return 0;
            List<int> idIntList = GetListIdInt(products);
            return idIntList[idIntList.Count - 1];
        }
        private List<int> GetListIdInt(List<Product> products)
        {
            List<int> list = new List<int>();
            foreach (var product in products)
            {
                list.Add(product.IdInt);
            }
            list.Sort();
            return list;
        }

        public List<Product> LoadAllProduct()
        {
            List<Product> products = new List<Product>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LoadProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader["Id"].ToString();
                            var name = reader["Name"].ToString();
                            var price = (int)reader["Price"];
                            var type = reader["Type"].ToString();
                            var size = reader["Size"].ToString();
                            var quantity = (int)reader["Quantity"];
                            var info = reader["Info"].ToString();
                            var avatarPath = reader["AvatarPath"].ToString();
                            Product product = new Product(id, name,price,type,quantity,size,info,avatarPath);
                            products.Add(product);
                        }
                    }
                }
            }
            return products;
        }

        public void CreateNewProduct(Product product)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("CreateNewProduct", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", product.Id);
                    command.Parameters.AddWithValue("@Name", product.Name);
                    command.Parameters.AddWithValue("@Price", product.Price);
                    command.Parameters.AddWithValue("@Type", product.Type);
                    command.Parameters.AddWithValue("@Quantity", product.Quantity);
                    command.Parameters.AddWithValue("@Size", product.Size);
                    command.Parameters.AddWithValue("@Info", product.Info);
                    command.Parameters.AddWithValue("@AvatarPath", product.AvatarPath);
                    //thực thi
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error in CreateNewProduct: " + ex.Message);
                    }
                    finally
                    {
                        if (connection.State == ConnectionState.Open)
                        {
                            connection.Close();
                        }
                    }

                }
            }
        }

        public void EditProductInfo(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
