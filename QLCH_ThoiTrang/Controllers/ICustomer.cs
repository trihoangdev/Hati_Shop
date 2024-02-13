using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public interface ICustomer
    {
        void CreateNewCustomer(Customer customer);
        List<Customer> LoadAllCustomer();
        int GetCurrId(List<Customer> customers);

    }
    public class CustomerController : ICustomer
    {
        private string connStr = "Data Source=hoangminhtri;Initial Catalog=HatiShop;Integrated Security=True";

        public void CreateNewCustomer(Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("CreateNewCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", customer.Id);
                    command.Parameters.AddWithValue("@Username", customer.Username);
                    command.Parameters.AddWithValue("@Password", customer.Password);
                    command.Parameters.AddWithValue("@FullName", customer.Name);
                    command.Parameters.AddWithValue("@Gender", customer.Gender);
                    command.Parameters.AddWithValue("@BirthDate", customer.BirthDate);
                    command.Parameters.AddWithValue("@PhoneNumber", customer.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", customer.Email);
                    command.Parameters.AddWithValue("@Address", customer.Address);
                    command.Parameters.AddWithValue("@AvatarPath", customer.AvatarPath);
                    command.Parameters.AddWithValue("@Revenue", customer.Revenue);
                    command.Parameters.AddWithValue("@Rank", customer.Rank);

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error in CreateNewCustomer: " + ex.Message);
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
        public List<Customer> LoadAllCustomer()
        {
            List<Customer> customers = new List<Customer>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LoadCustomer", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader["Id"].ToString();
                            var username = reader["Username"].ToString();
                            var password = reader["Password"].ToString();
                            var fullName = reader["FullName"].ToString();
                            var gender = reader["Gender"].ToString();
                            var birthDate = (DateTime)reader["BirthDate"];
                            var phone = reader["PhoneNumber"].ToString();
                            var email = reader["Email"].ToString();
                            var address = reader["Address"].ToString();
                            var avatarPath = reader["AvatarPath"].ToString();
                            int revenue = 0;
                            if (reader["Revenue"] != DBNull.Value)
                                revenue = Convert.ToInt32(reader["Revenue"]);
                            string rank = reader["Rank"].ToString();

                            Customer customer = new Customer(id, username, password, fullName,
                                gender, birthDate, phone, email, address, avatarPath, revenue, rank);
                            customers.Add(customer);
                        }
                    }
                }
            }
            return customers;
        }
        public int GetCurrId(List<Customer> customers)
        {
            if (customers.Count == 0)
                return 0;
            List<int> idIntList = GetListIdInt(customers);
            return idIntList[idIntList.Count - 1];
        }
        private List<int> GetListIdInt(List<Customer> customers)
        {
            List<int> list = new List<int>();
            foreach (var staff in customers)
            {
                list.Add(staff.IdInt);
            }
            list.Sort();
            return list;
        }
    }
}
