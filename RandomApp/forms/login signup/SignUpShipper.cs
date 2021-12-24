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
    public partial class SignUpShipper : Form
    {
        public static string name = "";
        public static string citizenID = "";
        public static string contactNumber = "";
        public static string location = "";
        public static string numberPlate = "";
        public static string area = "";
        public static string email = "";
        public static string bankAccount = "";

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
        public SignUpShipper()
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

        private void clickSubmit(object sender, EventArgs e)
        {
            name = nameInput.Text;
            citizenID = citizenIDInput.Text;
            contactNumber = contactNumberInput.Text;
            location = locationInput.Text;
            numberPlate = numberPlateInput.Text;
            area = areaInput.Text;
            email = emailInput.Text;
            bankAccount = bankAccountInput.Text;

            SignUpFinal final = new SignUpFinal();
            final.Show();
            this.Close();
        }
    }
}
