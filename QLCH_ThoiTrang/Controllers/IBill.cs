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
    public interface IBill
    {
        int GetCurrId(List<Bill> bills);
        List<Bill> LoadAllBill();
        void CreateNewBill(Bill bill);
        void UpdateBill(string billId, float originalAmount, float discountAmount, float discountedAmount);
        void PayBill(string billId, float originalAmount, float discountAmount, float discountedAmount);
    }
    public class BillController : IBill
    {
        private string connStr = "Data Source=hoangminhtri;Initial Catalog=HatiShop;Integrated Security=True";
        private Staff Staff { get; set; }
        private Product Product { get; set; }
        private Customer Customer { get; set; }
        StaffController staffController = new StaffController();
        ProductController productController = new ProductController();
        CustomerController customerController = new CustomerController();

        public int GetCurrId(List<Bill> bills)
        {
            if (bills.Count == 0)
                return 0;
            List<int> idIntList = GetListIdInt(bills);
            return idIntList[idIntList.Count - 1];
        }

        private List<int> GetListIdInt(List<Bill> bills)
        {
            List<int> list = new List<int>();
            foreach (var product in bills)
            {
                list.Add(product.IdInt);
            }
            list.Sort();
            return list;
        }

        public List<Bill> LoadAllBill()
        {
            List<Bill> bills = new List<Bill>();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("LoadBill", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var id = reader["Id"].ToString();
                            var customerId = reader["CustomerId"].ToString();
                            var staffId = reader["StaffId"].ToString();
                            DateTime creationTime = (DateTime)reader["CreationTime"];
                            float discountAmount = float.Parse(reader["DiscountAmount"].ToString());
                            float originalPrice = float.Parse(reader["OriginalPrice"].ToString());
                            float discountedTotal = float.Parse(reader["DiscountedTotal"].ToString());
                            Staff = FindStaff(staffId);
                            Customer = FindCustomer(customerId);
                            Bill bill = new Bill(id, Customer, Staff, creationTime,
                                discountAmount, originalPrice, discountedTotal);
                            bills.Add(bill);
                        }
                    }
                }
            }
            return bills;
        }

        private Customer FindCustomer(string customerId)
        {
            var customers = new List<Customer>();
            customers = customerController.LoadAllCustomer();
            foreach (Customer customer in customers)
            {
                if (customer.Id == customerId)
                    return customer;
            }
            return null;
        }

        private Product FindProduct(string productId)
        {
            var products = new List<Product>();
            products = productController.LoadAllProduct();
            foreach (Product product in products)
            {
                if (product.Id == productId)
                    return product;
            }
            return null;
        }

        private Staff FindStaff(string staffId)
        {
            var staffs = new List<Staff>();
            staffs = staffController.LoadAllStaff();
            foreach (Staff staff in staffs)
            {
                if (staff.Id == staffId)
                    return staff;
            }
            return null;
        }

        public void CreateNewBill(Bill bill)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("CreateNewBill", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", bill.Id);
                    command.Parameters.AddWithValue("@StaffId", bill.Staff.Id);
                    command.Parameters.AddWithValue("@CustomerId", bill.Customer.Id);
                    command.Parameters.AddWithValue("@CreationTime", bill.CreationTime);
                    command.Parameters.AddWithValue("@DiscountAmount", bill.DiscountAmount);
                    command.Parameters.AddWithValue("@OriginalPrice", bill.OriginalAmnount);
                    command.Parameters.AddWithValue("@DiscountedTotal", bill.DiscountedPrice);
                    //thực thi
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error in CreateNewBill: " + ex.Message);
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

        public void UpdateBill(string billId, float originalAmount, float discountAmount, float discountedAmount)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UpdateBill", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", billId);
                    command.Parameters.AddWithValue("@OriginalPrice", originalAmount);
                    command.Parameters.AddWithValue("@DiscountAmount", discountAmount);
                    command.Parameters.AddWithValue("@DiscountedTotal", discountedAmount);

                    //thực thi
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error in UpdateBill: " + ex.Message);
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

        public void PayBill(string billId, float originalAmount, float discountAmount, float discountedAmount)
        {
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("PayBill", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Id", billId);
                    command.Parameters.AddWithValue("@OriginalPrice", originalAmount);
                    command.Parameters.AddWithValue("@DiscountAmount", discountAmount);
                    command.Parameters.AddWithValue("@DiscountedTotal", discountAmount);

                    //thực thi
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error in PayBill: " + ex.Message);
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
