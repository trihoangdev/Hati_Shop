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
    public partial class ItCustomerInfo : Form
    {
        public ItCustomerInfo()
        {
            InitializeComponent();
        }

        private void panelPerson_Paint(object sender, PaintEventArgs e)
        {
            CustomerInfo_CreateFrm f = new CustomerInfo_CreateFrm();
            f.ShowDialog();
            /*ItCustomerInfo f = new ItCustomerInfo();
            f.TopLevel = false;
            flowPanelCustomer.Controls.Add(f);
            f.Show();*/
        }
    }
}
