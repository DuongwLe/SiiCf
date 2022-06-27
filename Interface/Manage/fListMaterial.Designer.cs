namespace Interface.Manage
{
    partial class fListMaterial
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
            this.btnDMNL = new Interface.SiiControls.SiiButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbMoTa = new System.Windows.Forms.ListBox();
            this.TabNL = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cnxtxFunctions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thêmSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtgvNL = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.cnxtxFunctions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDMNL
            // 
            this.btnDMNL.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDMNL.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnDMNL.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.btnDMNL.BorderColor = System.Drawing.Color.Transparent;
            this.btnDMNL.BorderRadius = 40;
            this.btnDMNL.BorderSize = 0;
            this.btnDMNL.FlatAppearance.BorderSize = 0;
            this.btnDMNL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDMNL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDMNL.ForeColor = System.Drawing.Color.Black;
            this.btnDMNL.Location = new System.Drawing.Point(833, 93);
            this.btnDMNL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDMNL.Name = "btnDMNL";
            this.btnDMNL.Size = new System.Drawing.Size(285, 46);
            this.btnDMNL.TabIndex = 22;
            this.btnDMNL.Text = "Danh mục nguyên liệu";
            this.btnDMNL.TextColor = System.Drawing.Color.Black;
            this.btnDMNL.UseVisualStyleBackColor = false;
            this.btnDMNL.Click += new System.EventHandler(this.btnDMNL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(699, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Mô Tả";
            // 
            // lsbMoTa
            // 
            this.lsbMoTa.FormattingEnabled = true;
            this.lsbMoTa.ItemHeight = 19;
            this.lsbMoTa.Location = new System.Drawing.Point(699, 182);
            this.lsbMoTa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lsbMoTa.Name = "lsbMoTa";
            this.lsbMoTa.Size = new System.Drawing.Size(419, 270);
            this.lsbMoTa.TabIndex = 19;
            // 
            // TabNL
            // 
            this.TabNL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabNL.Location = new System.Drawing.Point(12, 150);
            this.TabNL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TabNL.Name = "TabNL";
            this.TabNL.Padding = new System.Drawing.Point(6, 6);
            this.TabNL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabNL.SelectedIndex = 0;
            this.TabNL.Size = new System.Drawing.Size(650, 32);
            this.TabNL.TabIndex = 6;
            this.TabNL.SelectedIndexChanged += new System.EventHandler(this.TabNL_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(318, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 62);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh sách nguyên liệu";
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
            this.cnxtxFunctions.Size = new System.Drawing.Size(219, 110);
            // 
            // thêmSảnPhẩmToolStripMenuItem
            // 
            this.thêmSảnPhẩmToolStripMenuItem.Name = "thêmSảnPhẩmToolStripMenuItem";
            this.thêmSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.thêmSảnPhẩmToolStripMenuItem.Text = "Thêm nguyên liệu";
            this.thêmSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.thêmSảnPhẩmToolStripMenuItem_Click);
            // 
            // xóaSảnPhẩmToolStripMenuItem
            // 
            this.xóaSảnPhẩmToolStripMenuItem.Name = "xóaSảnPhẩmToolStripMenuItem";
            this.xóaSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.xóaSảnPhẩmToolStripMenuItem.Text = "Xóa nguyên liệu";
            this.xóaSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.xóaSảnPhẩmToolStripMenuItem_Click);
            // 
            // sửaSảnPhẩmToolStripMenuItem
            // 
            this.sửaSảnPhẩmToolStripMenuItem.Name = "sửaSảnPhẩmToolStripMenuItem";
            this.sửaSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.sửaSảnPhẩmToolStripMenuItem.Text = "Sửa nguyên liệu";
            this.sửaSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sửaSảnPhẩmToolStripMenuItem_Click);
            // 
            // dtgvNL
            // 
            this.dtgvNL.AllowUserToAddRows = false;
            this.dtgvNL.AllowUserToDeleteRows = false;
            this.dtgvNL.AllowUserToResizeColumns = false;
            this.dtgvNL.AllowUserToResizeRows = false;
            this.dtgvNL.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNL.Location = new System.Drawing.Point(12, 182);
            this.dtgvNL.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtgvNL.Name = "dtgvNL";
            this.dtgvNL.ReadOnly = true;
            this.dtgvNL.RowHeadersVisible = false;
            this.dtgvNL.RowHeadersWidth = 51;
            this.dtgvNL.RowTemplate.Height = 29;
            this.dtgvNL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvNL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNL.Size = new System.Drawing.Size(650, 645);
            this.dtgvNL.TabIndex = 5;
            this.dtgvNL.SelectionChanged += new System.EventHandler(this.dtgvNL_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 843);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "(Click phải để chọn chức năng)";
            // 
            // fListMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1141, 910);
            this.ContextMenuStrip = this.cnxtxFunctions;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgvNL);
            this.Controls.Add(this.btnDMNL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsbMoTa);
            this.Controls.Add(this.TabNL);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fListMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fListMaterial";
            this.Load += new System.EventHandler(this.fListMaterial_Load);
            this.cnxtxFunctions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiiControls.SiiButton btnDMNL;
        private Label label2;
        private ListBox lsbMoTa;
        private TabControl TabNL;
        private Label label1;
        private ContextMenuStrip cnxtxFunctions;
        private ToolStripMenuItem thêmSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem xóaSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem sửaSảnPhẩmToolStripMenuItem;
        private Label label4;
        private DataGridView dtgvNL;
    }
}