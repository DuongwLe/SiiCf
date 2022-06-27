namespace Interface.Storehouse
{
    partial class fResources
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
            this.label2 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.siiButton1 = new Interface.SiiControls.SiiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siiButton2 = new Interface.SiiControls.SiiButton();
            this.siiButton3 = new Interface.SiiControls.SiiButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(336, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Báo cáo nguyên liệu";
            // 
            // fromDate
            // 
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Location = new System.Drawing.Point(257, 92);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(134, 23);
            this.fromDate.TabIndex = 3;
            // 
            // toDate
            // 
            this.toDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.toDate.Location = new System.Drawing.Point(440, 92);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(127, 23);
            this.toDate.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(76, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(953, 555);
            this.dataGridView1.TabIndex = 4;
            // 
            // siiButton1
            // 
            this.siiButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.siiButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.siiButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton1.BorderRadius = 33;
            this.siiButton1.BorderSize = 0;
            this.siiButton1.FlatAppearance.BorderSize = 0;
            this.siiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton1.ForeColor = System.Drawing.Color.White;
            this.siiButton1.Location = new System.Drawing.Point(623, 89);
            this.siiButton1.Name = "siiButton1";
            this.siiButton1.Size = new System.Drawing.Size(126, 33);
            this.siiButton1.TabIndex = 5;
            this.siiButton1.Text = "Tìm Kiếm";
            this.siiButton1.TextColor = System.Drawing.Color.White;
            this.siiButton1.UseVisualStyleBackColor = false;
            this.siiButton1.Click += new System.EventHandler(this.siiButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Từ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đến";
            // 
            // siiButton2
            // 
            this.siiButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.siiButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.siiButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton2.BorderRadius = 38;
            this.siiButton2.BorderSize = 0;
            this.siiButton2.FlatAppearance.BorderSize = 0;
            this.siiButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton2.ForeColor = System.Drawing.Color.White;
            this.siiButton2.Location = new System.Drawing.Point(345, 753);
            this.siiButton2.Name = "siiButton2";
            this.siiButton2.Size = new System.Drawing.Size(160, 38);
            this.siiButton2.TabIndex = 8;
            this.siiButton2.Text = "Xác Nhận";
            this.siiButton2.TextColor = System.Drawing.Color.White;
            this.siiButton2.UseVisualStyleBackColor = false;
            // 
            // siiButton3
            // 
            this.siiButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.siiButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.siiButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton3.BorderRadius = 38;
            this.siiButton3.BorderSize = 0;
            this.siiButton3.FlatAppearance.BorderSize = 0;
            this.siiButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton3.ForeColor = System.Drawing.Color.White;
            this.siiButton3.Location = new System.Drawing.Point(623, 753);
            this.siiButton3.Name = "siiButton3";
            this.siiButton3.Size = new System.Drawing.Size(160, 38);
            this.siiButton3.TabIndex = 8;
            this.siiButton3.Text = "Hủy";
            this.siiButton3.TextColor = System.Drawing.Color.White;
            this.siiButton3.UseVisualStyleBackColor = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên Nguyên Liệu";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã Nguyên Liệu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số Lượng Chênh Lệch";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Số Lượng Hiện Tại";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Trạng Thái";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // fResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1141, 853);
            this.Controls.Add(this.siiButton3);
            this.Controls.Add(this.siiButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siiButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fResources";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fResources";
            this.Load += new System.EventHandler(this.fResources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private DateTimePicker fromDate;
        private DateTimePicker toDate;
        private DataGridView dataGridView1;
        private SiiControls.SiiButton siiButton1;
        private Label label1;
        private Label label3;
        private SiiControls.SiiButton siiButton2;
        private SiiControls.SiiButton siiButton3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
    }
}