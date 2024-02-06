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
    public partial class ItPanelManage : Form
    {
        private List<Staff> staffs = new List<Staff>(); 
        private StaffController staffController = new StaffController();
        public ItPanelManage()
        {
            InitializeComponent();
            LoadControls();
        }

        private void LoadControls()
        {
            staffs = staffController.LoadAllStaff();
        }

        private void btnStaffCreate_Click(object sender, EventArgs e)
        {
            StaffInfo_CreateFrm f = new StaffInfo_CreateFrm();
            f.ShowDialog();
        }

        public void ItPanelManage_Load(object sender, EventArgs e)
        {
            RemoveAll();
            foreach(var staff in staffs) 
            {
                ItStaffInfo f = new ItStaffInfo(staff);
                f.TopLevel = false;
                flowPanelStaff.Controls.Add(f);
                f.Show();
            }
        }

        private void RemoveAll()
        {
            flowPanelStaff.Controls.Clear();
        }
    }
}
