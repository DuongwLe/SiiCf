namespace Interface.Manage
{
    partial class fListProducts
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.TabSP = new System.Windows.Forms.TabControl();
            this.dtgvCongThuc = new System.Windows.Forms.DataGridView();
            this.lsbMoTa = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDMSP = new Interface.SiiControls.SiiButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cnxtxFunctions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCongThuc)).BeginInit();
            this.cnxtxFunctions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(318, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách sản phẩm";
            // 
            // dtgvLoaiSP
            // 
            this.dtgvLoaiSP.AllowUserToAddRows = false;
            this.dtgvLoaiSP.AllowUserToDeleteRows = false;
            this.dtgvLoaiSP.AllowUserToResizeColumns = false;
            this.dtgvLoaiSP.AllowUserToResizeRows = false;
            this.dtgvLoaiSP.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLoaiSP.Location = new System.Drawing.Point(12, 182);
            this.dtgvLoaiSP.Name = "dtgvLoaiSP";
            this.dtgvLoaiSP.ReadOnly = true;
            this.dtgvLoaiSP.RowHeadersVisible = false;
            this.dtgvLoaiSP.RowHeadersWidth = 51;
            this.dtgvLoaiSP.RowTemplate.Height = 29;
            this.dtgvLoaiSP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvLoaiSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLoaiSP.Size = new System.Drawing.Size(650, 645);
            this.dtgvLoaiSP.TabIndex = 5;
            this.dtgvLoaiSP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoaiSP_CellDoubleClick);
            this.dtgvLoaiSP.SelectionChanged += new System.EventHandler(this.dtgvLoaiSP_SelectionChanged);
            // 
            // TabSP
            // 
            this.TabSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabSP.Location = new System.Drawing.Point(12, 150);
            this.TabSP.Name = "TabSP";
            this.TabSP.Padding = new System.Drawing.Point(6, 6);
            this.TabSP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabSP.SelectedIndex = 0;
            this.TabSP.Size = new System.Drawing.Size(650, 32);
            this.TabSP.TabIndex = 6;
            this.TabSP.SelectedIndexChanged += new System.EventHandler(this.TabSP_SelectedIndexChanged);
            // 
            // dtgvCongThuc
            // 
            this.dtgvCongThuc.AllowUserToAddRows = false;
            this.dtgvCongThuc.AllowUserToDeleteRows = false;
            this.dtgvCongThuc.AllowUserToResizeColumns = false;
            this.dtgvCongThuc.AllowUserToResizeRows = false;
            this.dtgvCongThuc.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvCongThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCongThuc.Location = new System.Drawing.Point(699, 182);
            this.dtgvCongThuc.Name = "dtgvCongThuc";
            this.dtgvCongThuc.ReadOnly = true;
            this.dtgvCongThuc.RowHeadersVisible = false;
            this.dtgvCongThuc.RowHeadersWidth = 51;
            this.dtgvCongThuc.RowTemplate.Height = 29;
            this.dtgvCongThuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvCongThuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCongThuc.Size = new System.Drawing.Size(419, 282);
            this.dtgvCongThuc.TabIndex = 8;
            // 
            // lsbMoTa
            // 
            this.lsbMoTa.FormattingEnabled = true;
            this.lsbMoTa.ItemHeight = 19;
            this.lsbMoTa.Location = new System.Drawing.Point(697, 557);
            this.lsbMoTa.Name = "lsbMoTa";
            this.lsbMoTa.Size = new System.Drawing.Size(421, 270);
            this.lsbMoTa.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(699, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Công Thức";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(697, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 33);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mô Tả";
            // 
            // btnDMSP
            // 
            this.btnDMSP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDMSP.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDMSP.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.btnDMSP.BorderColor = System.Drawing.Color.Transparent;
            this.btnDMSP.BorderRadius = 40;
            this.btnDMSP.BorderSize = 0;
            this.btnDMSP.FlatAppearance.BorderSize = 0;
            this.btnDMSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDMSP.ForeColor = System.Drawing.Color.Black;
            this.btnDMSP.Location = new System.Drawing.Point(833, 93);
            this.btnDMSP.Name = "btnDMSP";
            this.btnDMSP.Size = new System.Drawing.Size(285, 46);
            this.btnDMSP.TabIndex = 13;
            this.btnDMSP.Text = "Danh mục sản phẩm";
            this.btnDMSP.TextColor = System.Drawing.Color.Black;
            this.btnDMSP.UseVisualStyleBackColor = false;
            this.btnDMSP.Click += new System.EventHandler(this.btnDMSP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 843);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "(Click phải để chọn chức năng)";
            // 
            // cnxtxFunctions
            // 
            this.cnxtxFunctions.BackColor = System.Drawing.Color.White;
            this.cnxtxFunctions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cnxtxFunctions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cnxtxFunctions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmSảnPhẩmToolStripMenuItem,
            this.xóaSảnPhẩmToolStripMenuItem,
            this.sửaSảnPhẩmToolStripMenuItem});
            this.cnxtxFunctions.Name = "cnxtxFunctions";
            this.cnxtxFunctions.Size = new System.Drawing.Size(211, 110);
            // 
            // thêmSảnPhẩmToolStripMenuItem
            // 
            this.thêmSảnPhẩmToolStripMenuItem.Name = "thêmSảnPhẩmToolStripMenuItem";
            this.thêmSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thêmSảnPhẩmToolStripMenuItem.Text = "Thêm sản phẩm";
            this.thêmSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.thêmSảnPhẩmToolStripMenuItem_Click);
            // 
            // xóaSảnPhẩmToolStripMenuItem
            // 
            this.xóaSảnPhẩmToolStripMenuItem.Name = "xóaSảnPhẩmToolStripMenuItem";
            this.xóaSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.xóaSảnPhẩmToolStripMenuItem.Text = "Xóa sản phẩm";
            this.xóaSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.xóaSảnPhẩmToolStripMenuItem_Click);
            // 
            // sửaSảnPhẩmToolStripMenuItem
            // 
            this.sửaSảnPhẩmToolStripMenuItem.Name = "sửaSảnPhẩmToolStripMenuItem";
            this.sửaSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.sửaSảnPhẩmToolStripMenuItem.Text = "Sửa sản phẩm";
            this.sửaSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sửaSảnPhẩmToolStripMenuItem_Click);
            // 
            // fListProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1141, 910);
            this.ContextMenuStrip = this.cnxtxFunctions;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDMSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsbMoTa);
            this.Controls.Add(this.dtgvCongThuc);
            this.Controls.Add(this.dtgvLoaiSP);
            this.Controls.Add(this.TabSP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fListProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fListProducts";
            this.Load += new System.EventHandler(this.fListProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCongThuc)).EndInit();
            this.cnxtxFunctions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dtgvLoaiSP;
        private TabControl TabSP;
        private DataGridView dtgvCongThuc;
        private ListBox lsbMoTa;
        private Label label3;
        private Label label2;
        private SiiControls.SiiButton btnDMSP;
        private Label label4;
        private ContextMenuStrip cnxtxFunctions;
        private ToolStripMenuItem thêmSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem xóaSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem sửaSảnPhẩmToolStripMenuItem;
    }
}