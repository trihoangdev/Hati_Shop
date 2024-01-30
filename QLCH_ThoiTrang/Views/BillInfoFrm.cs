using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class BillInfoFrm : Form
    {
        public BillInfoFrm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            var msg = "Bạn có chắc chắn muốn xoá?";
            var title = "Thông báo";
            var res = MessageBox.Show(msg, title,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
