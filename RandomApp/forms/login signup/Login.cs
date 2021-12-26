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
    public partial class Login : Form
    {
        public static string usernameString = "";
        public static string IDString = "";
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
        public Login()
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

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clickLogin(object sender, EventArgs e)
        {

            string connetionString = @"Data Source=DESKTOP-6UD786S;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC loginProcess '"+ usernameInput.Text +"', '"+ passwordInput.Text +"'",cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            try
            {
                // If login as a Partner user          
                if (dt.Rows[0][7].ToString() == "0")
                {
                    // Get data
                    IDString = dt.Rows[0][2].ToString();

                    SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getPartner '"+ IDString +"'", cnn);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    IDString = dt1.Rows[0][0].ToString();
                    name = dt1.Rows[0][1].ToString();
                    contactNumber = dt1.Rows[0][8].ToString();
                    location = dt1.Rows[0][7].ToString();
                    email = dt1.Rows[0][9].ToString();

                    // Transition to homepage
                    PartnerHomepage partner = new PartnerHomepage();
                    partner.Show();
                }

                // If login as a Customer user
                if (dt.Rows[0][7].ToString() == "1")
                {
                    // Get data
                    IDString = dt.Rows[0][3].ToString();

                    SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getCustomer '" + IDString + "'", cnn);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    IDString = dt1.Rows[0][0].ToString();
                    name = dt1.Rows[0][1].ToString();
                    contactNumber = dt1.Rows[0][2].ToString();
                    location = dt1.Rows[0][3].ToString();
                    email = dt1.Rows[0][4].ToString();

                    // Transition to homepage
                    CustomerHomepage customer = new CustomerHomepage();
                    customer.Show();
                }

                // If login as a Shipper user
                if (dt.Rows[0][7].ToString() == "2")
                {
                    // Get data
                    IDString = dt.Rows[0][4].ToString();

                    SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getShipper '" + IDString + "'", cnn);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    IDString = dt1.Rows[0][0].ToString();
                    name = dt1.Rows[0][1].ToString();
                    contactNumber = dt1.Rows[0][3].ToString();
                    location = dt1.Rows[0][4].ToString();
                    email = dt1.Rows[0][5].ToString(); // Biển số xe

                    // Transition to homepage
                    ShipperHomepage shipper = new ShipperHomepage();
                    shipper.Show();
                }


                // If login as an Employee user
                if (dt.Rows[0][7].ToString() == "3")
                {
                    // Get data
                    IDString = dt.Rows[0][5].ToString();

                    SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getEmployee '" + IDString + "'", cnn);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    IDString = dt1.Rows[0][0].ToString();
                    name = dt1.Rows[0][1].ToString();
                    contactNumber = dt1.Rows[0][3].ToString();
                    location = dt1.Rows[0][4].ToString();
                    email = dt1.Rows[0][5].ToString();

                    // Transition to homepage
                    EmployeeHomepage employee = new EmployeeHomepage();
                    employee.Show();
                }


                // If login as an Administrator user
                if (dt.Rows[0][7].ToString() == "4")
                {
                    // Get data
                    IDString = dt.Rows[0][6].ToString();

                    SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getAdmin '" + IDString + "'", cnn);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    IDString = dt1.Rows[0][0].ToString();
                    name = dt1.Rows[0][1].ToString();
                    contactNumber = dt1.Rows[0][3].ToString();
                    location = dt1.Rows[0][2].ToString();
                    email = dt1.Rows[0][4].ToString();

                    // Transition to homepage
                    AdministratorHomepage administrator = new AdministratorHomepage();
                    administrator.Show();
                }

                this.Hide();
            }
            catch
            {
                MessageBox.Show("Tên đăng nhập sai hoặc mật khẩu sai. Vui lòng nhập lại...", "Đăng nhập");
            }
        }

        private void detectEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                clickLogin(sender, e);
            }
        }
    }
}
