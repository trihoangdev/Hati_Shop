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

                    //thực thi
                    command.ExecuteNonQuery();

                }
            }
        }
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

                    //thực thi
                    command.ExecuteNonQuery();

                }
            }
        }
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

        
    }
}
