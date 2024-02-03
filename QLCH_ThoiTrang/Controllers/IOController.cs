using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{

    public interface IOController
    {
        bool CheckLogin(string username, string password);
        void CreateNewCustomer(Customer customer);
        List<String> LoadAllUsername();
        List<String> LoadAllEmail();
        List<String> LoadAllPhoneNumber();
        List<Customer> LoadAllCustomer();
        List<Staff> LoadAllStaff();


    }
    public class IOImp : IOController
    {
        private string connStr = "Data Source=hoangminhtri;Initial Catalog=HatiShop;Integrated Security=True";

        //Thêm mới khách hàng từ trang register
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
        //Thêm mới nhân viên từ trang register
        public void CreateNewStaff(Staff staff)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("CreateNewStaff", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", staff.Id);
                    command.Parameters.AddWithValue("@Username", staff.Username);
                    command.Parameters.AddWithValue("@Password", staff.Password);
                    command.Parameters.AddWithValue("@FullName", staff.Name);
                    command.Parameters.AddWithValue("@Gender", staff.Gender);
                    command.Parameters.AddWithValue("@BirthDate", staff.BirthDate);
                    command.Parameters.AddWithValue("@PhoneNumber", staff.PhoneNumber);
                    command.Parameters.AddWithValue("@Email", staff.Email);
                    command.Parameters.AddWithValue("@Address", staff.Address);
                    command.Parameters.AddWithValue("@AvatarPath", staff.AvatarPath);
                    command.Parameters.AddWithValue("@Role", staff.Role);

                    //thực thi
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
        //Kiểm tra username và password đã tồn tại trong hệ thống chưa
        public bool CheckLogin(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("CheckLogin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Truyền tham số cho stored procedure
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    // Thực hiện stored procedure và kiểm tra kết quả
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Đăng nhập thành công
                            return true;
                        }
                        else
                        {
                            // Đăng nhập thất bại
                            return false;
                        }
                    }
                }
            }
        }
        //Load các username có trong hệ thống
        public List<String> LoadAllUsername()
        {
            List<String> usernames = new List<String>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LoadUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usernames.Add(reader["Username"].ToString());
                        }
                    }
                }
            }
            return usernames;
        }
        //load các gmail có trong hệ thống
        public List<String> LoadAllEmail()
        {
            List<String> emails = new List<String>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LoadEmail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            emails.Add(reader["Email"].ToString());
                        }
                    }
                }
            }
            return emails;
        }
        public List<string> LoadAllPhoneNumber()
        {
            List<String> phones = new List<String>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LoadPhone", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            phones.Add(reader["PhoneNumber"].ToString());
                        }
                    }
                }
            }
            return phones;
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
        public List<Staff> LoadAllStaff()
        {
            List<Staff> staffs = new List<Staff>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LoadStaff", connection))
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
                            var role = reader["Role"].ToString();

                            Staff staff = new Staff(id, username, password, fullName,
                                gender, birthDate, phone, email, address, avatarPath, role);
                            staffs.Add(staff);
                        }
                    }
                }
            }
            return staffs;
        }

    }
}
