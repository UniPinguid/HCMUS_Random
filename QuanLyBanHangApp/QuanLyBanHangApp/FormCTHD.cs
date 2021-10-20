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
    public partial class FormCTHD : Form
    {
        string connectionString = @"Data Source=DELL;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public FormCTHD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT MaHD as 'Mã Hóa Đơn', MaSP as 'Mã Sản Phẩm', SoLuong as 'Số Lượng', GiaBan as 'Giá', " +
                    "GiaGiam as 'Giá Giảm', ThanhTien as 'Thành Tiền' FROM CT_HoaDon where MaHD like '%'+@MaHD+'%' or MaSP like '%'+@MaSP+'%'", SqlCon))
                {
                    cmd.Parameters.AddWithValue("MaHD", textBox1.Text);
                    cmd.Parameters.AddWithValue("MaSP", textBox1.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dtbl = new DataTable("CT_HoaDon");
                    adapter.Fill(dtbl);
                    DataCTHD.DataSource = dtbl;
                }
            }

        }
    }
}
