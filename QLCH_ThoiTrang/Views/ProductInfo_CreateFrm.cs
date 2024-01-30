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
    public partial class ProductInfo_CreateFrm : Form
    {
        //form khi tạo mới
        public ProductInfo_CreateFrm()
        {
            InitializeComponent();
            CenterToParent();
        }
        //form khi Show Info
        public ProductInfo_CreateFrm(string s)
        {
            InitializeComponent();
            FormShowInfoSetting();
            CenterToParent();
        }

        //ẩn các textbox, chỉ cho xem
        private void FormShowInfoSetting()
        {
            txtProductId.Enabled = false;
            txtProductName.Enabled = false;
            txtProductPrice.Enabled = false;
            txtProductQuantity.Enabled = false;
            txtProductQuantity.Enabled = false;

            comboProductSize.Enabled = false;
            comboProductType.Enabled = false;

            btnAddNewProduct.Visible = false;
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}
