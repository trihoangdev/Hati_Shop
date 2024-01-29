using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class ItPanelSetting : Form
    {
        public ItPanelSetting()
        {
            InitializeComponent();
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

        private void btnChangePicture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang phát triển", "Thông báo");
        }
    }
}
