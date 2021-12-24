using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Linq;

namespace RandomApp
{
    public partial class SignUpFinal : Form
    {
        public static string username = "";
        public static string password = "";
        public static int role = 0;

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

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void clickSubmit(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                if (passwordInput.Text.Equals(passwordConfirm.Text))
                {
                    string username = usernameInput.Text;
                    string password = passwordInput.Text;

                    // If register as Partner
                    if (role == 0)
                    {
                        string partnerID = "DT";
                        string name = SignUpPartner2.name;
                        string representative = SignUpPartner2.representative;
                        string contactNumber = SignUpPartner2.contactNumber;
                        string email = SignUpPartner2.email;
                        string location = SignUpPartner2.location + ", " + SignUpPartner2.districtStr;
                        string province = SignUpPartner2.provinceStr;
                        string branchID = SignUpPartner2.branchID;
                        string productAmount = SignUpPartner2.productAmount;
                        string type = SignUpPartner2.type;

                        partnerID += RandomString(6);

                        try
                        {
                            string connectionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
                            string command = "EXEC addPartner '" + partnerID + "', N'" + name + "', N'" + representative + "', N'" + province + "','" + branchID + "', " + Convert.ToInt32(productAmount) + ", N'" + type + "', N'" + location + "','" + contactNumber + "','" + email + "','" + username + "','" + password + "'";
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            using (SqlCommand cmd = new SqlCommand(command, conn))
                            {
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }

                            SignUpSuccess success = new SignUpSuccess();
                            success.Show();
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Tên đăng nhập đã có người sử dụng", "Thông báo");
                        }
                    }

                    // If register as Customer
                    if (role == 1)
                    {
                        string customerID = "KH";
                        string name = SignUpCustomer.name;
                        string contactNumber = SignUpCustomer.contactNumber;
                        string email = SignUpCustomer.email;
                        string location = SignUpCustomer.location;

                        customerID += RandomString(6);

                        try
                        {
                            string connectionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
                            string command = "EXEC addCustomer '" + customerID + "', N'" + name + "','" + contactNumber + "','" + email + "', N'" + location + "','" + username + "','" + password + "'";
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            using (SqlCommand cmd = new SqlCommand(command, conn))
                            {
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }

                            SignUpSuccess success = new SignUpSuccess();
                            success.Show();
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Tên đăng nhập đã có người sử dụng", "Thông báo");
                        }
                    }

                    // If register as Shipper
                    if (role == 2)
                    {
                        string shipperID = "TX";
                        string name = SignUpShipper.name;
                        string citizenID = SignUpShipper.citizenID;
                        string contactNumber = SignUpShipper.contactNumber;
                        string location = SignUpShipper.location;
                        string numberPlate = SignUpShipper.numberPlate;
                        string area = SignUpShipper.area;
                        string email = SignUpShipper.email;
                        string bankAccount = SignUpShipper.bankAccount;

                        shipperID += RandomString(6);

                        try
                        {
                            string connectionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
                            string command = "EXEC addShipper '" + shipperID + "', N'" + name + "','" + citizenID + "','" + contactNumber + "', N'" + location + "','" + numberPlate + "', N'" + area + "','" + bankAccount + "','" + username + "','" + password + "'";
                            using (SqlConnection conn = new SqlConnection(connectionString))
                            using (SqlCommand cmd = new SqlCommand(command, conn))
                            {
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }

                            SignUpSuccess success = new SignUpSuccess();
                            success.Show();
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Tên đăng nhập đã có người sử dụng", "Thông báo");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Xin vui lòng nhập lại mật khẩu", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Xin vui lòng chọn Đồng ý với Điều khoản và Cam kết dịch vụ", "Thông báo");
            }
        }

        private void clickBack(object sender, EventArgs e)
        {
            // If selected Partner
            if (role == 0)
            {
                SignUpPartner2 partner = new SignUpPartner2();
                partner.Show();
            }

            // If selected Customer
            else if (role == 1)
            {
                SignUpCustomer customer = new SignUpCustomer();
                customer.Show();
            }

            else if (role == 2)
            {
                // If selected Shipper
                SignUpShipper shipper = new SignUpShipper();
                shipper.Show();
            }

            this.Close();
        }

        private void SignUpFinal_Load(object sender, EventArgs e)
        {
            role = SignUp.check;
        }
    }
}
