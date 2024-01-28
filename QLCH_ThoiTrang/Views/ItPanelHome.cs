using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class ItPanelHome : Form
    {
        public ItPanelHome()
        {
            InitializeComponent();
            InitializeGradientPanel();
        }
        private void InitializeGradientPanel()
        {
            InitialPanelProductsInDay();
            InitialPanelBillsInDay();
            InitialPanelRevenueInDay();
        }
        private void InitialPanelRevenueInDay()
        {
            // Tạo màu đầu và màu cuối cho gradient
            Color startColor = Color.FromArgb(33, 228, 224);
            Color endColor = Color.FromArgb(173, 141, 247);

            // Gọi sự kiện Paint để vẽ gradient
            panelRevenueDay.Paint += (sender, e) =>
            {
                // Tạo LinearGradientBrush cho gradient
                LinearGradientBrush brush = new LinearGradientBrush(
                    panelRevenueDay.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical);

                // Vẽ gradient lên panel
                e.Graphics.FillRectangle(brush, panelRevenueDay.ClientRectangle);
            };
            //set màu cho các chữ trong panel là trong suốt
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
            txtRevenueDay.BackColor = System.Drawing.Color.Transparent;
        }

        private void InitialPanelBillsInDay()
        {
            // Tạo màu đầu và màu cuối cho gradient
            Color startColor = Color.FromArgb(255, 199, 76);
            Color endColor = Color.FromArgb(255, 125, 4);

            // Gọi sự kiện Paint để vẽ gradient
            panelProductDay.Paint += (sender, e) =>
            {
                // Tạo LinearGradientBrush cho gradient
                LinearGradientBrush brush = new LinearGradientBrush(
                    panelProductDay.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical);

                // Vẽ gradient lên panel
                e.Graphics.FillRectangle(brush, panelProductDay.ClientRectangle);
            };
            //set màu cho các chữ trong panel là trong suốt
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            txtNumberOfBillDay.BackColor = System.Drawing.Color.Transparent;
        }

        private void InitialPanelProductsInDay()
        {
            // Tạo màu đầu và màu cuối cho gradient
            Color startColor = Color.FromArgb(186, 96, 224);
            Color endColor = Color.FromArgb(95, 41, 255);

            // Gọi sự kiện Paint để vẽ gradient
            panelBillDay.Paint += (sender, e) =>
            {
                // Tạo LinearGradientBrush cho gradient
                LinearGradientBrush brush = new LinearGradientBrush(
                    panelBillDay.ClientRectangle, startColor, endColor, LinearGradientMode.Vertical);

                // Vẽ gradient lên panel
                e.Graphics.FillRectangle(brush, panelBillDay.ClientRectangle);
            };
            //set màu cho các chữ trong panel là trong suốt
            label6.BackColor = System.Drawing.Color.Transparent;
            label7.BackColor = System.Drawing.Color.Transparent;
            txtNumberOfProductDay.BackColor = System.Drawing.Color.Transparent;
        }
    }
}
