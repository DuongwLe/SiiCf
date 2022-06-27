namespace Interface.SellSystem
{
    partial class fOrder
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
            this.components = new System.ComponentModel.Container();
            this.dtgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.siiButton1 = new Interface.SiiControls.SiiButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvThanhToan = new System.Windows.Forms.DataGridView();
            this.columSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columGiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cntxTamTinh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaSốLượngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaĐồUốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTien = new Interface.SiiControls.SiiTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TabOrder = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaGG = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblActiveCa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThanhToan)).BeginInit();
            this.cntxTamTinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvLoaiSP
            // 
            this.dtgvLoaiSP.AllowUserToAddRows = false;
            this.dtgvLoaiSP.AllowUserToDeleteRows = false;
            this.dtgvLoaiSP.AllowUserToResizeColumns = false;
            this.dtgvLoaiSP.AllowUserToResizeRows = false;
            this.dtgvLoaiSP.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvLoaiSP.ColumnHeadersHeight = 29;
            this.dtgvLoaiSP.Location = new System.Drawing.Point(32, 129);
            this.dtgvLoaiSP.Name = "dtgvLoaiSP";
            this.dtgvLoaiSP.ReadOnly = true;
            this.dtgvLoaiSP.RowHeadersVisible = false;
            this.dtgvLoaiSP.RowHeadersWidth = 51;
            this.dtgvLoaiSP.RowTemplate.Height = 29;
            this.dtgvLoaiSP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvLoaiSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLoaiSP.Size = new System.Drawing.Size(650, 595);
            this.dtgvLoaiSP.TabIndex = 0;
            this.dtgvLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoaiSP_CellClick);
            this.dtgvLoaiSP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoaiSP_CellDoubleClick);
            // 
            // siiButton1
            // 
            this.siiButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.siiButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.siiButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton1.BorderRadius = 34;
            this.siiButton1.BorderSize = 0;
            this.siiButton1.FlatAppearance.BorderSize = 0;
            this.siiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siiButton1.ForeColor = System.Drawing.Color.Black;
            this.siiButton1.Location = new System.Drawing.Point(939, 808);
            this.siiButton1.Name = "siiButton1";
            this.siiButton1.Size = new System.Drawing.Size(138, 44);
            this.siiButton1.TabIndex = 2;
            this.siiButton1.Text = "Đặt hàng";
            this.siiButton1.TextColor = System.Drawing.Color.Black;
            this.siiButton1.UseVisualStyleBackColor = false;
            this.siiButton1.Click += new System.EventHandler(this.siiButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(32, 736);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "(Nhấn 2 lần thêm sản phẩm để thêm vào giỏ hàng)";
            // 
            // dtgvThanhToan
            // 
            this.dtgvThanhToan.AllowUserToAddRows = false;
            this.dtgvThanhToan.AllowUserToDeleteRows = false;
            this.dtgvThanhToan.AllowUserToResizeColumns = false;
            this.dtgvThanhToan.AllowUserToResizeRows = false;
            this.dtgvThanhToan.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvThanhToan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columSTT,
            this.columTenSP,
            this.Soluong,
            this.columGiaTien,
            this.index});
            this.dtgvThanhToan.ContextMenuStrip = this.cntxTamTinh;
            this.dtgvThanhToan.Location = new System.Drawing.Point(723, 129);
            this.dtgvThanhToan.Name = "dtgvThanhToan";
            this.dtgvThanhToan.ReadOnly = true;
            this.dtgvThanhToan.RowHeadersVisible = false;
            this.dtgvThanhToan.RowHeadersWidth = 51;
            this.dtgvThanhToan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvThanhToan.RowTemplate.Height = 29;
            this.dtgvThanhToan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvThanhToan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvThanhToan.Size = new System.Drawing.Size(393, 514);
            this.dtgvThanhToan.TabIndex = 7;
            this.dtgvThanhToan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvThanhToan_CellClick);
            // 
            // columSTT
            // 
            this.columSTT.HeaderText = "STT";
            this.columSTT.MinimumWidth = 6;
            this.columSTT.Name = "columSTT";
            this.columSTT.ReadOnly = true;
            this.columSTT.Width = 50;
            // 
            // columTenSP
            // 
            this.columTenSP.HeaderText = "Tên đồ uống";
            this.columTenSP.MinimumWidth = 6;
            this.columTenSP.Name = "columTenSP";
            this.columTenSP.ReadOnly = true;
            this.columTenSP.Width = 125;
            // 
            // Soluong
            // 
            this.Soluong.HeaderText = "Số lượng";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.ReadOnly = true;
            this.Soluong.Width = 125;
            // 
            // columGiaTien
            // 
            this.columGiaTien.HeaderText = "Giá tiền";
            this.columGiaTien.MinimumWidth = 6;
            this.columGiaTien.Name = "columGiaTien";
            this.columGiaTien.ReadOnly = true;
            this.columGiaTien.Width = 125;
            // 
            // index
            // 
            this.index.HeaderText = "index";
            this.index.MinimumWidth = 6;
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 125;
            // 
            // cntxTamTinh
            // 
            this.cntxTamTinh.BackColor = System.Drawing.SystemColors.Control;
            this.cntxTamTinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cntxTamTinh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cntxTamTinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaSốLượngToolStripMenuItem,
            this.xóaĐồUốngToolStripMenuItem});
            this.cntxTamTinh.Name = "cntxTamTinh";
            this.cntxTamTinh.Size = new System.Drawing.Size(167, 52);
            // 
            // sửaSốLượngToolStripMenuItem
            // 
            this.sửaSốLượngToolStripMenuItem.Name = "sửaSốLượngToolStripMenuItem";
            this.sửaSốLượngToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.sửaSốLượngToolStripMenuItem.Text = "Sửa số lượng";
            this.sửaSốLượngToolStripMenuItem.Click += new System.EventHandler(this.sửaSốLượngToolStripMenuItem_Click);
            // 
            // xóaĐồUốngToolStripMenuItem
            // 
            this.xóaĐồUốngToolStripMenuItem.Name = "xóaĐồUốngToolStripMenuItem";
            this.xóaĐồUốngToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.xóaĐồUốngToolStripMenuItem.Text = "Xóa đồ uống";
            this.xóaĐồUốngToolStripMenuItem.Click += new System.EventHandler(this.xóaĐồUốngToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(851, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giỏ hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(730, 761);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(853, 761);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 26);
            this.label5.TabIndex = 10;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.txtTongTien.BorderColor = System.Drawing.Color.Black;
            this.txtTongTien.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtTongTien.BorderRadius = 0;
            this.txtTongTien.BorderSize = 2;
            this.txtTongTien.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTongTien.Location = new System.Drawing.Point(844, 754);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Multiline = false;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTongTien.PasswordChar = false;
            this.txtTongTien.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtTongTien.PlaceholderText = "";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(214, 41);
            this.txtTongTien.TabIndex = 11;
            this.txtTongTien.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(723, 657);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "(Nhấn chuột phải để chọn chức năng)";
            // 
            // TabOrder
            // 
            this.TabOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabOrder.Location = new System.Drawing.Point(32, 97);
            this.TabOrder.Name = "TabOrder";
            this.TabOrder.Padding = new System.Drawing.Point(6, 6);
            this.TabOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabOrder.SelectedIndex = 0;
            this.TabOrder.Size = new System.Drawing.Size(650, 32);
            this.TabOrder.TabIndex = 0;
            this.TabOrder.SelectedIndexChanged += new System.EventHandler(this.TabOrder_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "Đặt hàng";
            // 
            // cboMaGG
            // 
            this.cboMaGG.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboMaGG.FormattingEnabled = true;
            this.cboMaGG.Location = new System.Drawing.Point(723, 713);
            this.cboMaGG.Name = "cboMaGG";
            this.cboMaGG.Size = new System.Drawing.Size(393, 34);
            this.cboMaGG.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(895, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Trạng thái:";
            // 
            // lblActiveCa
            // 
            this.lblActiveCa.AutoSize = true;
            this.lblActiveCa.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActiveCa.Location = new System.Drawing.Point(991, 9);
            this.lblActiveCa.Name = "lblActiveCa";
            this.lblActiveCa.Size = new System.Drawing.Size(92, 20);
            this.lblActiveCa.TabIndex = 15;
            this.lblActiveCa.Text = "Đang đóng.";
            // 
            // fOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1141, 910);
            this.Controls.Add(this.lblActiveCa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboMaGG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvThanhToan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgvLoaiSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siiButton1);
            this.Controls.Add(this.TabOrder);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fOrder";
            this.Load += new System.EventHandler(this.fOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvThanhToan)).EndInit();
            this.cntxTamTinh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SiiControls.SiiButton siiButton1;
        private DataGridView dtgvLoaiSP;
        private Label label2;
        private DataGridView dtgvThanhToan;
        private Label label3;
        private Label label4;
        private Label label5;
        private SiiControls.SiiTextBox txtTongTien;
        private ContextMenuStrip cntxTamTinh;
        private ToolStripMenuItem sửaSốLượngToolStripMenuItem;
        private ToolStripMenuItem xóaĐồUốngToolStripMenuItem;
        private Label label6;
        private TabControl TabOrder;
        private Label label1;
        private DataGridViewTextBoxColumn columSTT;
        private DataGridViewTextBoxColumn columTenSP;
        private DataGridViewTextBoxColumn Soluong;
        private DataGridViewTextBoxColumn columGiaTien;
        private DataGridViewTextBoxColumn index;
        private ComboBox cboMaGG;
        private Label label7;
        private Label lblActiveCa;
    }
}