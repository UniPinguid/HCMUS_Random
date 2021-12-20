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
    public partial class SignUpFinal : Form
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
        public SignUpFinal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickSubmit(object sender, EventArgs e)
        {
            SignUpSuccess success = new SignUpSuccess();
            success.Show();
            this.Close();
        }

        private void clickBack(object sender, EventArgs e)
        {
            // If selected Partner
            SignUpPartner2 partner = new SignUpPartner2();
            partner.Show();

            //// If selected Customer
            //SignUpCustomer customer = new SignUpCustomer();
            //customer.Show();

            //// If selected Shipper
            //SignUpShipper shipper = new SignUpShipper();
            //shipper.Show();

            this.Close();
        }
    }
}
