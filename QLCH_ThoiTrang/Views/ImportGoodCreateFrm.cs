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
    public partial class ImportGoodCreateFrm : Form
    {
        public ImportGoodCreateFrm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddNewBill_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
