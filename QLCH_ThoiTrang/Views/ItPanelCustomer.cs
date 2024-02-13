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
    public partial class ItPanelCustomer : Form
    {
        private List<Customer> customers = new List<Customer>();
        private CustomerController customerController = new CustomerController();
        public ItPanelCustomer()
        {
            InitializeComponent();
            LoadControls();
        }

        private void LoadControls()
        {
            customers = customerController.LoadAllCustomer();
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            CustomerInfo_CreateFrm f = new CustomerInfo_CreateFrm();
            f.ShowDialog();
        }

        private void ItPanelCustomer_Load(object sender, EventArgs e)
        {
            RemoveAll();
            foreach (var customer in customers)
            {
                ItCustomerInfo f = new ItCustomerInfo(customer);
                f.TopLevel = false;
                flowPanelCustomer.Controls.Add(f);
                f.Show();
            }
        }

        private void RemoveAll()
        {
            flowPanelCustomer.Controls.Clear();
        }
    }
}
