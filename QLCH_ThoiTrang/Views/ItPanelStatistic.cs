using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class ItPanelStatistic : Form
    {
        public ItPanelStatistic()
        {
            InitializeComponent();
            InitializeGradientPanel();
        }
        private void InitializeGradientPanel()
        {
            //set màu nền cho panel
            InitialPanelTopCustomer();
            InitialPanelRevenueMonth();
            InitialPanelTopStaff();
        }

        private void InitialPanelTopStaff()
        {
            // Tạo màu đầu và màu cuối cho gradient
            Color startColor = Color.FromArgb(124, 218, 243);
            Color endColor = Color.FromArgb(247, 224, 95);

            // Gọi sự kiện Paint để vẽ gradient
            panelTopStaff.Paint += (sender, e) =>
            {
                // Tạo LinearGradientBrush cho gradient
                LinearGradientBrush brush = new LinearGradientBrush(
                    panelTopStaff.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical);

                // Vẽ gradient lên panel
                e.Graphics.FillRectangle(brush, panelTopStaff.ClientRectangle);
            };
            //set màu cho các chữ trong panel là trong suốt
            label7.BackColor = System.Drawing.Color.Transparent;
            txtStaffId.BackColor = System.Drawing.Color.Transparent;
            txtStaffName.BackColor = System.Drawing.Color.Transparent;

            //set màu cho màu nền của hình trong suốt
            pictureAvatarStaff.BackColor = System.Drawing.Color.Transparent;
        }

        private void InitialPanelRevenueMonth()
        {
            // Tạo màu đầu và màu cuối cho gradient
            Color startColor = Color.FromArgb(250, 241, 129);
            Color endColor = Color.FromArgb(243, 119, 165);


            // Gọi sự kiện Paint để vẽ gradient
            panelRevenueMonth.Paint += (sender, e) =>
            {
                // Tạo LinearGradientBrush cho gradient
                LinearGradientBrush brush = new LinearGradientBrush(
                    panelRevenueMonth.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical);

                // Vẽ gradient lên panel
                e.Graphics.FillRectangle(brush, panelRevenueMonth.ClientRectangle);
            };
            //set màu cho các chữ trong panel là trong suốt
            label3.BackColor = System.Drawing.Color.Transparent;
            panelRevenueMonth.BackColor = System.Drawing.Color.Transparent;
            txtRevenueMonth.BackColor = System.Drawing.Color.Transparent;
        }

        private void InitialPanelTransparent(Panel p)
        {
            p.BackColor = Color.Transparent;
        }
        private void InitialPictureBoxTransparent(PictureBox pictureBox)
        {
            pictureBox.BackColor = Color.Transparent;
        }
        private void InitialPanelTopCustomer()
        {
            // Tạo màu đầu và màu cuối cho gradient
            Color startColor = Color.FromArgb(123, 183, 245);
            Color endColor = Color.FromArgb(235, 157, 150);

            // Gọi sự kiện Paint để vẽ gradient
            panelTopCustomer.Paint += (sender, e) =>
            {
                // Tạo LinearGradientBrush cho gradient
                LinearGradientBrush brush = new LinearGradientBrush(
                    panelTopCustomer.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical);

                // Vẽ gradient lên panel
                e.Graphics.FillRectangle(brush, panelTopCustomer.ClientRectangle);
            };
            //set màu cho các chữ trong panel là trong suốt
            //set màu nền rỗng cho các panel con
            InitialPanelTransparent(panelTop1);
            InitialPanelTransparent(panelTop2);
            InitialPanelTransparent(panelTop3);

            //set màu nền rỗng cho các textbox và picturebox trong panel
            label1.BackColor = System.Drawing.Color.Transparent;
            txtCustomerIdTop1.BackColor = System.Drawing.Color.Transparent;
            txtCustomerIdTop2.BackColor = System.Drawing.Color.Transparent;
            txtCustomerIdTop3.BackColor = System.Drawing.Color.Transparent;
            txtCustomerNameTop1.BackColor = System.Drawing.Color.Transparent;
            txtCustomerNameTop2.BackColor = System.Drawing.Color.Transparent;
            txtCustomerNameTop3.BackColor = System.Drawing.Color.Transparent;
            
            InitialPictureBoxTransparent(pictureTop1);
            InitialPictureBoxTransparent(pictureTop2);
            InitialPictureBoxTransparent(pictureTop3);
        }
    }
}
