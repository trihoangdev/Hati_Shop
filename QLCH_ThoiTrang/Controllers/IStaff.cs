using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Controllers
{
    public interface IStaff
    {
        Staff CheckLogin(string username, string password, string role);
        int GetCurrId(List<Staff> staffs);

        List<Staff> LoadAllStaff();
        void CreateNewStaff(Staff staff);
        void EditStaffInfo(Staff staff);
        void RemoveStaff(List<Staff> staffs, string username);
        
    }
    public class StaffController : IStaff
    {
        private string connStr = "Data Source=hoangminhtri;Initial Catalog=HatiShop;Integrated Security=True";
        public int GetCurrId(List<Staff> staffs)
        {
            if (staffs.Count == 0)
                return 0;
            return staffs[staffs.Count - 1].IdInt;
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
        public Staff CheckLogin(string username, string password, string role)
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
                    command.Parameters.AddWithValue("@Role", role);

                    // Thực hiện stored procedure và kiểm tra kết quả
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Đăng nhập thành công nếu return staff, null nếu ko tìm thấy
                            return FindStaffByUsername(username);
                        }
                        else
                        {
                            // Đăng nhập thất bại
                            return null;
                        }
                    }
                }
            }
        }
        public Staff FindStaffByUsername(string username)
        {
            var staffs = LoadAllStaff();
            foreach (var i in staffs)
            {
                if (i.Username == username)
                    return i;
            }
            return null;
        }
        public void EditStaffInfo(Staff staff)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("EditStaffInfo", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", staff.Id);
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
                        Console.WriteLine("Error in EditStaffInfo: " + ex.Message);
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

        public void RemoveStaff(List<Staff> staffs, string username)
        {
            for (int i = 0; i < staffs.Count; i++)
            {
                if (staffs[i].Username == username)
                {
                    using (SqlConnection connection = new SqlConnection(connStr))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("RemoveStaffByUsername", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@Username", staffs[i].Username);
                            
                            //thực thi
                            try
                            {
                                command.ExecuteNonQuery();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error in EditStaffInfo: " + ex.Message);
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
            }
        }

    }

}
