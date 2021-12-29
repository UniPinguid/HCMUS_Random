using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RandomApp
{
    public partial class SignUp : Form
    {
        public static int check = -1;

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
        public SignUp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickBack(object sender, EventArgs e)
        {
            StartUp start = new StartUp();
            start.Show();
            this.Close();
        }


        private void clickContinue(object sender, EventArgs e)
        {
            // If select Partner
            if (checkPartner.Checked)
            {
                check = 0;
                SignUpPartner1 signUpPartner = new SignUpPartner1();
                signUpPartner.Show();
                this.Close();
            }

            // If select Customer
            else if (checkCustomer.Checked)
            {
                check = 1;
                SignUpCustomer signUpCustomer = new SignUpCustomer();
                signUpCustomer.Show();
                this.Close();
            }

            // If select Shipper
            else if (checkShipper.Checked)
            {
                check = 2;
                SignUpShipper signUpShipper = new SignUpShipper();
                signUpShipper.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Xin vui lòng chọn tư cách đăng ký.", "Thông báo");
            }
        }
    }
}
