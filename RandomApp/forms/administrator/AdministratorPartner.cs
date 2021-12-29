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
    public partial class AdministratorPartner : Form
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

        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();


        //thuộc tính đối tác đang hiển thị
        public static string id;
        public static string name;
        public static string phonenumber;
        public static string mail;
        public static string address;
        public static string daidien;
        public static string sochinhanh;
        public static string lhang;
        public static string slDon;
        public static string city;
        public AdministratorPartner()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
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
            AdministratorHomepage homepage = new AdministratorHomepage();
            homepage.Show();
            this.Close();
        }

        private void clickEdit(object sender, EventArgs e)
        {
            AdministratorPartnerEdit edit = new AdministratorPartnerEdit(maDoiTac.Text);
            edit.ShowDialog();
        }

        private void clickDelete(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn xóa đối tác này không?", "Xóa đối tác", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                command = connection.CreateCommand();
                if(Control.ModifierKeys == Keys.Shift)
                {
                    try
                    {
                        string command = "EXEC Xoa_DoiTac_FIX '" + maDoiTac.Text;
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand(command, conn))
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        loadData();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông Báo");
                    }
                }
                else
                {
                    try
                    {
                        string command = "EXEC Xoa_DoiTac '" + maDoiTac.Text;
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        using (SqlCommand cmd = new SqlCommand(command, conn))
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();
                        }
                        loadData_Fix();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông Báo");
                    }
                }
            }
        }
        public void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "EXEC XemDSDoiTac";
            _ = command.ExecuteNonQuery();
            dataAdapter.SelectCommand = command;
            dataTable.Clear();

            dataAdapter.Fill(dataTable);
            dgv1.DataSource = dataTable;
        }
        public void loadData_Fix()
        {
            command = connection.CreateCommand();
            command.CommandText = "EXEC XemDSDoiTac_FIX";
            _ = command.ExecuteNonQuery();
            dataAdapter.SelectCommand = command;
            dataTable.Clear();

            dataAdapter.Fill(dataTable);
            dgv1.DataSource = dataTable;
        }
        private void AdministratorPartner_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            if (Control.ModifierKeys == Keys.Shift)
            {
                loadData();
            }
            else
            {
                loadData_Fix();
            }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv1.CurrentRow.Index;

            maDoiTac.Text = dgv1.Rows[i].Cells[0].Value.ToString();
            tenDoiTac.Text = dgv1.Rows[i].Cells[1].Value.ToString();
            daiDien.Text = dgv1.Rows[i].Cells[2].Value.ToString();
            loaiHang.Text = dgv1.Rows[i].Cells[6].Value.ToString();
            soCN.Text = dgv1.Rows[i].Cells[4].Value.ToString();
            SLDon.Text = dgv1.Rows[i].Cells[5].Value.ToString();
            sdt.Text = dgv1.Rows[i].Cells[8].Value.ToString();
            email.Text = dgv1.Rows[i].Cells[9].Value.ToString();
            thanhPho.Text = dgv1.Rows[i].Cells[3].Value.ToString();

            name = tenDoiTac.Text;
            id = maDoiTac.Text;
            daidien=daiDien.Text;
            lhang = loaiHang.Text;
            sochinhanh = soCN.Text;
            slDon=SLDon.Text;
            phonenumber=sdt.Text;
            mail=email.Text;
            address = dgv1.Rows[i].Cells[7].Value.ToString();
            city = thanhPho.Text;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            if (Control.ModifierKeys == Keys.Shift)
            {
                try
                {
                    SqlConnection cnn;
                    cnn = new SqlConnection(connectionString);

                    SqlDataAdapter sda = new SqlDataAdapter("EXEC TimKiem_DoiTac_FIX N'" + searchBox.Text + "'", cnn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dgv1.DataSource = dt;
                }
                catch (Exception)
                {
                    _ = MessageBox.Show("Tìm kiếm thất bại!", "Thông Báo");
                }
            }
            else
            {
                try
                {
                    SqlConnection cnn;
                    cnn = new SqlConnection(connectionString);

                    SqlDataAdapter sda = new SqlDataAdapter("EXEC TimKiem_DoiTac N'" + searchBox.Text + "'", cnn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dgv1.DataSource = dt;
                }
                catch (Exception)
                {
                    _ = MessageBox.Show("Tìm kiếm thất bại!", "Thông Báo");
                }
            }
        }
    }
}
