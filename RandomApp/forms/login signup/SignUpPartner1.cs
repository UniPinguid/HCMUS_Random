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
    public partial class SignUpPartner1 : Form
    {
        public static string name = "";
        public static string representative = "";
        public static string contactNumber = "";
        public static string email = "";
        public static string location = "";
        public static string districtStr = "";
        public static string provinceStr = "";

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
        public SignUpPartner1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickBack(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Close();
        }

        private void clickContinue(object sender, EventArgs e)
        {
            if (district.SelectedItem == null)
            {
                MessageBox.Show("Xin vui lòng chọn Quận/Huyện", "Thông báo");
            }
            else if (province.SelectedItem == null)
            {
                MessageBox.Show("Xin vui lòng chọn Tỉnh thành", "Thông báo");
            }
            else
            {
                name = nameInput.Text;
                representative = representativeInput.Text;
                contactNumber = contactNumberInput.Text;
                email = emailInput.Text;
                location = locationInput.Text;
                districtStr = district.SelectedItem.ToString();
                provinceStr = province.SelectedItem.ToString();

                SignUpPartner2 partner2 = new SignUpPartner2();
                partner2.Show();
                this.Close();
            }
        }

        private void SignUpPartner1_Load(object sender, EventArgs e)
        {
            nameInput.Text = name;
            representativeInput.Text = representative;
            contactNumberInput.Text = contactNumber;
            emailInput.Text = email;
            locationInput.Text = location;
            district.SelectedItem = districtStr;
            province.SelectedItem = provinceStr;
        }
    }
}
