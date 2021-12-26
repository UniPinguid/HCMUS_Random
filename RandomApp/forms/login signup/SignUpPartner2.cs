using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;

namespace RandomApp
{
    public partial class SignUpPartner2 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;

        public static string name = "";
        public static string representative = "";
        public static string contactNumber = "";
        public static string email = "";
        public static string location = "";
        public static string districtStr = "";
        public static string provinceStr = "";
        //
        public static string branchID = "";
        public static string productAmount = "";
        public static string type = "";

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
        public SignUpPartner2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickBack(object sender, EventArgs e)
        {
            SignUpPartner1 partner1 = new SignUpPartner1();
            partner1.Show();
            this.Close();
        }

        private void clickSubmit(object sender, EventArgs e)
        {
            branchID = branchIDInput.Text;
            productAmount = productAmountInput.Text;
            type = typeInput.Text;

            SignUpFinal final = new SignUpFinal();
            final.Show();
            this.Close();
        }

        private void SignUpPartner2_Load(object sender, EventArgs e)
        {
            name = SignUpPartner1.name;
            representative = SignUpPartner1.representative;
            contactNumber = SignUpPartner1.contactNumber;
            email = SignUpPartner1.email;
            location = SignUpPartner1.location;
            districtStr = SignUpPartner1.districtStr;
            provinceStr = SignUpPartner1.provinceStr;

            branchIDInput.Text = branchID;
            productAmountInput.Text = productAmount;
            typeInput.Text = type;

            // Load branch list
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM CHINHANH", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            branchList.DataSource = dt;
        }

        private void cellClickBranch(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                branchID = branchList.Rows[e.RowIndex].Cells[0].Value.ToString();
                branchIDInput.Text = branchID;
            }
        }
    }
}
