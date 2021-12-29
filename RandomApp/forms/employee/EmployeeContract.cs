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
    public partial class EmployeeContract : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;

        public static string partnerIDStr = "";
        public static string partnerNameStr = "";
        public static string representativeStr = "";
        public static string locationStr = "";
        public static string noBranchStr = "";
        public static string contactNumberStr = "";
        public static string emailStr = "";
        public static string typeStr = "";
        public static string productAmountStr = "";

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
        public EmployeeContract()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickBack(object sender, EventArgs e)
        {
            EmployeeHomepage homepage = new EmployeeHomepage();
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

        private void clickContract(object sender, EventArgs e)
        {
            EmployeeContractList contractList = new EmployeeContractList();
            contractList.Show();
            this.Close();
        }

        private void clickSearch(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getPartnerList N'" + searchPartner.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            partnerList.DataSource = dt;
        }

        private void EmployeeContract_Load(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getPartnerList N'" + searchPartner.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            partnerList.DataSource = dt;

            /*
            using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("sp_XemDanhSachHopDong", con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataSet ds = new DataSet();
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(ds);
                    partnerList.DataSource = ds.Tables[0].DefaultView;
                }
            }
            */
        }

        private void clickRefresh(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getPartnerList N'" + searchPartner.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            partnerList.DataSource = dt;
        }

        private void cellClickPartner(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                partnerID.Text = partnerList.Rows[e.RowIndex].Cells[0].Value.ToString();
                partnerName.Text = partnerList.Rows[e.RowIndex].Cells[1].Value.ToString();
                representative.Text = partnerList.Rows[e.RowIndex].Cells[2].Value.ToString();
                location.Text = partnerList.Rows[e.RowIndex].Cells[4].Value.ToString();
                noBranch.Text = partnerList.Rows[e.RowIndex].Cells[5].Value.ToString();
                contactNumber.Text = partnerList.Rows[e.RowIndex].Cells[6].Value.ToString();
                email.Text = partnerList.Rows[e.RowIndex].Cells[7].Value.ToString();
                type.Text = partnerList.Rows[e.RowIndex].Cells[8].Value.ToString();
                productAmount.Text = partnerList.Rows[e.RowIndex].Cells[9].Value.ToString();

                partnerIDStr = partnerID.Text;
                partnerNameStr = partnerName.Text;
                representativeStr = representative.Text;
                locationStr = location.Text;
                noBranchStr = noBranch.Text;
                contactNumberStr = contactNumber.Text;
                emailStr = email.Text;
                typeStr = type.Text;
                productAmountStr = productAmount.Text;
            }
        }
    }
}
