﻿using System;
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
    public partial class ItBillInfo : Form
    {
        public ItBillInfo()
        {
            InitializeComponent();
        }

        private void ItBillInfo_Click(object sender, EventArgs e)
        {
            BillInfoFrm f = new BillInfoFrm();
            f.ShowDialog();
        }
    }
}
