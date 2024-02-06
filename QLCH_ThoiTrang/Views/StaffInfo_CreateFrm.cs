using Controllers;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class StaffInfo_CreateFrm : Form
    {
        private CommonController commonController = new CommonController();
        private StaffController staffController = new StaffController();
        List<String> usernames;
        List<String> emails;
        List<String> phones;
        List<Staff> staffs;
        //tạo form cập nhật
        public StaffInfo_CreateFrm()
        {
            staffs = staffController.LoadAllStaff();
            InitializeComponent();
        }

        //tạo form thêm mới
        public StaffInfo_CreateFrm(string s)
        {
            InitializeComponent();
            staffs = staffController.LoadAllStaff();
            btnCreateUpdate.Text = s;
            btnResetPassword.Visible = false;
        }
        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCreateUpdate_Click(object sender, EventArgs e)
        {
            if (btnCreateUpdate.Text == "CẬP NHẬT")
            {

            }
            else if (btnCreateUpdate.Text == "THÊM MỚI")
            {
                bool success = true;
                CheckInputImp check = new CheckInputImp();
                usernames = commonController.LoadAllUsername();
                emails = commonController.LoadAllEmail();
                phones = commonController.LoadAllPhoneNumber();
                string username = txtStaffUsername.Text;
                string name = txtStaffName.Text;
                string email = txtStaffEmail.Text;
                string phone = txtStaffPhone.Text;
                string address = txtStaffAdress.Text;
                string gender = "Khác";
                string avatarPath = commonController.GetDefaultAvatarPath();
                DateTime birthDate = dateTimeStaffBirthDate.Value;
                if (comboStaffRole.SelectedIndex < 0)
                {
                    MessageBox.Show("Vui lòng chọn giới tính!");
                    success = false;
                }
                else if (!check.IsUsernameValid(username))
                {
                    MessageBox.Show("Thông tin username không hợp lệ!");
                    success = false;
                }
                else if (check.IsUsernameExist(username, usernames))
                {
                    MessageBox.Show("username đã tồn tại!");
                    success = false;
                }
                else if (!check.IsNameValid(name))
                {
                    MessageBox.Show("Họ và tên không hợp lệ!");
                    success = false;
                }
                else if (!check.IsEmailValid(email))
                {
                    MessageBox.Show("Email không hợp lệ!");
                    success = false;
                }
                else if (check.IsEmailExist(email, emails))
                {
                    MessageBox.Show("Email đã tồn tại!");
                    success = false;
                }
                else if (!check.IsPhoneValid(phone))
                {
                    MessageBox.Show("SĐT không hợp lệ! Bắt đầu bằng 03,05,07,08,09 và có 10 chữ số");
                    success = false;
                }
                else if (check.IsEmailExist(phone, phones))
                {
                    MessageBox.Show("SĐT đã tồn tại!");
                    success = false;
                }
                else
                {
                    gender = comboStaffGender.SelectedItem.ToString();
                }
                if (success)
                {
                    var currId = staffController.GetCurrId(staffs);
                    Staff staff = new Staff(++currId, username, "123", name, gender,
                        birthDate, phone, email, address, avatarPath, "NHÂN VIÊN");
                    staffController.CreateNewStaff(staff);
                    MessageBox.Show("Đăng ký thành công! Mật khẩu mặc định là '123'");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!");
                }

            }
        }
    }
}
