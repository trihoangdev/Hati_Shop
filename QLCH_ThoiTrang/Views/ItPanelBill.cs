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
    public partial class ItPanelBill : Form
    {
        public ItPanelBill()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void txtBillFind_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtBillFind.Text == "Tìm kiếm:")
                txtBillFind.Text = "";
        }

        private void btnBillCreate_Click(object sender, EventArgs e)
        {
            ItBillInfo f = new ItBillInfo();
            f.TopLevel = false;
            flowPanelBill.Controls.Add(f);
            f.Show();
        }


    }
}
