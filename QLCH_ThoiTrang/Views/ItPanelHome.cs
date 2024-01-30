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
            Color startColor = Color.FromArgb(250, 241, 129);
            Color endColor = Color.FromArgb(243, 119, 165);
            

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
            txtRevenueDay.BackColor = System.Drawing.Color.Transparent;
        }

        private void InitialPanelProductsInDay()
        {
            // Tạo màu đầu và màu cuối cho gradient
            Color startColor = Color.FromArgb(124, 218, 243); 
            Color endColor = Color.FromArgb(247, 224, 95);

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
            txtNumberOfBillDay.BackColor = System.Drawing.Color.Transparent;
        }

        private void InitialPanelBillsInDay()
        {
            // Tạo màu đầu và màu cuối cho gradient
            Color startColor = Color.FromArgb(123, 183, 245);
            Color endColor = Color.FromArgb(235, 157, 150);

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
            label7.BackColor = System.Drawing.Color.Transparent;
            txtNumberOfProductDay.BackColor = System.Drawing.Color.Transparent;
        }

        
    }
}
