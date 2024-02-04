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

namespace Views
{
    public partial class ItPanelSetting : Form
    {
        string avatarPath;
        Staff Staff { get; set; }
        public ItPanelSetting(Staff staff)
        {
            this.Staff = staff;
            InitializeComponent();
        }

        private void txtAccount_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Tên đăng nhập:")
                txtUsername.Text = "";
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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = openFileDialog.FileName;

                    // Hiển thị ảnh trong PictureBox
                    pictureAvatar.Image = new Bitmap(selectedImagePath);
                    avatarPath = selectedImagePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi chọn ảnh: " + ex.Message, "Lỗi");
                }
            }
        }
        //Load các thông tin sẵn có của tài khoản
        private void ItPanelSetting_Load(object sender, EventArgs e)
        {
            pictureAvatar.Image = Image.FromFile(Staff.AvatarPath);
            txtFullName.Text = Staff.Name;
            if (Staff.Gender == "Nam")
                comboGender.SelectedIndex = 0;
            else if (Staff.Gender == "Nữ")
                comboGender.SelectedIndex = 1;
            dateTimePickerBirthDate.Value = Staff.BirthDate;
            txtPhoneNumber.Text = Staff.PhoneNumber;
            txtEmail.Text = Staff.Email;
            txtAddress.Text = Staff.Address;
            txtUsername.Text = Staff.Username;
            txtPassword.Text = Staff.Password;
            txtPassword.Enabled = false;
            txtPassword.PasswordChar = '*';
        }
    }
}
