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
    public partial class ItPanelImportGood : Form
    {
        public ItPanelImportGood()
        {
            InitializeComponent();
        }

        private void btnImportGoodCreate_Click(object sender, EventArgs e)
        {
            ImportGoodCreateFrm frm = new ImportGoodCreateFrm();
            frm.ShowDialog();
            /*ItImportGoodInfo f = new ItImportGoodInfo();
            f.TopLevel = false;
            flowPanelImportGood.Controls.Add(f);
            f.Show();*/
        }
    }
}
