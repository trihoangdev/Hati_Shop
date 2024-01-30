using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class ItProductInfo : Form
    {
        public ItProductInfo()
        {
            InitializeComponent();
            FormLoad();
        }

        private void FormLoad()
        {
            //set nằm giữa cho tên sp
            txtName.Anchor = AnchorStyles.None;
            int x = (this.ClientSize.Width - txtName.Width) / 2;
            txtName.Location = new Point(x, 205);
            
            //set nằm giữa cho giá sp
            txtPrice.Anchor = AnchorStyles.None;
            int y = (this.ClientSize.Width - txtPrice.Width) / 2;
            txtPrice.Location = new Point(x, 230);

            //thiết lập màu cho label
            txtName.ForeColor = Color.Black;
            txtPrice.ForeColor = Color.Black;

        }

        private void panelProduct_Paint(object sender, PaintEventArgs e)
        {
            ProductInfo_CreateFrm f = new ProductInfo_CreateFrm("show");
            f.ShowDialog();
        }
    }
}
