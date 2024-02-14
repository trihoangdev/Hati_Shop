using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Views
{
    public partial class ItPanelProduct : Form
    {
        List<Product> products = new List<Product>();
        ProductController controller = new ProductController();
        public ItPanelProduct()
        {
            InitializeComponent();
            products = controller.LoadAllProduct();
        }

        private void txtProductFind_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtProductFind.Text == "Tìm kiếm:")
                txtProductFind.Text = "";
        }

        private void btnProductFind_Click(object sender, EventArgs e)
        {
            ProductInfo_CreateFrm f = new ProductInfo_CreateFrm();
            f.ShowDialog();

        }

        private void ItPanelProduct_Load(object sender, EventArgs e)
        {
            RemoveAll();
            foreach (var product in products)
            {
                ItProductInfo f = new ItProductInfo(product);
                f.TopLevel = false;
                flowPanelProduct.Controls.Add(f);
                f.Show();
            }
        }
        private void RemoveAll()
        {
            flowPanelProduct.Controls.Clear();
        }
    }
}
