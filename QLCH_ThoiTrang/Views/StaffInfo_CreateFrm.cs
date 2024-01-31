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
    public partial class StaffInfo_CreateFrm : Form
    {
        //tạo form cập nhật
        public StaffInfo_CreateFrm()
        {
            InitializeComponent();
        }
        //tạo form thêm mới
        public StaffInfo_CreateFrm(string s)
        {
            InitializeComponent();
            btnCreateUpdate.Text = s;
            btnResetPassword.Visible = false;
        }
        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
