using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Random
{
    public partial class AdministratorHomepage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public AdministratorHomepage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clickLogout(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Close();
            }
        }

        private void clickManagement(object sender, EventArgs e)
        {
            AdministratorManagement management = new AdministratorManagement();
            management.Show();
            this.Close();
        }

        private void clickPartner(object sender, EventArgs e)
        {
            AdministratorPartner partner = new AdministratorPartner();
            partner.Show();
            this.Close();
        }

        private void clickCustomer(object sender, EventArgs e)
        {
            AdministratorCustomer customer = new AdministratorCustomer();
            customer.Show();
            this.Close();
        }

        private void clickShipper(object sender, EventArgs e)
        {
            AdministratorShipper shipper = new AdministratorShipper();
            shipper.Show();
            this.Close();
        }

        private void clickEmployee(object sender, EventArgs e)
        {
            AdministratorEmployee employee = new AdministratorEmployee();
            employee.Show();
            this.Close();
        }

        private void clickAdmin(object sender, EventArgs e)
        {
            AdministratorAdmin admin = new AdministratorAdmin();
            admin.Show();
            this.Close();
        }

        private void clickAboutUs(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }
    }
}
