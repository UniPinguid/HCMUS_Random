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
    public partial class FormSanPham : Form
    {
        string connectionString = @"Data Source=DELL;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public FormSanPham()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT MaSP as 'Mã Sản Phẩm', TenSP as 'Tên', SoLuongTon as 'Số Lượng Tồn'," +
                    "Mota as 'Mô tả', Gia as 'Giá' " +
                    "FROM SanPham where MaSP like '%'+@MaSP+'%' or TenSP like '%'+@TenSP+'%'", SqlCon))
                {
                    cmd.Parameters.AddWithValue("MaSP", textBox1.Text);
                    cmd.Parameters.AddWithValue("TenSP", textBox1.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dtbl = new DataTable("SanPham");
                    adapter.Fill(dtbl);
                    DataSanPham.DataSource = dtbl;
                }
            }
        }
    }
}
