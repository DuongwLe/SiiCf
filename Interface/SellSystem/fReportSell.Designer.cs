namespace Interface.SellSystem
{
    partial class fReportSell
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DatePick = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgvDSBH = new System.Windows.Forms.DataGridView();
            this.rdoNgay = new Interface.SiiControls.SiiRadioButton();
            this.rdoThang = new Interface.SiiControls.SiiRadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgvPTTT = new System.Windows.Forms.DataGridView();
            this.columTenPTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columMaPTTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblChietKhau = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTBHoaDon = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPhieuGG = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongGG = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInBaoCao = new Interface.SiiControls.SiiButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvChiTietHDBH = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBH)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPTTT)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHDBH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(332, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "Báo cáo doanh thu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(65, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 32;
            this.label6.Text = "Thời gian:";
            // 
            // DatePick
            // 
            this.DatePick.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePick.Location = new System.Drawing.Point(182, 150);
            this.DatePick.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DatePick.Name = "DatePick";
            this.DatePick.Size = new System.Drawing.Size(129, 30);
            this.DatePick.TabIndex = 31;
            this.DatePick.ValueChanged += new System.EventHandler(this.DatePick_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(65, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 33);
            this.label7.TabIndex = 30;
            this.label7.Text = "Danh sách báo cáo";
            // 
            // dtgvDSBH
            // 
            this.dtgvDSBH.AllowUserToAddRows = false;
            this.dtgvDSBH.AllowUserToDeleteRows = false;
            this.dtgvDSBH.AllowUserToResizeColumns = false;
            this.dtgvDSBH.AllowUserToResizeRows = false;
            this.dtgvDSBH.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvDSBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSBH.Location = new System.Drawing.Point(11, 201);
            this.dtgvDSBH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgvDSBH.Name = "dtgvDSBH";
            this.dtgvDSBH.ReadOnly = true;
            this.dtgvDSBH.RowHeadersVisible = false;
            this.dtgvDSBH.RowHeadersWidth = 51;
            this.dtgvDSBH.RowTemplate.Height = 29;
            this.dtgvDSBH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvDSBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSBH.Size = new System.Drawing.Size(720, 319);
            this.dtgvDSBH.TabIndex = 29;
            this.dtgvDSBH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSBH_CellClick);
            // 
            // rdoNgay
            // 
            this.rdoNgay.AutoSize = true;
            this.rdoNgay.Checked = true;
            this.rdoNgay.CheckedColor = System.Drawing.Color.MediumSeaGreen;
            this.rdoNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoNgay.Location = new System.Drawing.Point(377, 150);
            this.rdoNgay.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdoNgay.Name = "rdoNgay";
            this.rdoNgay.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdoNgay.Size = new System.Drawing.Size(82, 26);
            this.rdoNgay.TabIndex = 41;
            this.rdoNgay.TabStop = true;
            this.rdoNgay.Text = "Ngày";
            this.rdoNgay.UnCheckedColor = System.Drawing.Color.IndianRed;
            this.rdoNgay.UseVisualStyleBackColor = true;
            // 
            // rdoThang
            // 
            this.rdoThang.AutoSize = true;
            this.rdoThang.CheckedColor = System.Drawing.Color.MediumSeaGreen;
            this.rdoThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdoThang.Location = new System.Drawing.Point(501, 150);
            this.rdoThang.MinimumSize = new System.Drawing.Size(0, 21);
            this.rdoThang.Name = "rdoThang";
            this.rdoThang.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rdoThang.Size = new System.Drawing.Size(89, 26);
            this.rdoThang.TabIndex = 42;
            this.rdoThang.Text = "Tháng";
            this.rdoThang.UnCheckedColor = System.Drawing.Color.Orange;
            this.rdoThang.UseVisualStyleBackColor = true;
            this.rdoThang.CheckedChanged += new System.EventHandler(this.rdoThang_CheckedChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.dtgvPTTT);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(751, 526);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(379, 371);
            this.panel7.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(261, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 55;
            this.label3.Text = "Số lượng";
            // 
            // dtgvPTTT
            // 
            this.dtgvPTTT.AllowUserToAddRows = false;
            this.dtgvPTTT.AllowUserToDeleteRows = false;
            this.dtgvPTTT.AllowUserToResizeColumns = false;
            this.dtgvPTTT.AllowUserToResizeRows = false;
            this.dtgvPTTT.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvPTTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPTTT.ColumnHeadersVisible = false;
            this.dtgvPTTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columTenPTTT,
            this.columSoLuong,
            this.columMaPTTT});
            this.dtgvPTTT.Location = new System.Drawing.Point(13, 48);
            this.dtgvPTTT.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgvPTTT.Name = "dtgvPTTT";
            this.dtgvPTTT.ReadOnly = true;
            this.dtgvPTTT.RowHeadersVisible = false;
            this.dtgvPTTT.RowHeadersWidth = 51;
            this.dtgvPTTT.RowTemplate.Height = 29;
            this.dtgvPTTT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvPTTT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPTTT.Size = new System.Drawing.Size(356, 309);
            this.dtgvPTTT.TabIndex = 54;
            // 
            // columTenPTTT
            // 
            this.columTenPTTT.HeaderText = "Phương thức thanh toán";
            this.columTenPTTT.MinimumWidth = 6;
            this.columTenPTTT.Name = "columTenPTTT";
            this.columTenPTTT.ReadOnly = true;
            this.columTenPTTT.Width = 230;
            // 
            // columSoLuong
            // 
            this.columSoLuong.HeaderText = "Số lượng";
            this.columSoLuong.MinimumWidth = 6;
            this.columSoLuong.Name = "columSoLuong";
            this.columSoLuong.ReadOnly = true;
            this.columSoLuong.Width = 300;
            // 
            // columMaPTTT
            // 
            this.columMaPTTT.HeaderText = "Column1";
            this.columMaPTTT.MinimumWidth = 6;
            this.columMaPTTT.Name = "columMaPTTT";
            this.columMaPTTT.ReadOnly = true;
            this.columMaPTTT.Visible = false;
            this.columMaPTTT.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phương thức thanh toán";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblChietKhau);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(500, 544);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(209, 141);
            this.panel6.TabIndex = 74;
            // 
            // lblChietKhau
            // 
            this.lblChietKhau.AutoSize = true;
            this.lblChietKhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChietKhau.Location = new System.Drawing.Point(25, 79);
            this.lblChietKhau.Name = "lblChietKhau";
            this.lblChietKhau.Size = new System.Drawing.Size(23, 26);
            this.lblChietKhau.TabIndex = 1;
            this.lblChietKhau.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(23, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng chiết khấu";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lblSoHD);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Location = new System.Drawing.Point(264, 718);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(209, 141);
            this.panel5.TabIndex = 70;
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSoHD.Location = new System.Drawing.Point(25, 79);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(23, 26);
            this.lblSoHD.TabIndex = 1;
            this.lblSoHD.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(23, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số hóa đơn";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lblTBHoaDon);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(27, 718);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 141);
            this.panel4.TabIndex = 71;
            // 
            // lblTBHoaDon
            // 
            this.lblTBHoaDon.AutoSize = true;
            this.lblTBHoaDon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTBHoaDon.Location = new System.Drawing.Point(25, 79);
            this.lblTBHoaDon.Name = "lblTBHoaDon";
            this.lblTBHoaDon.Size = new System.Drawing.Size(23, 26);
            this.lblTBHoaDon.TabIndex = 1;
            this.lblTBHoaDon.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(23, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Trung bình hóa đơn";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblPhieuGG);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(500, 718);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 141);
            this.panel3.TabIndex = 72;
            // 
            // lblPhieuGG
            // 
            this.lblPhieuGG.AutoSize = true;
            this.lblPhieuGG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhieuGG.Location = new System.Drawing.Point(25, 79);
            this.lblPhieuGG.Name = "lblPhieuGG";
            this.lblPhieuGG.Size = new System.Drawing.Size(23, 26);
            this.lblPhieuGG.TabIndex = 1;
            this.lblPhieuGG.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(23, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Phiếu giảm giá";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblTongGG);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(264, 544);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 141);
            this.panel2.TabIndex = 73;
            // 
            // lblTongGG
            // 
            this.lblTongGG.AutoSize = true;
            this.lblTongGG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTongGG.Location = new System.Drawing.Point(25, 79);
            this.lblTongGG.Name = "lblTongGG";
            this.lblTongGG.Size = new System.Drawing.Size(23, 26);
            this.lblTongGG.TabIndex = 1;
            this.lblTongGG.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(23, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tổng sau giảm giá";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblDoanhThu);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(27, 544);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 141);
            this.panel1.TabIndex = 69;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDoanhThu.Location = new System.Drawing.Point(25, 79);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(23, 26);
            this.lblDoanhThu.TabIndex = 1;
            this.lblDoanhThu.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(23, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Doanh thu";
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnInBaoCao.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnInBaoCao.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInBaoCao.BorderRadius = 30;
            this.btnInBaoCao.BorderSize = 0;
            this.btnInBaoCao.FlatAppearance.BorderSize = 0;
            this.btnInBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInBaoCao.ForeColor = System.Drawing.Color.Black;
            this.btnInBaoCao.Location = new System.Drawing.Point(921, 27);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(199, 50);
            this.btnInBaoCao.TabIndex = 75;
            this.btnInBaoCao.Text = "In báo cáo";
            this.btnInBaoCao.TextColor = System.Drawing.Color.Black;
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(825, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 33);
            this.label4.TabIndex = 34;
            this.label4.Text = "Chi tiết báo cáo";
            // 
            // dtgvChiTietHDBH
            // 
            this.dtgvChiTietHDBH.AllowUserToAddRows = false;
            this.dtgvChiTietHDBH.AllowUserToDeleteRows = false;
            this.dtgvChiTietHDBH.AllowUserToResizeColumns = false;
            this.dtgvChiTietHDBH.AllowUserToResizeRows = false;
            this.dtgvChiTietHDBH.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvChiTietHDBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChiTietHDBH.Location = new System.Drawing.Point(751, 156);
            this.dtgvChiTietHDBH.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgvChiTietHDBH.Name = "dtgvChiTietHDBH";
            this.dtgvChiTietHDBH.ReadOnly = true;
            this.dtgvChiTietHDBH.RowHeadersVisible = false;
            this.dtgvChiTietHDBH.RowHeadersWidth = 51;
            this.dtgvChiTietHDBH.RowTemplate.Height = 29;
            this.dtgvChiTietHDBH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvChiTietHDBH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChiTietHDBH.Size = new System.Drawing.Size(379, 364);
            this.dtgvChiTietHDBH.TabIndex = 33;
            // 
            // fReportSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1141, 910);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.rdoThang);
            this.Controls.Add(this.rdoNgay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgvChiTietHDBH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DatePick);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgvDSBH);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fReportSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fReportSell";
            this.Load += new System.EventHandler(this.fReportSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSBH)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPTTT)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChiTietHDBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label6;
        private DateTimePicker DatePick;
        private Label label7;
        private DataGridView dtgvDSBH;
        private SiiControls.SiiRadioButton rdoNgay;
        private SiiControls.SiiRadioButton rdoThang;
        private Panel panel7;
        private Label label3;
        private DataGridView dtgvPTTT;
        private DataGridViewTextBoxColumn columTenPTTT;
        private DataGridViewTextBoxColumn columSoLuong;
        private DataGridViewTextBoxColumn columMaPTTT;
        private Label label2;
        private Panel panel6;
        private Label lblChietKhau;
        private Label label5;
        private Panel panel5;
        private Label lblSoHD;
        private Label label12;
        private Panel panel4;
        private Label lblTBHoaDon;
        private Label label10;
        private Panel panel3;
        private Label lblPhieuGG;
        private Label label8;
        private Panel panel2;
        private Label lblTongGG;
        private Label label9;
        private Panel panel1;
        private Label lblDoanhThu;
        private Label label11;
        private SiiControls.SiiButton btnInBaoCao;
        private Label label4;
        private DataGridView dtgvChiTietHDBH;
    }
}