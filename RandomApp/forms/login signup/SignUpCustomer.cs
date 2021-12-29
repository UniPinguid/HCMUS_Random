using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace RandomApp
{
    public partial class SignUpCustomer : Form
    {
        public static string name = "";
        public static string contactNumber = "";
        public static string email = "";
        public static string location = "";

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
        public SignUpCustomer()
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
            contactNumber = contactNumberInput.Text;
            email = emailInput.Text;
            location = locationInput.Text;

            SignUpFinal final = new SignUpFinal();
            final.Show();
            this.Close();
        }

        private void SignUpCustomer_Load(object sender, EventArgs e)
        {
            nameInput.Text = name;
            contactNumberInput.Text = contactNumber;
            emailInput.Text = email;
            locationInput.Text = location;
        }

        public List<string> GetData()
        {
            List<string> list = new List<string>();
            list.Add(nameInput.Text);
            list.Add(contactNumberInput.Text);
            list.Add(emailInput.Text);
            list.Add(locationInput.Text);
            return list;
        }
    }
}
