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
    public partial class AdministratorCustomer : Form
    {
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
        public AdministratorCustomer()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickBack(object sender, EventArgs e)
        {
            AdministratorHomepage homepage = new AdministratorHomepage();
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

        private void clickDelete(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn xóa khách hàng này không?", "Xóa khách hàng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Do something...
            }
        }

        private void clickEdit(object sender, EventArgs e)
        {
            AdministratorCustomerEdit customerEdit = new AdministratorCustomerEdit();
            customerEdit.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
                using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_XemDanhSachTaiKhoanbug", con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;

                    }
                }
            else
                using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True"))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_XemDanhSachTaiKhoanfix", con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        DataSet ds = new DataSet();
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds.Tables[0].DefaultView;
                    }
                }
        }
    }
}
