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
    public partial class CustomerHomepage : Form
    {
        public static string IDString = "";

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
        public CustomerHomepage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void CustomerHomepage_Load(object sender, EventArgs e)
        {
            name.Text = Login.name;
            contactNumber.Text = Login.contactNumber;
            IDString = Login.IDString;
            email.Text = Login.email;
            location.Text = Login.location;
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

        private void clickSettings(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này đang được thử nghiệm...", "Tính năng thử nghiệm");
        }

        private void clickMoreIcon(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng này đang được thử nghiệm...", "Tính năng thử nghiệm");
        }

        private void clickCustomer(object sender, EventArgs e)
        {
            CustomerCustomer customer = new CustomerCustomer();
            customer.Show();
            this.Close();
        }

        private void clickOrder(object sender, EventArgs e)
        {
            CustomerOrder order = new CustomerOrder();
            order.Show();
            this.Close();
        }

        private void clickTrackOrder(object sender, EventArgs e)
        {
            CustomerTrackOrder trackOrder = new CustomerTrackOrder();
            trackOrder.Show();
            this.Close();
        }

        private void clickAboutUs(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            aboutUs.ShowDialog();
        }
    }
}
