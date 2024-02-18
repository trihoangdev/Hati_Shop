using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using Controllers;
namespace Views
{
    public partial class ItPanelImportGood : Form
    {
        private List<ImportGood> importGoods = new List<ImportGood>();
        private ImportGoodController importGoodController = new ImportGoodController();
        public ItPanelImportGood()
        {
            InitializeComponent();
        }

        private void btnImportGoodCreate_Click(object sender, EventArgs e)
        {
            ImportGoodCreateFrm frm = new ImportGoodCreateFrm();
            frm.ShowDialog();
        }

        private void ItPanelImportGood_Load(object sender, EventArgs e)
        {
            importGoods = importGoodController.LoadAllImportGood();
            foreach (var importGood in importGoods)
            {
                ItImportGoodMain f = new ItImportGoodMain(importGood);
                f.TopLevel = false;
                flowPanelImportGood.Controls.Add(f);
                f.Show();
            }
        }
    }
}
