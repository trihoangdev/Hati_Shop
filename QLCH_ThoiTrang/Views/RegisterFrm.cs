using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;
namespace Views
{
    public partial class RegisterFrm : Form
    {
        private IOImp ioImp = new IOImp();
        public RegisterFrm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            var msg = "Bạn có chắc chắn muốn thoát?";
            var caption = "Thông báo";
            var result = MessageBox.Show(msg, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void txtAccount_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAccount.Text == "Tên đăng nhập:")
                txtAccount.Text = "";
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu:")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtFullName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtFullName.Text == "Họ và tên:")
                txtFullName.Text = "";
        }

        private void txtPhoneNumber_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPhoneNumber.Text == "Số điện thoại:")
                txtPhoneNumber.Text = "";
        }

        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmail.Text == "Email:")
                txtEmail.Text = "";
        }

        private void txtAddress_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAddress.Text == "Địa chỉ:")
                txtAddress.Text = "";
        }

        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang phát triển", "Thông báo");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtAccount.Text;
            string password = txtPassword.Text;
            string name = txtFullName.Text;
            string email = txtEmail.Text;
            string phone = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string gender = comboGender.SelectedItem.ToString();
            DateTime birthDate = dateTimePickerBirthDate.Value;
            string avatarPath = "NO";
            if (checkBoxType.Checked)
            {
                Staff staff = new Staff(username, password, name, gender, birthDate, phone, email, address, avatarPath, "Nhân viên");
                ioImp.CreateNewStaff(staff);
            }
            else
            {
                Customer customer = new Customer(username, password, name, gender, birthDate, phone, email, address, avatarPath);

                ioImp.CreateNewCustomer(customer);
            }

            MessageBox.Show("Đăng ký thành công!");
            this.Dispose();
        }
    }
}
