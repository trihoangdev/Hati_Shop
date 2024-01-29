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
    public partial class ItPanelCustomer : Form
    {
        public ItPanelCustomer()
        {
            InitializeComponent();
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            ItCustomerInfo f = new ItCustomerInfo();
            f.TopLevel = false;
            flowPanelCustomer.Controls.Add(f);
            f.Show();
        }
    }
}
