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
    public partial class ItImportGoodInfo : Form
    {
        public ItImportGoodInfo()
        {
            InitializeComponent();
        }

        private void panelImportGood_Paint(object sender, PaintEventArgs e)
        {
            ImportGoodInfoFrm f = new ImportGoodInfoFrm();
            f.ShowDialog();
        }
    }
}
