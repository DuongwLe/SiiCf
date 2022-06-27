using Interface.Constants;

namespace Interface
{
    public partial class Form1 : Form
    {
        List<GioHang> GioHang = new();

        public Form1()
        {
            InitializeComponent();
            customizeDesing();

        }
        private void customizeDesing()
        {
            panelBanHangSubmenu.Visible = false;
            panelQuanLySubmenu.Visible = false;
            panelKhoSubmenu.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if(panelBanHangSubmenu.Visible == true)
                panelBanHangSubmenu.Visible = false; 
            if(panelQuanLySubmenu.Visible == true)
                panelQuanLySubmenu.Visible = false;
            if(panelKhoSubmenu.Visible == true)
                panelKhoSubmenu.Visible = false;
        }

        private void showSubMenu(Panel SubMenu)
        {
            if(SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

        private void changeColor()
        {
            if (panelQuanLySubmenu.Visible == true)
                btnQuanLy.BackColor = Color.White;
            if (panelQuanLySubmenu.Visible == false)
                btnQuanLy.BackColor = Color.FromArgb(176, 66, 32);
            if (panelBanHangSubmenu.Visible == true)
                btnBanHang.BackColor = Color.White;
            if (panelBanHangSubmenu.Visible == false)
                btnBanHang.BackColor = Color.FromArgb(176, 66, 32);
            if (panelKhoSubmenu.Visible == true)
                btnKho.BackColor = Color.White;
            if (panelKhoSubmenu.Visible == false)
                btnKho.BackColor = Color.FromArgb(176, 66, 32);
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBanHangSubmenu);
            changeColor();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            showSubMenu(panelKhoSubmenu);
            changeColor();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            showSubMenu(panelQuanLySubmenu);
            changeColor();
        }


        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) // Nếu như có form đang mở thì đóng lại
                activeForm.Close(); 
            activeForm = childForm; // Mở 1 form khác lên
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; // bỏ viền của form
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            openChildForm(new SellSystem.fOrder(GioHang));
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new SellSystem.fReportSell());
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            openChildForm(new Storehouse.Nhap.Listing());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            openChildForm(new Storehouse.Xuat.Listing());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            openChildForm(new Storehouse.KiemKe.Listing());
        }

        private void btnResources_Click(object sender, EventArgs e)
        {
            openChildForm(new Storehouse.fResources());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void btnChiTietCa_Click(object sender, EventArgs e)
        {
            openChildForm(new SellSystem.fShiftDetails());

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage.fListProducts());
            //Manage.fProducts pd = new Manage.fProducts();
            //pd.StartPosition = FormStartPosition.CenterScreen;
            //pd.ShowDialog();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            openChildForm(new SellSystem.fDiscount());;
        }

        private void btnPaymentMethods_Click(object sender, EventArgs e)
        {
            openChildForm(new SellSystem.fPaymentMethods()); ;
        }

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage.fListMaterial()); ;
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new Manage.fSupplier());

        }

        private void btnManageAccount_Click_1(object sender, EventArgs e)
        {
            openChildForm(new Manage.fAccount()); ;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}