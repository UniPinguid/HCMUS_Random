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
    public partial class EmployeeContractList : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;

        public static string contractIDStr = "";

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
        public EmployeeContractList()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickApprove(object sender, EventArgs e)
        {
            if (!end.Text.Equals(""))
                MessageBox.Show("Hợp đồng đã xác nhận", "Thông báo");
            else {
                DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn duyệt hợp đồng này không?", "Duyệt hợp đồng", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string command = "EXEC sp_XacNhanHopDong '" + contractID.Text + "'";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(command, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    // Reload data
                    SqlConnection cnn;
                    cnn = new SqlConnection(connectionString);

                    SqlDataAdapter sda = new SqlDataAdapter("EXEC sp_XemDanhSachHopDong '" + partnerID.Text + "', N'" + searchContract.Text + "'", cnn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    listContract.DataSource = dt;

                    EmployeeContractApprove success = new EmployeeContractApprove();
                    success.ShowDialog();
                }
            }
        }

        private void clickExtend(object sender, EventArgs e)
        {
            EmployeeContractExtend extend = new EmployeeContractExtend();
            extend.ShowDialog();
        }

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clickBack(object sender, EventArgs e)
        {
            EmployeeContract contract = new EmployeeContract();
            contract.Show();
            this.Close();
        }

        private void clickViewInfo(object sender, EventArgs e)
        {
            Contract contract = new Contract();
            contract.ShowDialog();
        }

        private void clickSearch(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getContractList '" + partnerID.Text + "', N'" + searchContract.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            listContract.DataSource = dt;
        }

        private void clickRefresh(object sender, EventArgs e)
        {
            // If holding Shift key
            if (Control.ModifierKeys == Keys.Shift)
            {
                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);

                SqlDataAdapter sda = new SqlDataAdapter("EXEC sp_XemDanhSachHopDong_Fixed '" + partnerID.Text + "', N'" + searchContract.Text + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                listContract.DataSource = dt;
            }

            // If not holding Shift key
            else
            {
                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);

                SqlDataAdapter sda = new SqlDataAdapter("EXEC sp_XemDanhSachHopDong '" + partnerID.Text + "', N'" + searchContract.Text + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                listContract.DataSource = dt;
            }
        }

        private void EmployeeContractList_Load(object sender, EventArgs e)
        {
            partnerID.Text = EmployeeContract.partnerIDStr;
            partnerName.Text = EmployeeContract.partnerNameStr;
            contactNumber.Text = EmployeeContract.contactNumberStr;
            email.Text = EmployeeContract.emailStr;
            location.Text = EmployeeContract.locationStr;
            representative.Text = EmployeeContract.representativeStr;
            noBranch.Text = EmployeeContract.noBranchStr;
            type.Text = EmployeeContract.typeStr;
            productAmount.Text = EmployeeContract.productAmountStr;

            // Get contract list
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getContractList '" + partnerID.Text + "', N'" + searchContract.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            listContract.DataSource = dt;
        }

        private void cellClickContract(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                contractID.Text = listContract.Rows[e.RowIndex].Cells[0].Value.ToString();
                contractLocation.Text = listContract.Rows[e.RowIndex].Cells[2].Value.ToString();
                start.Text = listContract.Rows[e.RowIndex].Cells[3].Value.ToString();
                end.Text = listContract.Rows[e.RowIndex].Cells[4].Value.ToString();

                contractIDStr = contractID.Text;
            }
        }
    }
}
