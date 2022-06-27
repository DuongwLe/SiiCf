namespace Interface.Storehouse
{
    partial class fEnter
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.materialId = new Interface.SiiControls.SiiTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Add = new Interface.SiiControls.SiiButton();
            this.quanlity = new Interface.SiiControls.SiiTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_Confirm = new Interface.SiiControls.SiiButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.materialName = new Interface.SiiControls.SiiTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new Interface.SiiControls.SiiTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuanlity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Nhà Cung Cấp";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(308, 86);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(77, 16);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Ngày Tháng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colName,
            this.Column1,
            this.colMaterialCode,
            this.colQuanlity,
            this.colPrice,
            this.colTotalAmount});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(777, 457);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(804, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số Lượng :";
            // 
            // materialId
            // 
            this.materialId.BackColor = System.Drawing.SystemColors.Window;
            this.materialId.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.materialId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.materialId.BorderRadius = 0;
            this.materialId.BorderSize = 2;
            this.materialId.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialId.Location = new System.Drawing.Point(948, 473);
            this.materialId.Margin = new System.Windows.Forms.Padding(4);
            this.materialId.Multiline = false;
            this.materialId.Name = "materialId";
            this.materialId.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.materialId.PasswordChar = false;
            this.materialId.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.materialId.PlaceholderText = "";
            this.materialId.ReadOnly = false;
            this.materialId.Size = new System.Drawing.Size(177, 30);
            this.materialId.TabIndex = 2;
            this.materialId.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 670);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tổng Tiền :";
            this.label8.Click += new System.EventHandler(this.label2_Click);
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
            this.btn_Add.Location = new System.Drawing.Point(911, 666);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(111, 43);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextColor = System.Drawing.Color.White;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // quanlity
            // 
            this.quanlity.BackColor = System.Drawing.SystemColors.Window;
            this.quanlity.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.quanlity.BorderFocusColor = System.Drawing.Color.HotPink;
            this.quanlity.BorderRadius = 0;
            this.quanlity.BorderSize = 2;
            this.quanlity.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.quanlity.Location = new System.Drawing.Point(948, 515);
            this.quanlity.Margin = new System.Windows.Forms.Padding(4);
            this.quanlity.Multiline = false;
            this.quanlity.Name = "quanlity";
            this.quanlity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.quanlity.PasswordChar = false;
            this.quanlity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.quanlity.PlaceholderText = "";
            this.quanlity.ReadOnly = false;
            this.quanlity.Size = new System.Drawing.Size(177, 30);
            this.quanlity.TabIndex = 2;
            this.quanlity.UnderlinedStyle = false;
            this.quanlity._TextChanged += new System.EventHandler(this.quanlity__TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(804, 558);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Đơn Giá :";
            this.label10.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Confirm.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Confirm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Confirm.BorderRadius = 18;
            this.btn_Confirm.BorderSize = 0;
            this.btn_Confirm.FlatAppearance.BorderSize = 0;
            this.btn_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirm.ForeColor = System.Drawing.Color.White;
            this.btn_Confirm.Location = new System.Drawing.Point(536, 721);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(111, 43);
            this.btn_Confirm.TabIndex = 7;
            this.btn_Confirm.Text = "Xác Nhận";
            this.btn_Confirm.TextColor = System.Drawing.Color.White;
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(795, 174);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(331, 250);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(804, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Nguyên liệu:";
            // 
            // materialName
            // 
            this.materialName.BackColor = System.Drawing.SystemColors.Window;
            this.materialName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.materialName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.materialName.BorderRadius = 0;
            this.materialName.BorderSize = 2;
            this.materialName.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialName.Location = new System.Drawing.Point(948, 431);
            this.materialName.Margin = new System.Windows.Forms.Padding(4);
            this.materialName.Multiline = false;
            this.materialName.Name = "materialName";
            this.materialName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.materialName.PasswordChar = false;
            this.materialName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.materialName.PlaceholderText = "";
            this.materialName.ReadOnly = false;
            this.materialName.Size = new System.Drawing.Size(178, 30);
            this.materialName.TabIndex = 2;
            this.materialName.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(804, 608);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thành Tiền :";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.SystemColors.Window;
            this.price.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.price.BorderFocusColor = System.Drawing.Color.HotPink;
            this.price.BorderRadius = 0;
            this.price.BorderSize = 2;
            this.price.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.price.Location = new System.Drawing.Point(948, 558);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Multiline = false;
            this.price.Name = "price";
            this.price.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.price.PasswordChar = false;
            this.price.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.price.PlaceholderText = "";
            this.price.ReadOnly = false;
            this.price.Size = new System.Drawing.Size(178, 30);
            this.price.TabIndex = 2;
            this.price.UnderlinedStyle = false;
            this.price._TextChanged += new System.EventHandler(this.price__TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(804, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mã Nguyên liệu:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(448, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(795, 152);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 28);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(911, 608);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thành Tiền :";
            this.label6.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ngày Tháng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(236, 670);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Tổng Tiền :";
            this.label11.Click += new System.EventHandler(this.label2_Click);
            // 
            // colNumber
            // 
            this.colNumber.HeaderText = "STT";
            this.colNumber.MinimumWidth = 6;
            this.colNumber.Name = "colNumber";
            this.colNumber.Width = 50;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên Nguyên Liệu";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nhà Cung Cấp";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // colMaterialCode
            // 
            this.colMaterialCode.HeaderText = "Mã Nguyên Liệu";
            this.colMaterialCode.MinimumWidth = 6;
            this.colMaterialCode.Name = "colMaterialCode";
            this.colMaterialCode.Width = 145;
            // 
            // colQuanlity
            // 
            this.colQuanlity.HeaderText = "Số Lượnng";
            this.colQuanlity.MinimumWidth = 6;
            this.colQuanlity.Name = "colQuanlity";
            this.colQuanlity.Width = 125;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Đơn Giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 125;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.HeaderText = "Thành Tiền";
            this.colTotalAmount.MinimumWidth = 6;
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Width = 125;
            // 
            // fEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1172, 800);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.quanlity);
            this.Controls.Add(this.materialName);
            this.Controls.Add(this.materialId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fEnter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fEnter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblDate;
        private DataGridView dataGridView1;
        private Label label7;
        private SiiControls.SiiTextBox materialId;
        private Label label8;
        private SiiControls.SiiButton btn_Add;
        private SiiControls.SiiTextBox quanlity;
        private Label label10;
        private SiiControls.SiiButton btn_Confirm;
        private DataGridView dataGridView2;
        private Label label4;
        private SiiControls.SiiTextBox materialName;
        private Label label3;
        private SiiControls.SiiTextBox price;
        private Label label5;
        private ComboBox comboBox1;
        private TabControl tabControl1;
        private Label label6;
        private Label label9;
        private Label label11;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn colMaterialCode;
        private DataGridViewTextBoxColumn colQuanlity;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colTotalAmount;
    }
}