namespace Interface.Manage.Category
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMoTa = new Interface.SiiControls.SiiTextBox();
            this.txtTenDMSP = new Interface.SiiControls.SiiTextBox();
            this.btnThem = new Interface.SiiControls.SiiButton();
            this.btnSua = new Interface.SiiControls.SiiButton();
            this.btnXoa = new Interface.SiiControls.SiiButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 62);
            this.label1.TabIndex = 5;
            this.label1.Text = "Danh mục sản phẩm";
            // 
            // dtgvLoaiSP
            // 
            this.dtgvLoaiSP.AllowUserToAddRows = false;
            this.dtgvLoaiSP.AllowUserToDeleteRows = false;
            this.dtgvLoaiSP.AllowUserToResizeColumns = false;
            this.dtgvLoaiSP.AllowUserToResizeRows = false;
            this.dtgvLoaiSP.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoaiSP.Enabled = false;
            this.dtgvLoaiSP.Location = new System.Drawing.Point(88, 365);
            this.dtgvLoaiSP.Name = "dtgvLoaiSP";
            this.dtgvLoaiSP.ReadOnly = true;
            this.dtgvLoaiSP.RowHeadersVisible = false;
            this.dtgvLoaiSP.RowHeadersWidth = 51;
            this.dtgvLoaiSP.RowTemplate.Height = 29;
            this.dtgvLoaiSP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvLoaiSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLoaiSP.Size = new System.Drawing.Size(692, 288);
            this.dtgvLoaiSP.TabIndex = 6;
            this.dtgvLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoaiSP_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(88, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên DMSP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(130, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mô Tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BackColor = System.Drawing.SystemColors.Window;
            this.txtMoTa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMoTa.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMoTa.BorderRadius = 0;
            this.txtMoTa.BorderSize = 2;
            this.txtMoTa.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoTa.Location = new System.Drawing.Point(216, 195);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMoTa.PasswordChar = false;
            this.txtMoTa.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.ReadOnly = false;
            this.txtMoTa.Size = new System.Drawing.Size(517, 142);
            this.txtMoTa.TabIndex = 13;
            this.txtMoTa.UnderlinedStyle = false;
            // 
            // txtTenDMSP
            // 
            this.txtTenDMSP.BackColor = System.Drawing.SystemColors.Window;
            this.txtTenDMSP.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenDMSP.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenDMSP.BorderRadius = 0;
            this.txtTenDMSP.BorderSize = 2;
            this.txtTenDMSP.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenDMSP.Location = new System.Drawing.Point(216, 139);
            this.txtTenDMSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDMSP.Multiline = false;
            this.txtTenDMSP.Name = "txtTenDMSP";
            this.txtTenDMSP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTenDMSP.PasswordChar = false;
            this.txtTenDMSP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTenDMSP.PlaceholderText = "";
            this.txtTenDMSP.ReadOnly = false;
            this.txtTenDMSP.Size = new System.Drawing.Size(517, 34);
            this.txtTenDMSP.TabIndex = 14;
            this.txtTenDMSP.UnderlinedStyle = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.btnThem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BorderRadius = 36;
            this.btnThem.BorderSize = 0;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(130, 680);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(156, 42);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextColor = System.Drawing.Color.Black;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.siiButton1_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.btnSua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BorderRadius = 36;
            this.btnSua.BorderSize = 0;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(340, 680);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(156, 42);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.Black;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnXoa.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.btnXoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BorderRadius = 36;
            this.btnXoa.BorderSize = 0;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(550, 680);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(156, 42);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextColor = System.Drawing.Color.Black;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // fProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(882, 745);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenDMSP);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgvLoaiSP);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.fProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dtgvLoaiSP;
        private Label label3;
        private Label label2;
        private SiiControls.SiiTextBox txtMoTa;
        private SiiControls.SiiTextBox txtTenDMSP;
        private SiiControls.SiiButton btnThem;
        private SiiControls.SiiButton btnSua;
        private SiiControls.SiiButton btnXoa;
    }
}