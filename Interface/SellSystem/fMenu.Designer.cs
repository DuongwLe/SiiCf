namespace Interface.SellSystem
{
    partial class fMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgvLoaiDoUong = new System.Windows.Forms.DataGridView();
            this.dtgvDSDoUong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiDoUong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDoUong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(473, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(84, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Loại đồ uống";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(651, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Danh sách đồ uống";
            // 
            // dtgvLoaiDoUong
            // 
            this.dtgvLoaiDoUong.AllowUserToAddRows = false;
            this.dtgvLoaiDoUong.AllowUserToDeleteRows = false;
            this.dtgvLoaiDoUong.AllowUserToResizeColumns = false;
            this.dtgvLoaiDoUong.AllowUserToResizeRows = false;
            this.dtgvLoaiDoUong.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvLoaiDoUong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvLoaiDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvLoaiDoUong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvLoaiDoUong.Location = new System.Drawing.Point(24, 144);
            this.dtgvLoaiDoUong.Name = "dtgvLoaiDoUong";
            this.dtgvLoaiDoUong.ReadOnly = true;
            this.dtgvLoaiDoUong.RowHeadersVisible = false;
            this.dtgvLoaiDoUong.RowHeadersWidth = 51;
            this.dtgvLoaiDoUong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvLoaiDoUong.RowTemplate.Height = 29;
            this.dtgvLoaiDoUong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvLoaiDoUong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvLoaiDoUong.Size = new System.Drawing.Size(290, 649);
            this.dtgvLoaiDoUong.TabIndex = 12;
            this.dtgvLoaiDoUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvLoaiDoUong_CellClick);
            // 
            // dtgvDSDoUong
            // 
            this.dtgvDSDoUong.AllowUserToAddRows = false;
            this.dtgvDSDoUong.AllowUserToDeleteRows = false;
            this.dtgvDSDoUong.AllowUserToResizeColumns = false;
            this.dtgvDSDoUong.AllowUserToResizeRows = false;
            this.dtgvDSDoUong.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSpringGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDSDoUong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDSDoUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDSDoUong.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvDSDoUong.Location = new System.Drawing.Point(329, 144);
            this.dtgvDSDoUong.Name = "dtgvDSDoUong";
            this.dtgvDSDoUong.ReadOnly = true;
            this.dtgvDSDoUong.RowHeadersVisible = false;
            this.dtgvDSDoUong.RowHeadersWidth = 51;
            this.dtgvDSDoUong.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvDSDoUong.RowTemplate.Height = 29;
            this.dtgvDSDoUong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvDSDoUong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSDoUong.Size = new System.Drawing.Size(790, 649);
            this.dtgvDSDoUong.TabIndex = 13;
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(221)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(1141, 853);
            this.Controls.Add(this.dtgvDSDoUong);
            this.Controls.Add(this.dtgvLoaiDoUong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMenu";
            this.Load += new System.EventHandler(this.fMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLoaiDoUong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDoUong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private DataGridView dtgvLoaiDoUong;
        private DataGridView dtgvDSDoUong;
    }
}