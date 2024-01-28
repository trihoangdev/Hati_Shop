using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Security.Principal;

namespace Views
{
    public partial class StaffHomeFrm : Form
    {
        private Form currentPanelForm;
        public StaffHomeFrm()
        {
            InitializeComponent();
            FormLoad();
            CenterToParent();
        }
        //những việc cần làm khi load trang lên
        private void FormLoad()
        {
            //Hiển thị panel của home
            ShowPanelHome();
        }
        //Hiển thị panel của home
        private void ShowPanelHome()
        {
            ItPanelHome f = new ItPanelHome();
            if (f.Parent != null)
            {
                f.Parent.Controls.Remove(f);
            }
            // Thiết lập TopLevel, Dock và Parent cho UserControl
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(f);
            f.Show();
            currentPanelForm = f;
        }

        //Sự kiện nút Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var msg = "Bạn có chắc chắn muốn thoát?";
            var caption = "Thông báo";
            var result = MessageBox.Show(msg, caption, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem trong Panel2 đã có Form nào chưa
            if (currentPanelForm != null && !currentPanelForm.IsDisposed)
            {
                currentPanelForm.Close();  // Đóng Form trước khi Dispose
                currentPanelForm.Dispose();
            }
            ItPanelHome f = new ItPanelHome();
            if (f.Parent != null)
            {
                f.Parent.Controls.Remove(f);
            }
            // Thiết lập TopLevel, Dock và Parent cho UserControl
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(f);
            f.Show();
            currentPanelForm = f;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem trong Panel2 đã có Form nào chưa
            if (currentPanelForm != null && !currentPanelForm.IsDisposed)
            {
                currentPanelForm.Close();  // Đóng Form trước khi Dispose
                currentPanelForm.Dispose();
            }
            ItPanelBill f = new ItPanelBill();
            if (f.Parent != null)
            {
                f.Parent.Controls.Remove(f);
            }
            // Thiết lập TopLevel, Dock và Parent cho UserControl
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(f);
            f.Show();
            currentPanelForm = f;
        }


        private void btnProduct_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem trong Panel2 đã có Form nào chưa
            if (currentPanelForm != null && !currentPanelForm.IsDisposed)
            {
                currentPanelForm.Close();  // Đóng Form trước khi Dispose
                currentPanelForm.Dispose();
            }
            ItPanelProduct f = new ItPanelProduct();
            if (f.Parent != null)
            {
                f.Parent.Controls.Remove(f);
            }
            // Thiết lập TopLevel, Dock và Parent cho UserControl
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(f);
            f.Show();
            currentPanelForm = f;
        }


    }

}
