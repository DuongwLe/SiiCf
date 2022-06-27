namespace Interface.Manage
{
    partial class fProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgvCongThuc = new System.Windows.Forms.DataGridView();
            this.TenNLCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNLCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNLCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvNL = new System.Windows.Forms.DataGridView();
            this.dtgvDMNL = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXacNhan = new Interface.SiiControls.SiiButton();
            this.btnNhapLai = new Interface.SiiControls.SiiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSP = new Interface.SiiControls.SiiTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDMSP = new Interface.SiiControls.SiiComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonGia = new Interface.SiiControls.SiiTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMoTa = new Interface.SiiControls.SiiTextBox();
            this.TenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siiButton3 = new Interface.SiiControls.SiiButton();
            this.dtgvTenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenLieuj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.soLuongNL = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenLieeuj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCongThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDMNL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongNL)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvCongThuc
            // 
            this.dtgvCongThuc.AllowUserToAddRows = false;
            this.dtgvCongThuc.AllowUserToDeleteRows = false;
            this.dtgvCongThuc.AllowUserToResizeColumns = false;
            this.dtgvCongThuc.AllowUserToResizeRows = false;
            this.dtgvCongThuc.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCongThuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCongThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCongThuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNLCT,
            this.SoLuongNLCT,
            this.MaNLCT});
            this.dtgvCongThuc.Location = new System.Drawing.Point(13, 542);
            this.dtgvCongThuc.Name = "dtgvCongThuc";
            this.dtgvCongThuc.ReadOnly = true;
            this.dtgvCongThuc.RowHeadersVisible = false;
            this.dtgvCongThuc.RowHeadersWidth = 51;
            this.dtgvCongThuc.RowTemplate.Height = 29;
            this.dtgvCongThuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvCongThuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCongThuc.Size = new System.Drawing.Size(611, 354);
            this.dtgvCongThuc.TabIndex = 1;
            this.dtgvCongThuc.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCongThuc_CellDoubleClick);
            this.dtgvCongThuc.SelectionChanged += new System.EventHandler(this.dtgvCongThuc_SelectionChanged);
            // 
            // TenNLCT
            // 
            this.TenNLCT.HeaderText = "Nguyên liệu";
            this.TenNLCT.MinimumWidth = 6;
            this.TenNLCT.Name = "TenNLCT";
            this.TenNLCT.ReadOnly = true;
            this.TenNLCT.Width = 400;
            // 
            // SoLuongNLCT
            // 
            this.SoLuongNLCT.HeaderText = "Số lượng";
            this.SoLuongNLCT.MinimumWidth = 6;
            this.SoLuongNLCT.Name = "SoLuongNLCT";
            this.SoLuongNLCT.ReadOnly = true;
            this.SoLuongNLCT.Width = 230;
            // 
            // MaNLCT
            // 
            this.MaNLCT.HeaderText = "MaNL";
            this.MaNLCT.MinimumWidth = 6;
            this.MaNLCT.Name = "MaNLCT";
            this.MaNLCT.ReadOnly = true;
            this.MaNLCT.Visible = false;
            this.MaNLCT.Width = 125;
            // 
            // dtgvNL
            // 
            this.dtgvNL.AllowUserToAddRows = false;
            this.dtgvNL.AllowUserToDeleteRows = false;
            this.dtgvNL.AllowUserToResizeColumns = false;
            this.dtgvNL.AllowUserToResizeRows = false;
            this.dtgvNL.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNL.Location = new System.Drawing.Point(829, 106);
            this.dtgvNL.Name = "dtgvNL";
            this.dtgvNL.ReadOnly = true;
            this.dtgvNL.RowHeadersVisible = false;
            this.dtgvNL.RowHeadersWidth = 51;
            this.dtgvNL.RowTemplate.Height = 29;
            this.dtgvNL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvNL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNL.Size = new System.Drawing.Size(320, 647);
            this.dtgvNL.TabIndex = 2;
            this.dtgvNL.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNL_CellDoubleClick);
            // 
            // dtgvDMNL
            // 
            this.dtgvDMNL.AllowUserToAddRows = false;
            this.dtgvDMNL.AllowUserToDeleteRows = false;
            this.dtgvDMNL.AllowUserToResizeColumns = false;
            this.dtgvDMNL.AllowUserToResizeRows = false;
            this.dtgvDMNL.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvDMNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDMNL.Location = new System.Drawing.Point(648, 106);
            this.dtgvDMNL.Name = "dtgvDMNL";
            this.dtgvDMNL.ReadOnly = true;
            this.dtgvDMNL.RowHeadersVisible = false;
            this.dtgvDMNL.RowHeadersWidth = 51;
            this.dtgvDMNL.RowTemplate.Height = 29;
            this.dtgvDMNL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvDMNL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDMNL.Size = new System.Drawing.Size(175, 647);
            this.dtgvDMNL.TabIndex = 3;
            this.dtgvDMNL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDMNL_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(362, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 62);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tạo mới sản phẩm";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXacNhan.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnXacNhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXacNhan.BorderRadius = 38;
            this.btnXacNhan.BorderSize = 0;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Location = new System.Drawing.Point(934, 862);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(171, 53);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.TextColor = System.Drawing.Color.Black;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.BackColor = System.Drawing.Color.Crimson;
            this.btnNhapLai.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnNhapLai.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNhapLai.BorderRadius = 30;
            this.btnNhapLai.BorderSize = 0;
            this.btnNhapLai.FlatAppearance.BorderSize = 0;
            this.btnNhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNhapLai.ForeColor = System.Drawing.Color.Black;
            this.btnNhapLai.Location = new System.Drawing.Point(716, 862);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(171, 53);
            this.btnNhapLai.TabIndex = 8;
            this.btnNhapLai.Text = "Nhập Lại";
            this.btnNhapLai.TextColor = System.Drawing.Color.Black;
            this.btnNhapLai.UseVisualStyleBackColor = false;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(98, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenSP.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtTenSP.BorderFocusColor = System.Drawing.Color.Lime;
            this.txtTenSP.BorderRadius = 0;
            this.txtTenSP.BorderSize = 2;
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenSP.Location = new System.Drawing.Point(248, 106);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Multiline = false;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenSP.PasswordChar = false;
            this.txtTenSP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenSP.PlaceholderText = "";
            this.txtTenSP.ReadOnly = false;
            this.txtTenSP.Size = new System.Drawing.Size(284, 37);
            this.txtTenSP.TabIndex = 14;
            this.txtTenSP.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(13, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Chọn danh mục sản phẩm:";
            // 
            // cboDMSP
            // 
            this.cboDMSP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboDMSP.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cboDMSP.BorderSize = 2;
            this.cboDMSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cboDMSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboDMSP.ForeColor = System.Drawing.Color.DimGray;
            this.cboDMSP.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.cboDMSP.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cboDMSP.ListTextColor = System.Drawing.Color.DimGray;
            this.cboDMSP.Location = new System.Drawing.Point(248, 178);
            this.cboDMSP.MinimumSize = new System.Drawing.Size(200, 30);
            this.cboDMSP.Name = "cboDMSP";
            this.cboDMSP.Padding = new System.Windows.Forms.Padding(2);
            this.cboDMSP.Size = new System.Drawing.Size(284, 39);
            this.cboDMSP.TabIndex = 16;
            this.cboDMSP.Texts = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(143, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.Window;
            this.txtDonGia.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtDonGia.BorderFocusColor = System.Drawing.Color.Lime;
            this.txtDonGia.BorderRadius = 0;
            this.txtDonGia.BorderSize = 2;
            this.txtDonGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDonGia.Location = new System.Drawing.Point(248, 247);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Multiline = false;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonGia.PasswordChar = false;
            this.txtDonGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.ReadOnly = false;
            this.txtDonGia.Size = new System.Drawing.Size(284, 37);
            this.txtDonGia.TabIndex = 18;
            this.txtDonGia.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(160, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BackColor = System.Drawing.SystemColors.Window;
            this.txtMoTa.BorderColor = System.Drawing.Color.RoyalBlue;
            this.txtMoTa.BorderFocusColor = System.Drawing.Color.Lime;
            this.txtMoTa.BorderRadius = 0;
            this.txtMoTa.BorderSize = 2;
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoTa.Location = new System.Drawing.Point(248, 306);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMoTa.PasswordChar = false;
            this.txtMoTa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.ReadOnly = false;
            this.txtMoTa.Size = new System.Drawing.Size(376, 218);
            this.txtMoTa.TabIndex = 20;
            this.txtMoTa.UnderlinedStyle = false;
            // 
            // TenNL
            // 
            this.TenNL.HeaderText = "Nguyên Liệu";
            this.TenNL.MinimumWidth = 6;
            this.TenNL.Name = "TenNL";
            this.TenNL.ReadOnly = true;
            this.TenNL.Width = 125;
            // 
            // siiButton3
            // 
            this.siiButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.siiButton3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.siiButton3.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.siiButton3.BorderColor = System.Drawing.Color.Transparent;
            this.siiButton3.BorderRadius = 40;
            this.siiButton3.BorderSize = 0;
            this.siiButton3.FlatAppearance.BorderSize = 0;
            this.siiButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siiButton3.ForeColor = System.Drawing.Color.Black;
            this.siiButton3.Location = new System.Drawing.Point(864, 37);
            this.siiButton3.Name = "siiButton3";
            this.siiButton3.Size = new System.Drawing.Size(285, 46);
            this.siiButton3.TabIndex = 21;
            this.siiButton3.Text = "Danh mục sản phẩm";
            this.siiButton3.TextColor = System.Drawing.Color.Black;
            this.siiButton3.UseVisualStyleBackColor = false;
            this.siiButton3.Click += new System.EventHandler(this.siiButton3_Click);
            // 
            // dtgvTenNL
            // 
            this.dtgvTenNL.HeaderText = "Nguyên Liệu";
            this.dtgvTenNL.MinimumWidth = 6;
            this.dtgvTenNL.Name = "dtgvTenNL";
            this.dtgvTenNL.Width = 300;
            // 
            // NguyenLieuj
            // 
            this.NguyenLieuj.HeaderText = "Nguyên liệu";
            this.NguyenLieuj.MinimumWidth = 6;
            this.NguyenLieuj.Name = "NguyenLieuj";
            this.NguyenLieuj.ReadOnly = true;
            this.NguyenLieuj.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(948, 814);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 26);
            this.label4.TabIndex = 38;
            this.label4.Text = "g";
            // 
            // soLuongNL
            // 
            this.soLuongNL.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.soLuongNL.Location = new System.Drawing.Point(829, 809);
            this.soLuongNL.Name = "soLuongNL";
            this.soLuongNL.Size = new System.Drawing.Size(110, 34);
            this.soLuongNL.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(691, 814);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 22);
            this.label7.TabIndex = 36;
            this.label7.Text = "Số Lượng:";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nguyên liệu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // NguyenLieu
            // 
            this.NguyenLieu.HeaderText = "Nguyên liệu";
            this.NguyenLieu.MinimumWidth = 6;
            this.NguyenLieu.Name = "NguyenLieu";
            this.NguyenLieu.ReadOnly = true;
            this.NguyenLieu.Width = 300;
            // 
            // NguyenLieeuj
            // 
            this.NguyenLieeuj.HeaderText = "Nguyên liệu";
            this.NguyenLieeuj.MinimumWidth = 6;
            this.NguyenLieeuj.Name = "NguyenLieeuj";
            this.NguyenLieeuj.ReadOnly = true;
            this.NguyenLieeuj.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nguyên liệu";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 911);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(272, 23);
            this.label8.TabIndex = 39;
            this.label8.Text = "(Click 2 lần để xóa nguyên liệu)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(829, 767);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "(Click 2 lần để thêm nguyên liệu)";
            // 
            // fProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1163, 943);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.soLuongNL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.siiButton3);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboDMSP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.dtgvDMNL);
            this.Controls.Add(this.dtgvNL);
            this.Controls.Add(this.dtgvCongThuc);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới sản phẩm";
            this.Load += new System.EventHandler(this.fProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCongThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDMNL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongNL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgvCongThuc;
        private DataGridView dtgvNL;
        private DataGridView dtgvDMNL;
        private Label label2;
        private SiiControls.SiiButton btnXacNhan;
        private SiiControls.SiiButton btnNhapLai;
        private Label label1;
        private SiiControls.SiiTextBox txtTenSP;
        private Label label3;
        private SiiControls.SiiComboBox cboDMSP;
        private Label label5;
        private SiiControls.SiiTextBox txtDonGia;
        private Label label6;
        private SiiControls.SiiTextBox txtMoTa;
        private DataGridViewTextBoxColumn TenNL;
        private SiiControls.SiiButton siiButton3;
        private DataGridViewTextBoxColumn dtgvTenNL;
        private DataGridViewTextBoxColumn NguyenLieuj;
        private Label label4;
        private NumericUpDown soLuongNL;
        private Label label7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn NguyenLieu;
        private DataGridViewTextBoxColumn NguyenLieeuj;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn TenNLCT;
        private DataGridViewTextBoxColumn SoLuongNLCT;
        private DataGridViewTextBoxColumn MaNLCT;
        private Label label8;
        private Label label9;
    }
}