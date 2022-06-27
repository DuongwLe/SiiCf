namespace Interface.Storehouse
{
    partial class fInventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siiButton1 = new Interface.SiiControls.SiiButton();
            this.btnConfirm = new Interface.SiiControls.SiiButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_Add = new Interface.SiiControls.SiiButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.real = new Interface.SiiControls.SiiTextBox();
            this.materialName = new Interface.SiiControls.SiiTextBox();
            this.materialId = new Interface.SiiControls.SiiTextBox();
            this.expect = new Interface.SiiControls.SiiTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diff = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(465, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kiểm kê";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column3,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(24, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(685, 670);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Nguyên Liệu";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 130;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Mã Nguyên Liệu";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số Lượng Ước Tính";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số Lượng Thực";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 130;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Chênh Lệch";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // siiButton1
            // 
            this.siiButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.siiButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.siiButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton1.BorderRadius = 37;
            this.siiButton1.BorderSize = 0;
            this.siiButton1.FlatAppearance.BorderSize = 0;
            this.siiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton1.ForeColor = System.Drawing.Color.White;
            this.siiButton1.Location = new System.Drawing.Point(664, 776);
            this.siiButton1.Name = "siiButton1";
            this.siiButton1.Size = new System.Drawing.Size(155, 37);
            this.siiButton1.TabIndex = 3;
            this.siiButton1.Text = "Hủy";
            this.siiButton1.TextColor = System.Drawing.Color.White;
            this.siiButton1.UseVisualStyleBackColor = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConfirm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnConfirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConfirm.BorderRadius = 37;
            this.btnConfirm.BorderSize = 0;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(311, 776);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(155, 37);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Xác Nhận";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.siiButton2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(729, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 28);
            this.tabControl1.TabIndex = 32;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(729, 82);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(331, 377);
            this.dataGridView2.TabIndex = 30;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Add.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Add.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Add.BorderRadius = 18;
            this.btn_Add.BorderSize = 0;
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(834, 689);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(111, 43);
            this.btn_Add.TabIndex = 28;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextColor = System.Drawing.Color.White;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(727, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã Nguyên liệu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(727, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tên Nguyên liệu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(727, 616);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Số Lượng Hiện Tại:";
            // 
            // real
            // 
            this.real.BackColor = System.Drawing.SystemColors.Window;
            this.real.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.real.BorderFocusColor = System.Drawing.Color.HotPink;
            this.real.BorderRadius = 0;
            this.real.BorderSize = 2;
            this.real.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.real.Location = new System.Drawing.Point(871, 602);
            this.real.Margin = new System.Windows.Forms.Padding(4);
            this.real.Multiline = false;
            this.real.Name = "real";
            this.real.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.real.PasswordChar = false;
            this.real.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.real.PlaceholderText = "";
            this.real.ReadOnly = false;
            this.real.Size = new System.Drawing.Size(177, 30);
            this.real.TabIndex = 13;
            this.real.UnderlinedStyle = false;
            this.real._TextChanged += new System.EventHandler(this.real__TextChanged);
            // 
            // materialName
            // 
            this.materialName.BackColor = System.Drawing.SystemColors.Window;
            this.materialName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.materialName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.materialName.BorderRadius = 0;
            this.materialName.BorderSize = 2;
            this.materialName.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialName.Location = new System.Drawing.Point(871, 484);
            this.materialName.Margin = new System.Windows.Forms.Padding(4);
            this.materialName.Multiline = false;
            this.materialName.Name = "materialName";
            this.materialName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.materialName.PasswordChar = false;
            this.materialName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.materialName.PlaceholderText = "";
            this.materialName.ReadOnly = false;
            this.materialName.Size = new System.Drawing.Size(178, 30);
            this.materialName.TabIndex = 12;
            this.materialName.UnderlinedStyle = false;
            // 
            // materialId
            // 
            this.materialId.BackColor = System.Drawing.SystemColors.Window;
            this.materialId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.materialId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.materialId.BorderRadius = 0;
            this.materialId.BorderSize = 2;
            this.materialId.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialId.Location = new System.Drawing.Point(871, 526);
            this.materialId.Margin = new System.Windows.Forms.Padding(4);
            this.materialId.Multiline = false;
            this.materialId.Name = "materialId";
            this.materialId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.materialId.PasswordChar = false;
            this.materialId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.materialId.PlaceholderText = "";
            this.materialId.ReadOnly = false;
            this.materialId.Size = new System.Drawing.Size(177, 30);
            this.materialId.TabIndex = 15;
            this.materialId.UnderlinedStyle = false;
            // 
            // expect
            // 
            this.expect.BackColor = System.Drawing.SystemColors.Window;
            this.expect.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.expect.BorderFocusColor = System.Drawing.Color.HotPink;
            this.expect.BorderRadius = 0;
            this.expect.BorderSize = 2;
            this.expect.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.expect.Location = new System.Drawing.Point(872, 564);
            this.expect.Margin = new System.Windows.Forms.Padding(4);
            this.expect.Multiline = false;
            this.expect.Name = "expect";
            this.expect.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.expect.PasswordChar = false;
            this.expect.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.expect.PlaceholderText = "";
            this.expect.ReadOnly = false;
            this.expect.Size = new System.Drawing.Size(177, 30);
            this.expect.TabIndex = 15;
            this.expect.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(727, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Số Lượng Hệ Thống:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 655);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Chênh Lệch:";
            // 
            // diff
            // 
            this.diff.AutoSize = true;
            this.diff.Location = new System.Drawing.Point(872, 655);
            this.diff.Name = "diff";
            this.diff.Size = new System.Drawing.Size(0, 16);
            this.diff.TabIndex = 22;
            // 
            // fInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1081, 853);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.real);
            this.Controls.Add(this.materialName);
            this.Controls.Add(this.expect);
            this.Controls.Add(this.materialId);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.siiButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fInventory";
            this.Load += new System.EventHandler(this.fInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private SiiControls.SiiButton siiButton1;
        private SiiControls.SiiButton btnConfirm;
        private TabControl tabControl1;
        private DataGridView dataGridView2;
        private SiiControls.SiiButton btn_Add;
        private Label label5;
        private Label label4;
        private Label label7;
        private SiiControls.SiiTextBox real;
        private SiiControls.SiiTextBox materialName;
        private SiiControls.SiiTextBox materialId;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private SiiControls.SiiTextBox expect;
        private Label label2;
        private Label label3;
        private Label diff;
    }
}