namespace Interface.SellSystem
{
    partial class fPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXacNhan = new Interface.SiiControls.SiiButton();
            this.siiButton2 = new Interface.SiiControls.SiiButton();
            this.dtgvPTTT = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhaiTra = new Interface.SiiControls.SiiTextBox();
            this.txtDaNhan = new Interface.SiiControls.SiiTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTienThua = new Interface.SiiControls.SiiTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siiButton1 = new Interface.SiiControls.SiiButton();
            this.siiButton3 = new Interface.SiiControls.SiiButton();
            this.siiButton4 = new Interface.SiiControls.SiiButton();
            this.siiButton5 = new Interface.SiiControls.SiiButton();
            this.siiButton7 = new Interface.SiiControls.SiiButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPTTT)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(377, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thanh toán";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXacNhan.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btnXacNhan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnXacNhan.BorderRadius = 34;
            this.btnXacNhan.BorderSize = 0;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Location = new System.Drawing.Point(568, 505);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(138, 44);
            this.btnXacNhan.TabIndex = 14;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextColor = System.Drawing.Color.Black;
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // siiButton2
            // 
            this.siiButton2.BackColor = System.Drawing.Color.Red;
            this.siiButton2.BackgroundColor = System.Drawing.Color.Red;
            this.siiButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton2.BorderRadius = 34;
            this.siiButton2.BorderSize = 0;
            this.siiButton2.FlatAppearance.BorderSize = 0;
            this.siiButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.siiButton2.ForeColor = System.Drawing.Color.Black;
            this.siiButton2.Location = new System.Drawing.Point(350, 505);
            this.siiButton2.Name = "siiButton2";
            this.siiButton2.Size = new System.Drawing.Size(138, 44);
            this.siiButton2.TabIndex = 15;
            this.siiButton2.Text = "Hủy bỏ";
            this.siiButton2.TextColor = System.Drawing.Color.Black;
            this.siiButton2.UseVisualStyleBackColor = false;
            this.siiButton2.Click += new System.EventHandler(this.siiButton2_Click);
            // 
            // dtgvPTTT
            // 
            this.dtgvPTTT.AllowUserToAddRows = false;
            this.dtgvPTTT.AllowUserToDeleteRows = false;
            this.dtgvPTTT.AllowUserToResizeColumns = false;
            this.dtgvPTTT.AllowUserToResizeRows = false;
            this.dtgvPTTT.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPTTT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvPTTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPTTT.Location = new System.Drawing.Point(22, 125);
            this.dtgvPTTT.Name = "dtgvPTTT";
            this.dtgvPTTT.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvPTTT.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvPTTT.RowHeadersVisible = false;
            this.dtgvPTTT.RowHeadersWidth = 51;
            this.dtgvPTTT.RowTemplate.Height = 29;
            this.dtgvPTTT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvPTTT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvPTTT.Size = new System.Drawing.Size(264, 337);
            this.dtgvPTTT.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtPhaiTra);
            this.panel1.Controls.Add(this.txtDaNhan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(296, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 104);
            this.panel1.TabIndex = 17;
            // 
            // txtPhaiTra
            // 
            this.txtPhaiTra.BackColor = System.Drawing.Color.White;
            this.txtPhaiTra.BorderColor = System.Drawing.Color.Black;
            this.txtPhaiTra.BorderFocusColor = System.Drawing.Color.Black;
            this.txtPhaiTra.BorderRadius = 0;
            this.txtPhaiTra.BorderSize = 2;
            this.txtPhaiTra.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhaiTra.Location = new System.Drawing.Point(271, 43);
            this.txtPhaiTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhaiTra.Multiline = false;
            this.txtPhaiTra.Name = "txtPhaiTra";
            this.txtPhaiTra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhaiTra.PasswordChar = false;
            this.txtPhaiTra.PlaceholderColor = System.Drawing.Color.Black;
            this.txtPhaiTra.PlaceholderText = "";
            this.txtPhaiTra.ReadOnly = true;
            this.txtPhaiTra.Size = new System.Drawing.Size(205, 41);
            this.txtPhaiTra.TabIndex = 24;
            this.txtPhaiTra.UnderlinedStyle = true;
            // 
            // txtDaNhan
            // 
            this.txtDaNhan.BackColor = System.Drawing.Color.White;
            this.txtDaNhan.BorderColor = System.Drawing.Color.Black;
            this.txtDaNhan.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDaNhan.BorderRadius = 0;
            this.txtDaNhan.BorderSize = 2;
            this.txtDaNhan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDaNhan.Location = new System.Drawing.Point(13, 43);
            this.txtDaNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDaNhan.Multiline = false;
            this.txtDaNhan.Name = "txtDaNhan";
            this.txtDaNhan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDaNhan.PasswordChar = false;
            this.txtDaNhan.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtDaNhan.PlaceholderText = "";
            this.txtDaNhan.ReadOnly = false;
            this.txtDaNhan.Size = new System.Drawing.Size(156, 41);
            this.txtDaNhan.TabIndex = 23;
            this.txtDaNhan.UnderlinedStyle = true;
            this.txtDaNhan._TextChanged += new System.EventHandler(this.txtDaNhan__TextChanged);
            this.txtDaNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDaNhan_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(266, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 26);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tổng tiền thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(33, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 26);
            this.label3.TabIndex = 21;
            this.label3.Text = "Đã nhận";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtTienThua);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(812, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(206, 104);
            this.panel3.TabIndex = 19;
            // 
            // txtTienThua
            // 
            this.txtTienThua.BackColor = System.Drawing.Color.White;
            this.txtTienThua.BorderColor = System.Drawing.Color.Black;
            this.txtTienThua.BorderFocusColor = System.Drawing.Color.Black;
            this.txtTienThua.BorderRadius = 0;
            this.txtTienThua.BorderSize = 2;
            this.txtTienThua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTienThua.Location = new System.Drawing.Point(13, 43);
            this.txtTienThua.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienThua.Multiline = false;
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTienThua.PasswordChar = false;
            this.txtTienThua.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtTienThua.PlaceholderText = "";
            this.txtTienThua.ReadOnly = true;
            this.txtTienThua.Size = new System.Drawing.Size(163, 41);
            this.txtTienThua.TabIndex = 26;
            this.txtTienThua.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tiền thừa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Phương thức thanh toán";
            // 
            // siiButton1
            // 
            this.siiButton1.BackColor = System.Drawing.Color.DarkOrange;
            this.siiButton1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.siiButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton1.BorderRadius = 38;
            this.siiButton1.BorderSize = 0;
            this.siiButton1.FlatAppearance.BorderSize = 0;
            this.siiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siiButton1.ForeColor = System.Drawing.Color.Black;
            this.siiButton1.Location = new System.Drawing.Point(456, 250);
            this.siiButton1.Name = "siiButton1";
            this.siiButton1.Size = new System.Drawing.Size(101, 38);
            this.siiButton1.TabIndex = 21;
            this.siiButton1.Text = "50K";
            this.siiButton1.TextColor = System.Drawing.Color.Black;
            this.siiButton1.UseVisualStyleBackColor = false;
            // 
            // siiButton3
            // 
            this.siiButton3.BackColor = System.Drawing.Color.DarkOrange;
            this.siiButton3.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.siiButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton3.BorderRadius = 38;
            this.siiButton3.BorderSize = 0;
            this.siiButton3.FlatAppearance.BorderSize = 0;
            this.siiButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siiButton3.ForeColor = System.Drawing.Color.Black;
            this.siiButton3.Location = new System.Drawing.Point(595, 250);
            this.siiButton3.Name = "siiButton3";
            this.siiButton3.Size = new System.Drawing.Size(101, 38);
            this.siiButton3.TabIndex = 22;
            this.siiButton3.Text = "100K";
            this.siiButton3.TextColor = System.Drawing.Color.Black;
            this.siiButton3.UseVisualStyleBackColor = false;
            // 
            // siiButton4
            // 
            this.siiButton4.BackColor = System.Drawing.Color.DarkOrange;
            this.siiButton4.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.siiButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton4.BorderRadius = 38;
            this.siiButton4.BorderSize = 0;
            this.siiButton4.FlatAppearance.BorderSize = 0;
            this.siiButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siiButton4.ForeColor = System.Drawing.Color.Black;
            this.siiButton4.Location = new System.Drawing.Point(737, 250);
            this.siiButton4.Name = "siiButton4";
            this.siiButton4.Size = new System.Drawing.Size(101, 38);
            this.siiButton4.TabIndex = 23;
            this.siiButton4.Text = "200K";
            this.siiButton4.TextColor = System.Drawing.Color.Black;
            this.siiButton4.UseVisualStyleBackColor = false;
            // 
            // siiButton5
            // 
            this.siiButton5.BackColor = System.Drawing.Color.DarkOrange;
            this.siiButton5.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.siiButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton5.BorderRadius = 38;
            this.siiButton5.BorderSize = 0;
            this.siiButton5.FlatAppearance.BorderSize = 0;
            this.siiButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siiButton5.ForeColor = System.Drawing.Color.Black;
            this.siiButton5.Location = new System.Drawing.Point(873, 250);
            this.siiButton5.Name = "siiButton5";
            this.siiButton5.Size = new System.Drawing.Size(101, 38);
            this.siiButton5.TabIndex = 24;
            this.siiButton5.Text = "500K";
            this.siiButton5.TextColor = System.Drawing.Color.Black;
            this.siiButton5.UseVisualStyleBackColor = false;
            // 
            // siiButton7
            // 
            this.siiButton7.BackColor = System.Drawing.Color.DarkOrange;
            this.siiButton7.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.siiButton7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton7.BorderRadius = 38;
            this.siiButton7.BorderSize = 0;
            this.siiButton7.FlatAppearance.BorderSize = 0;
            this.siiButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siiButton7.ForeColor = System.Drawing.Color.Black;
            this.siiButton7.Location = new System.Drawing.Point(320, 250);
            this.siiButton7.Name = "siiButton7";
            this.siiButton7.Size = new System.Drawing.Size(101, 38);
            this.siiButton7.TabIndex = 25;
            this.siiButton7.Text = "20K";
            this.siiButton7.TextColor = System.Drawing.Color.Black;
            this.siiButton7.UseVisualStyleBackColor = false;
            // 
            // fPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1049, 561);
            this.Controls.Add(this.siiButton7);
            this.Controls.Add(this.siiButton5);
            this.Controls.Add(this.siiButton4);
            this.Controls.Add(this.siiButton3);
            this.Controls.Add(this.siiButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvPTTT);
            this.Controls.Add(this.siiButton2);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "fPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPayment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fPayment_FormClosing);
            this.Load += new System.EventHandler(this.fPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPTTT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private SiiControls.SiiButton btnXacNhan;
        private SiiControls.SiiButton siiButton2;
        private DataGridView dtgvPTTT;
        private Panel panel1;
        private Panel panel3;
        private Label label4;
        private Label label3;
        private Label label2;
        private SiiControls.SiiTextBox txtPhaiTra;
        private SiiControls.SiiTextBox txtTienThua;
        private Label label5;
        private SiiControls.SiiButton siiButton1;
        private SiiControls.SiiButton siiButton3;
        private SiiControls.SiiButton siiButton4;
        private SiiControls.SiiButton siiButton5;
        private SiiControls.SiiButton siiButton7;
        private SiiControls.SiiTextBox txtDaNhan;
    }
}