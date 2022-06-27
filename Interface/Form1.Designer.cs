namespace Interface
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelQuanLySubmenu = new System.Windows.Forms.Panel();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnMaterials = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnPaymentMethods = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.panelKhoSubmenu = new System.Windows.Forms.Panel();
            this.btnResources = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();
            this.panelBanHangSubmenu = new System.Windows.Forms.Panel();
            this.btnReportSales = new System.Windows.Forms.Button();
            this.btnShiftDetails = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.siiButton1 = new Interface.SiiControls.SiiButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelQuanLySubmenu.SuspendLayout();
            this.panelKhoSubmenu.SuspendLayout();
            this.panelBanHangSubmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(42)))), ((int)(((byte)(22)))));
            this.panelSideMenu.Controls.Add(this.panelQuanLySubmenu);
            this.panelSideMenu.Controls.Add(this.btnQuanLy);
            this.panelSideMenu.Controls.Add(this.panelKhoSubmenu);
            this.panelSideMenu.Controls.Add(this.btnKho);
            this.panelSideMenu.Controls.Add(this.panelBanHangSubmenu);
            this.panelSideMenu.Controls.Add(this.btnBanHang);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Controls.Add(this.siiButton1);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(281, 910);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelQuanLySubmenu
            // 
            this.panelQuanLySubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.panelQuanLySubmenu.Controls.Add(this.btnManageAccount);
            this.panelQuanLySubmenu.Controls.Add(this.btnNCC);
            this.panelQuanLySubmenu.Controls.Add(this.btnMaterials);
            this.panelQuanLySubmenu.Controls.Add(this.btnProducts);
            this.panelQuanLySubmenu.Controls.Add(this.btnPaymentMethods);
            this.panelQuanLySubmenu.Controls.Add(this.btnDiscount);
            this.panelQuanLySubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuanLySubmenu.Location = new System.Drawing.Point(0, 563);
            this.panelQuanLySubmenu.Name = "panelQuanLySubmenu";
            this.panelQuanLySubmenu.Size = new System.Drawing.Size(281, 238);
            this.panelQuanLySubmenu.TabIndex = 6;
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageAccount.FlatAppearance.BorderSize = 0;
            this.btnManageAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAccount.Location = new System.Drawing.Point(0, 190);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnManageAccount.Size = new System.Drawing.Size(281, 38);
            this.btnManageAccount.TabIndex = 8;
            this.btnManageAccount.Text = "Quản lý tài khoản nhân viên";
            this.btnManageAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAccount.UseVisualStyleBackColor = true;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click_1);
            // 
            // btnNCC
            // 
            this.btnNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Location = new System.Drawing.Point(0, 152);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnNCC.Size = new System.Drawing.Size(281, 38);
            this.btnNCC.TabIndex = 7;
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.UseVisualStyleBackColor = true;
            this.btnNCC.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnMaterials
            // 
            this.btnMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterials.FlatAppearance.BorderSize = 0;
            this.btnMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterials.Location = new System.Drawing.Point(0, 114);
            this.btnMaterials.Name = "btnMaterials";
            this.btnMaterials.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnMaterials.Size = new System.Drawing.Size(281, 38);
            this.btnMaterials.TabIndex = 5;
            this.btnMaterials.Text = "Nguyên liệu";
            this.btnMaterials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaterials.UseVisualStyleBackColor = true;
            this.btnMaterials.Click += new System.EventHandler(this.btnMaterials_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Location = new System.Drawing.Point(0, 76);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(281, 38);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Sản phẩm";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnPaymentMethods
            // 
            this.btnPaymentMethods.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaymentMethods.FlatAppearance.BorderSize = 0;
            this.btnPaymentMethods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentMethods.Location = new System.Drawing.Point(0, 38);
            this.btnPaymentMethods.Name = "btnPaymentMethods";
            this.btnPaymentMethods.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnPaymentMethods.Size = new System.Drawing.Size(281, 38);
            this.btnPaymentMethods.TabIndex = 2;
            this.btnPaymentMethods.Text = "Phương thức thanh toán";
            this.btnPaymentMethods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentMethods.UseVisualStyleBackColor = true;
            this.btnPaymentMethods.Click += new System.EventHandler(this.btnPaymentMethods_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiscount.FlatAppearance.BorderSize = 0;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Location = new System.Drawing.Point(0, 0);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnDiscount.Size = new System.Drawing.Size(281, 38);
            this.btnDiscount.TabIndex = 1;
            this.btnDiscount.Text = "Mã giảm giá";
            this.btnDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscount.UseVisualStyleBackColor = true;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(66)))), ((int)(((byte)(32)))));
            this.btnQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuanLy.FlatAppearance.BorderSize = 0;
            this.btnQuanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLy.Location = new System.Drawing.Point(0, 520);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnQuanLy.Size = new System.Drawing.Size(281, 43);
            this.btnQuanLy.TabIndex = 5;
            this.btnQuanLy.Text = "Quản lý chung";
            this.btnQuanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanLy.UseVisualStyleBackColor = false;
            this.btnQuanLy.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // panelKhoSubmenu
            // 
            this.panelKhoSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.panelKhoSubmenu.Controls.Add(this.btnResources);
            this.panelKhoSubmenu.Controls.Add(this.btnInventory);
            this.panelKhoSubmenu.Controls.Add(this.btnExport);
            this.panelKhoSubmenu.Controls.Add(this.btnEnter);
            this.panelKhoSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKhoSubmenu.Location = new System.Drawing.Point(0, 363);
            this.panelKhoSubmenu.Name = "panelKhoSubmenu";
            this.panelKhoSubmenu.Size = new System.Drawing.Size(281, 157);
            this.panelKhoSubmenu.TabIndex = 4;
            // 
            // btnResources
            // 
            this.btnResources.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResources.FlatAppearance.BorderSize = 0;
            this.btnResources.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResources.Location = new System.Drawing.Point(0, 114);
            this.btnResources.Name = "btnResources";
            this.btnResources.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnResources.Size = new System.Drawing.Size(281, 38);
            this.btnResources.TabIndex = 3;
            this.btnResources.Text = "Quản lý Nguyên liệu";
            this.btnResources.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResources.UseVisualStyleBackColor = true;
            this.btnResources.Click += new System.EventHandler(this.btnResources_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Location = new System.Drawing.Point(0, 76);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(281, 38);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Kiểm kê";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(0, 38);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnExport.Size = new System.Drawing.Size(281, 38);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Xuất kho";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Location = new System.Drawing.Point(0, 0);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnEnter.Size = new System.Drawing.Size(281, 38);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Nhập kho";
            this.btnEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnKho
            // 
            this.btnKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(66)))), ((int)(((byte)(32)))));
            this.btnKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKho.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKho.FlatAppearance.BorderSize = 0;
            this.btnKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKho.Location = new System.Drawing.Point(0, 320);
            this.btnKho.Name = "btnKho";
            this.btnKho.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnKho.Size = new System.Drawing.Size(281, 43);
            this.btnKho.TabIndex = 3;
            this.btnKho.Text = "Quản trị kho";
            this.btnKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKho.UseVisualStyleBackColor = false;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);
            // 
            // panelBanHangSubmenu
            // 
            this.panelBanHangSubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(168)))), ((int)(((byte)(107)))));
            this.panelBanHangSubmenu.Controls.Add(this.btnReportSales);
            this.panelBanHangSubmenu.Controls.Add(this.btnShiftDetails);
            this.panelBanHangSubmenu.Controls.Add(this.btnSell);
            this.panelBanHangSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBanHangSubmenu.Location = new System.Drawing.Point(0, 200);
            this.panelBanHangSubmenu.Name = "panelBanHangSubmenu";
            this.panelBanHangSubmenu.Size = new System.Drawing.Size(281, 120);
            this.panelBanHangSubmenu.TabIndex = 2;
            // 
            // btnReportSales
            // 
            this.btnReportSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportSales.FlatAppearance.BorderSize = 0;
            this.btnReportSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportSales.Location = new System.Drawing.Point(0, 76);
            this.btnReportSales.Name = "btnReportSales";
            this.btnReportSales.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnReportSales.Size = new System.Drawing.Size(281, 38);
            this.btnReportSales.TabIndex = 3;
            this.btnReportSales.Text = "Báo cáo doanh thu";
            this.btnReportSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportSales.UseVisualStyleBackColor = true;
            this.btnReportSales.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnShiftDetails
            // 
            this.btnShiftDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShiftDetails.FlatAppearance.BorderSize = 0;
            this.btnShiftDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShiftDetails.Location = new System.Drawing.Point(0, 38);
            this.btnShiftDetails.Name = "btnShiftDetails";
            this.btnShiftDetails.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnShiftDetails.Size = new System.Drawing.Size(281, 38);
            this.btnShiftDetails.TabIndex = 1;
            this.btnShiftDetails.Text = "Chi tiết ca";
            this.btnShiftDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShiftDetails.UseVisualStyleBackColor = true;
            this.btnShiftDetails.Click += new System.EventHandler(this.btnChiTietCa_Click);
            // 
            // btnSell
            // 
            this.btnSell.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Location = new System.Drawing.Point(0, 0);
            this.btnSell.Name = "btnSell";
            this.btnSell.Padding = new System.Windows.Forms.Padding(39, 0, 0, 0);
            this.btnSell.Size = new System.Drawing.Size(281, 38);
            this.btnSell.TabIndex = 0;
            this.btnSell.Text = "Đặt hàng";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(66)))), ((int)(((byte)(32)))));
            this.btnBanHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanHang.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBanHang.FlatAppearance.BorderSize = 0;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Location = new System.Drawing.Point(0, 157);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btnBanHang.Size = new System.Drawing.Size(281, 43);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "Bán hàng";
            this.btnBanHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(42)))), ((int)(((byte)(22)))));
            this.panelLogo.BackgroundImage = global::Interface.Properties.Resources.logo21;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(281, 157);
            this.panelLogo.TabIndex = 0;
            // 
            // siiButton1
            // 
            this.siiButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(66)))), ((int)(((byte)(32)))));
            this.siiButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(66)))), ((int)(((byte)(32)))));
            this.siiButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton1.BorderRadius = 39;
            this.siiButton1.BorderSize = 0;
            this.siiButton1.FlatAppearance.BorderSize = 0;
            this.siiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton1.ForeColor = System.Drawing.Color.Black;
            this.siiButton1.Location = new System.Drawing.Point(12, 753);
            this.siiButton1.Name = "siiButton1";
            this.siiButton1.Size = new System.Drawing.Size(256, 61);
            this.siiButton1.TabIndex = 0;
            this.siiButton1.Text = "Đăng xuất";
            this.siiButton1.TextColor = System.Drawing.Color.Black;
            this.siiButton1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.panel3.BackgroundImage = global::Interface.Properties.Resources.logo;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(281, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1141, 910);
            this.panel3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 910);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sii Coffee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelQuanLySubmenu.ResumeLayout(false);
            this.panelKhoSubmenu.ResumeLayout(false);
            this.panelBanHangSubmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelBanHangSubmenu;
        private Button btnReportSales;
        private Button btnShiftDetails;
        private Button btnSell;
        private Panel panelLogo;
        private Panel panel3;
        private Button btnKho;
        private Panel panelKhoSubmenu;
        private Button btnResources;
        private Button btnInventory;
        private Button btnExport;
        private Button btnEnter;
        private Button btnBanHang;
        private SiiControls.SiiButton siiButton1;
        private Button btnQuanLy;
        private Panel panelQuanLySubmenu;
        private Button btnNCC;
        private Button btnMaterials;
        private Button btnProducts;
        private Button btnPaymentMethods;
        private Button btnDiscount;
        private Button btnManageAccount;
    }
}