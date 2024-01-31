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
    public partial class ItStaffInfo : Form
    {
        public ItStaffInfo()
        {
            InitializeComponent();
        }

        private void panelStaff_Paint(object sender, PaintEventArgs e)
        {
            StaffInfo_CreateFrm f = new StaffInfo_CreateFrm();
            f.ShowDialog();
        }
    }
}
