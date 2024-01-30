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
    public partial class ItPanelManage : Form
    {
        public ItPanelManage()
        {
            InitializeComponent();
        }

        private void btnStaffCreate_Click(object sender, EventArgs e)
        {
            ItStaffInfo f = new ItStaffInfo();
            f.TopLevel = false;
            flowPanelStaff.Controls.Add(f);
            f.Show();
        }
    }
}
