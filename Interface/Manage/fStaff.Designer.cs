namespace Interface.Manage
{
    partial class fStaff
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
            this.name = new Interface.SiiControls.SiiTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvStaff = new System.Windows.Forms.DataGridView();
            this.siiButton3 = new Interface.SiiControls.SiiButton();
            this.siiButton2 = new Interface.SiiControls.SiiButton();
            this.siiButton1 = new Interface.SiiControls.SiiButton();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneNumber = new Interface.SiiControls.SiiTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.birthday = new Interface.SiiControls.SiiTextBox();
            this.male = new Interface.SiiControls.SiiRadioButton();
            this.female = new Interface.SiiControls.SiiRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.Window;
            this.name.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.name.BorderFocusColor = System.Drawing.Color.HotPink;
            this.name.BorderRadius = 0;
            this.name.BorderSize = 2;
            this.name.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(172, 106);
            this.name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.name.Multiline = false;
            this.name.Name = "name";
            this.name.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.name.PasswordChar = false;
            this.name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.name.PlaceholderText = "";
            this.name.ReadOnly = false;
            this.name.Size = new System.Drawing.Size(367, 26);
            this.name.TabIndex = 19;
            this.name.UnderlinedStyle = false;
            this.name._TextChanged += new System.EventHandler(this.siiTextBox2__TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(72, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(145, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 50);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh mục nhân viên";
            // 
            // dtgvStaff
            // 
            this.dtgvStaff.AllowUserToAddRows = false;
            this.dtgvStaff.AllowUserToDeleteRows = false;
            this.dtgvStaff.AllowUserToResizeColumns = false;
            this.dtgvStaff.AllowUserToResizeRows = false;
            this.dtgvStaff.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dtgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStaff.Location = new System.Drawing.Point(46, 291);
            this.dtgvStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvStaff.Name = "dtgvStaff";
            this.dtgvStaff.ReadOnly = true;
            this.dtgvStaff.RowHeadersVisible = false;
            this.dtgvStaff.RowHeadersWidth = 51;
            this.dtgvStaff.RowTemplate.Height = 29;
            this.dtgvStaff.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvStaff.Size = new System.Drawing.Size(606, 216);
            this.dtgvStaff.TabIndex = 28;
            this.dtgvStaff.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvStaff_CellContentDoubleClick);
            // 
            // siiButton3
            // 
            this.siiButton3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.siiButton3.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.siiButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.siiButton3.BorderRadius = 32;
            this.siiButton3.BorderSize = 0;
            this.siiButton3.FlatAppearance.BorderSize = 0;
            this.siiButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siiButton3.ForeColor = System.Drawing.Color.Black;
            this.siiButton3.Location = new System.Drawing.Point(467, 529);
            this.siiButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siiButton3.Name = "siiButton3";
            this.siiButton3.Size = new System.Drawing.Size(136, 32);
            this.siiButton3.TabIndex = 31;
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
            this.siiButton2.BorderRadius = 32;
            this.siiButton2.BorderSize = 0;
            this.siiButton2.FlatAppearance.BorderSize = 0;
            this.siiButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siiButton2.ForeColor = System.Drawing.Color.Black;
            this.siiButton2.Location = new System.Drawing.Point(284, 529);
            this.siiButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siiButton2.Name = "siiButton2";
            this.siiButton2.Size = new System.Drawing.Size(136, 32);
            this.siiButton2.TabIndex = 30;
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
            this.siiButton1.BorderRadius = 32;
            this.siiButton1.BorderSize = 0;
            this.siiButton1.FlatAppearance.BorderSize = 0;
            this.siiButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.siiButton1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siiButton1.ForeColor = System.Drawing.Color.Black;
            this.siiButton1.Location = new System.Drawing.Point(100, 529);
            this.siiButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siiButton1.Name = "siiButton1";
            this.siiButton1.Size = new System.Drawing.Size(136, 32);
            this.siiButton1.TabIndex = 29;
            this.siiButton1.Text = "Thêm";
            this.siiButton1.TextColor = System.Drawing.Color.Black;
            this.siiButton1.UseVisualStyleBackColor = false;
            this.siiButton1.Click += new System.EventHandler(this.siiButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(112, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "SĐT:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.phoneNumber.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.phoneNumber.BorderFocusColor = System.Drawing.Color.HotPink;
            this.phoneNumber.BorderRadius = 0;
            this.phoneNumber.BorderSize = 2;
            this.phoneNumber.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber.Location = new System.Drawing.Point(172, 244);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phoneNumber.Multiline = false;
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.phoneNumber.PasswordChar = false;
            this.phoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.phoneNumber.PlaceholderText = "";
            this.phoneNumber.ReadOnly = false;
            this.phoneNumber.Size = new System.Drawing.Size(367, 26);
            this.phoneNumber.TabIndex = 25;
            this.phoneNumber.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Giới tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(68, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ngày sinh:";
            // 
            // birthday
            // 
            this.birthday.BackColor = System.Drawing.SystemColors.Window;
            this.birthday.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.birthday.BorderFocusColor = System.Drawing.Color.HotPink;
            this.birthday.BorderRadius = 0;
            this.birthday.BorderSize = 2;
            this.birthday.Font = new System.Drawing.Font("Times New Roman", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.birthday.Location = new System.Drawing.Point(172, 196);
            this.birthday.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.birthday.Multiline = false;
            this.birthday.Name = "birthday";
            this.birthday.Padding = new System.Windows.Forms.Padding(9, 5, 9, 5);
            this.birthday.PasswordChar = false;
            this.birthday.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.birthday.PlaceholderText = "";
            this.birthday.ReadOnly = false;
            this.birthday.Size = new System.Drawing.Size(367, 26);
            this.birthday.TabIndex = 23;
            this.birthday.UnderlinedStyle = false;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Checked = true;
            this.male.CheckedColor = System.Drawing.Color.ForestGreen;
            this.male.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.male.Location = new System.Drawing.Point(172, 154);
            this.male.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.male.MinimumSize = new System.Drawing.Size(0, 16);
            this.male.Name = "male";
            this.male.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.male.Size = new System.Drawing.Size(66, 23);
            this.male.TabIndex = 26;
            this.male.TabStop = true;
            this.male.Text = "Nam";
            this.male.UnCheckedColor = System.Drawing.Color.Gray;
            this.male.UseVisualStyleBackColor = true;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.CheckedColor = System.Drawing.Color.MediumSlateBlue;
            this.female.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.female.Location = new System.Drawing.Point(338, 154);
            this.female.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.female.MinimumSize = new System.Drawing.Size(0, 16);
            this.female.Name = "female";
            this.female.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.female.Size = new System.Drawing.Size(57, 23);
            this.female.TabIndex = 27;
            this.female.Text = "Nữ";
            this.female.UnCheckedColor = System.Drawing.Color.DodgerBlue;
            this.female.UseVisualStyleBackColor = true;
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(700, 587);
            this.Controls.Add(this.siiButton3);
            this.Controls.Add(this.siiButton2);
            this.Controls.Add(this.siiButton1);
            this.Controls.Add(this.dtgvStaff);
            this.Controls.Add(this.female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fStaff";
            this.Load += new System.EventHandler(this.fStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiiControls.SiiTextBox name;
        private Label label3;
        private Label label1;
        private DataGridView dtgvStaff;
        private SiiControls.SiiButton siiButton3;
        private SiiControls.SiiButton siiButton2;
        private SiiControls.SiiButton siiButton1;
        private Label label5;
        private SiiControls.SiiTextBox phoneNumber;
        private Label label2;
        private Label label4;
        private SiiControls.SiiTextBox birthday;
        private SiiControls.SiiRadioButton male;
        private SiiControls.SiiRadioButton female;
    }
}