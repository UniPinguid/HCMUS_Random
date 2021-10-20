using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHangApp
{
    public partial class FormHoaDon : Form
    {
        string connectionString = @"Data Source=.;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT MaHD as 'Mã Hóa Đơn', MaKH as 'Mã Khách Hàng', NgayLap as 'Ngày Lập'," +
                    "TongTien as 'Tổng Tiền' FROM HoaDon where MaHD like '%'+@MaHD+'%' or MaKH like '%'+@MaKH+'%'", SqlCon))
                {
                    cmd.Parameters.AddWithValue("MaHD", textBox1.Text);
                    cmd.Parameters.AddWithValue("MaKH", textBox1.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dtbl = new DataTable("HoaDon");
                    adapter.Fill(dtbl);
                    dataGridView1.DataSource = dtbl;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionString))
            {
                string query = "SELECT SUM(TongTien) FROM HoaDon where year(NgayLap) = @year and month(NgayLap) = @month";
                using (SqlCommand cmd = new SqlCommand(query, SqlCon))
                {
                    SqlCon.Open();
                    cmd.Parameters.AddWithValue("year", yearBox.Text);
                    cmd.Parameters.AddWithValue("month", monthBox.Text);

                    cmd.ExecuteNonQuery();

                    object result = cmd.ExecuteScalar();

                    sumDoanhThu.Text = "Tổng doanh thu: " + Convert.ToString(result);
                    SqlCon.Close();
                }
            }
        }

        private void SanPhamStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSanPham SanPhamForm = new FormSanPham();
            SanPhamForm.Show();
        }

        private void KhachHangStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormKhachHang formKhachHang = new FormKhachHang();
            formKhachHang.Show();
        }

        private void CTHDstripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCTHD CTHDForm = new FormCTHD();
            CTHDForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ThemHoaDonMoi FormThemHD = new ThemHoaDonMoi();
            FormThemHD.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XoaHD FormXoaHD = new XoaHD();
            FormXoaHD.Show();
        }

        private void ExitMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
