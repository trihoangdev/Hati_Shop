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
    public partial class ItPanelProduct : Form
    {
        public ItPanelProduct()
        {
            InitializeComponent();
        }

        private void txtProductFind_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtProductFind.Text == "Tìm kiếm:")
                txtProductFind.Text = "";
        }
    }
}
