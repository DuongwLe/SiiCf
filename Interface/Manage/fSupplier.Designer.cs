namespace Interface.Manage
{
    partial class fSupplier
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
            this.dtgvNCC = new System.Windows.Forms.DataGridView();
            this.siiButton3 = new Interface.SiiControls.SiiButton();
            this.siiButton2 = new Interface.SiiControls.SiiButton();
            this.siiButton1 = new Interface.SiiControls.SiiButton();
            this.name = new Interface.SiiControls.SiiTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.address = new Interface.SiiControls.SiiTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNumber = new Interface.SiiControls.SiiTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvNCC
            // 
            this.dtgvNCC.AllowUserToAddRows = false;
            this.dtgvNCC.AllowUserToDeleteRows = false;
            this.dtgvNCC.AllowUserToResizeColumns = false;
            this.dtgvNCC.AllowUserToResizeRows = false;
            this.dtgvNCC.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNCC.Location = new System.Drawing.Point(199, 362);
            this.dtgvNCC.Name = "dtgvNCC";
            this.dtgvNCC.ReadOnly = true;
            this.dtgvNCC.RowHeadersVisible = false;
            this.dtgvNCC.RowHeadersWidth = 51;
            this.dtgvNCC.RowTemplate.Height = 29;
            this.dtgvNCC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvNCC.Size = new System.Drawing.Size(752, 361);
            this.dtgvNCC.TabIndex = 33;
            this.dtgvNCC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNCC_CellContentClick);
            this.dtgvNCC.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvNCC_CellContentDoubleClick);
            // 
            // siiButton3
            // 
            this.siiButton3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.siiButton3.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.siiButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton3.BorderRadius = 36;
            this.siiButton3.BorderSize = 0;
            this.siiButton3.FlatAppearance.BorderSize = 0;
            this.siiButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siiButton3.ForeColor = System.Drawing.Color.Black;
            this.siiButton3.Location = new System.Drawing.Point(699, 798);
            this.siiButton3.Name = "siiButton3";
            this.siiButton3.Size = new System.Drawing.Size(156, 42);
            this.siiButton3.TabIndex = 32;
            this.siiButton3.Text = "Xóa";
            this.siiButton3.TextColor = System.Drawing.Color.Black;
            this.siiButton3.UseVisualStyleBackColor = false;
            this.siiButton3.Click += new System.EventHandler(this.siiButton3_Click);
            // 
            // siiButton2
            // 
            this.siiButton2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.siiButton2.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.siiButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton2.BorderRadius = 36;
            this.siiButton2.BorderSize = 0;
            this.siiButton2.FlatAppearance.BorderSize = 0;
            this.siiButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siiButton2.ForeColor = System.Drawing.Color.Black;
            this.siiButton2.Location = new System.Drawing.Point(489, 798);
            this.siiButton2.Name = "siiButton2";
            this.siiButton2.Size = new System.Drawing.Size(156, 42);
            this.siiButton2.TabIndex = 31;
            this.siiButton2.Text = "Sửa";
            this.siiButton2.TextColor = System.Drawing.Color.Black;
            this.siiButton2.UseVisualStyleBackColor = false;
            this.siiButton2.Click += new System.EventHandler(this.siiButton2_Click);
            // 
            // siiButton1
            // 
            this.siiButton1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.siiButton1.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.siiButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton1.BorderRadius = 36;
            this.siiButton1.BorderSize = 0;
            this.siiButton1.FlatAppearance.BorderSize = 0;
            this.siiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siiButton1.ForeColor = System.Drawing.Color.Black;
            this.siiButton1.Location = new System.Drawing.Point(279, 798);
            this.siiButton1.Name = "siiButton1";
            this.siiButton1.Size = new System.Drawing.Size(156, 42);
            this.siiButton1.TabIndex = 30;
            this.siiButton1.Text = "Thêm";
            this.siiButton1.TextColor = System.Drawing.Color.Black;
            this.siiButton1.UseVisualStyleBackColor = false;
            this.siiButton1.Click += new System.EventHandler(this.siiButton1_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.Window;
            this.name.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.name.BorderFocusColor = System.Drawing.Color.HotPink;
            this.name.BorderRadius = 0;
            this.name.BorderSize = 2;
            this.name.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(338, 124);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Multiline = false;
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.name.PasswordChar = false;
            this.name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.name.PlaceholderText = "";
            this.name.ReadOnly = false;
            this.name.Size = new System.Drawing.Size(517, 30);
            this.name.TabIndex = 29;
            this.name.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(220, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên NCC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(401, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 50);
            this.label1.TabIndex = 25;
            this.label1.Text = "Nhà cung cấp";
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.SystemColors.Window;
            this.address.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.address.BorderFocusColor = System.Drawing.Color.HotPink;
            this.address.BorderRadius = 0;
            this.address.BorderSize = 2;
            this.address.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address.Location = new System.Drawing.Point(338, 196);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Multiline = false;
            this.address.Name = "address";
            this.address.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.address.PasswordChar = false;
            this.address.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.address.PlaceholderText = "";
            this.address.ReadOnly = false;
            this.address.Size = new System.Drawing.Size(517, 30);
            this.address.TabIndex = 35;
            this.address.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(239, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 34;
            this.label4.Text = "Địa chỉ:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.phoneNumber.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.phoneNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.phoneNumber.BorderRadius = 0;
            this.phoneNumber.BorderSize = 2;
            this.phoneNumber.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.Location = new System.Drawing.Point(338, 277);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumber.Multiline = false;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.phoneNumber.PasswordChar = false;
            this.phoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.phoneNumber.PlaceholderText = "";
            this.phoneNumber.ReadOnly = false;
            this.phoneNumber.Size = new System.Drawing.Size(517, 30);
            this.phoneNumber.TabIndex = 37;
            this.phoneNumber.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(263, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "SĐT:";
            // 
            // fSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1141, 910);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgvNCC);
            this.Controls.Add(this.siiButton3);
            this.Controls.Add(this.siiButton2);
            this.Controls.Add(this.siiButton1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fSupplier";
            this.Text = "fSupplier";
            this.Load += new System.EventHandler(this.fSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgvNCC;
        private SiiControls.SiiButton siiButton3;
        private SiiControls.SiiButton siiButton2;
        private SiiControls.SiiButton siiButton1;
        private SiiControls.SiiTextBox name;
        private Label label3;
        private Label label1;
        private SiiControls.SiiTextBox address;
        private Label label4;
        private SiiControls.SiiTextBox phoneNumber;
        private Label label2;
    }
}