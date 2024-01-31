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
    public partial class CustomerInfo_CreateFrm : Form
    {
        //form cập nhật
        public CustomerInfo_CreateFrm()
        {
            InitializeComponent();
            CenterToParent();
            btnCreateUpdate.Text = "CẬP NHẬT";
        }
        //form thêm mới
        public CustomerInfo_CreateFrm(string s)
        {
            InitializeComponent();
            CenterToParent();
            btnCreateUpdate.Text = s;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(btnCreateUpdate.Text == "CẬP NHẬT")
            {
                this.Dispose();
            }
            else if(btnCreateUpdate.Text == "ĐĂNG KÝ")
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Dispose();
            }
        }
    }
}
