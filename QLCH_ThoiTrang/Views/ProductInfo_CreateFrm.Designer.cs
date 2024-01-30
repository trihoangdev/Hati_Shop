namespace Views
{
    partial class ProductInfo_CreateFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfo_CreateFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboProductType = new System.Windows.Forms.ComboBox();
            this.comboProductSize = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductMoreInfo = new System.Windows.Forms.RichTextBox();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnExist = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnExist);
            this.panel1.Controls.Add(this.btnAddNewProduct);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 800);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(563, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "SẢN PHẨM MỚI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 232);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 282);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtProductMoreInfo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.comboProductSize);
            this.panel2.Controls.Add(this.comboProductType);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtProductQuantity);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtProductPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.txtProductId);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(387, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 541);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "MÃ SẢN PHẨM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(314, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "TÊN SẢN PHẨM";
            // 
            // txtProductId
            // 
            this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductId.Location = new System.Drawing.Point(18, 52);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(270, 30);
            this.txtProductId.TabIndex = 0;
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(319, 52);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(270, 30);
            this.txtProductName.TabIndex = 6;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductPrice.Location = new System.Drawing.Point(18, 145);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(270, 30);
            this.txtProductPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "GIÁ SẢN PHẨM";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductQuantity.Location = new System.Drawing.Point(18, 235);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(270, 30);
            this.txtProductQuantity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "SỐ LƯỢNG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(314, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "LOẠI SẢN PHẨM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(314, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 28);
            this.label7.TabIndex = 12;
            this.label7.Text = "KÍCH CỠ";
            // 
            // comboProductType
            // 
            this.comboProductType.FormattingEnabled = true;
            this.comboProductType.Location = new System.Drawing.Point(319, 145);
            this.comboProductType.Name = "comboProductType";
            this.comboProductType.Size = new System.Drawing.Size(270, 31);
            this.comboProductType.TabIndex = 13;
            // 
            // comboProductSize
            // 
            this.comboProductSize.FormattingEnabled = true;
            this.comboProductSize.Location = new System.Drawing.Point(319, 234);
            this.comboProductSize.Name = "comboProductSize";
            this.comboProductSize.Size = new System.Drawing.Size(270, 31);
            this.comboProductSize.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(237, 28);
            this.label8.TabIndex = 15;
            this.label8.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // txtProductMoreInfo
            // 
            this.txtProductMoreInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductMoreInfo.Location = new System.Drawing.Point(18, 338);
            this.txtProductMoreInfo.Name = "txtProductMoreInfo";
            this.txtProductMoreInfo.Size = new System.Drawing.Size(571, 198);
            this.txtProductMoreInfo.TabIndex = 16;
            this.txtProductMoreInfo.Text = "";
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.BackColor = System.Drawing.Color.White;
            this.btnAddNewProduct.FlatAppearance.BorderSize = 0;
            this.btnAddNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(54)))));
            this.btnAddNewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewProduct.Location = new System.Drawing.Point(576, 681);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(261, 50);
            this.btnAddNewProduct.TabIndex = 12;
            this.btnAddNewProduct.Text = "THÊM SẢN PHẨM";
            this.btnAddNewProduct.UseVisualStyleBackColor = false;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnExist
            // 
            this.btnExist.FlatAppearance.BorderSize = 0;
            this.btnExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExist.Image = ((System.Drawing.Image)(resources.GetObject("btnExist.Image")));
            this.btnExist.Location = new System.Drawing.Point(956, 12);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(32, 32);
            this.btnExist.TabIndex = 13;
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // ProductInfo_CreateFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductInfo_CreateFrm";
            this.Text = "ProductInfoFrm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboProductSize;
        private System.Windows.Forms.ComboBox comboProductType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.RichTextBox txtProductMoreInfo;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Button btnExist;
    }
}