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
    public partial class CustomerOrder : Form
    {
        public static string customerID = "";
        public static string partnerIDStr = "";
        public static string randomOrderID = "";
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
        public CustomerOrder()
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

        private void clickBack(object sender, EventArgs e)
        {
            CustomerHomepage homepage = new CustomerHomepage();
            homepage.Show();
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

        private void clickChoose(object sender, EventArgs e)
        {
            // Create empty order
            
            randomOrderID = "DH" + RandomString(6);

            string connectionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            string command = "EXEC createEmptyOrder '" + customerID + "','" + partnerID.Text + "','" + randomOrderID + "'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(command, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            CustomerOrderProduct orderProduct = new CustomerOrderProduct();
            orderProduct.Show();
            this.Close();
        }

        private void CustomerOrder_Load(object sender, EventArgs e)
        {
            customerID = CustomerHomepage.IDString;

            string connetionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getPartnerList N'" + searchPartner.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            listPartner.DataSource = dt;
        }

        private void clickSearch(object sender, EventArgs e)
        {
            string connetionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getPartnerList N'" + searchPartner.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            listPartner.DataSource = dt;
        }

        private void cellClickOrder(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                partnerID.Text = listPartner.Rows[e.RowIndex].Cells[0].Value.ToString();
                partnerName.Text = listPartner.Rows[e.RowIndex].Cells[1].Value.ToString();
                representative.Text = listPartner.Rows[e.RowIndex].Cells[2].Value.ToString();
                location.Text = listPartner.Rows[e.RowIndex].Cells[4].Value.ToString();
                noBranch.Text = listPartner.Rows[e.RowIndex].Cells[5].Value.ToString();
                contactNumber.Text = listPartner.Rows[e.RowIndex].Cells[6].Value.ToString();
                email.Text = listPartner.Rows[e.RowIndex].Cells[7].Value.ToString();
                type.Text = listPartner.Rows[e.RowIndex].Cells[8].Value.ToString();
                productAmount.Text = listPartner.Rows[e.RowIndex].Cells[9].Value.ToString();

                partnerIDStr = partnerID.Text;
            }
        }
    }
}
