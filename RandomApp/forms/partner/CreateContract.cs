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
using System.Linq;

namespace RandomApp
{
    public partial class CreateContract : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;

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

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public CreateContract()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void clickBack(object sender, EventArgs e)
        {
            PartnerContract contract = new PartnerContract();
            contract.Show();
            this.Close();
        }

         private void clickCreate(object sender, EventArgs e)
         {
            string randomID = "HD" + RandomString(6);

            string command = "EXEC addContract '" + randomID + "','" + PartnerHomepage.IDString + "','" + SoChiNhanh.Text + "','" + UName.Text + "', N'" + Address.Text + "'";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(command, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            MessageBox.Show("Đăng ký hợp đồng thành công", "Thông báo");
            this.Close();
        }

        private void branchList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                SoChiNhanh.Text = branchList.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void CreateContract_Load(object sender, EventArgs e)
        {
            // Load branch list
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM CHINHANH", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            branchList.DataSource = dt;
        }

        private void clickClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
