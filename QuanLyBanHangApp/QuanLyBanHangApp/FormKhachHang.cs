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
    public partial class FormKhachHang : Form
    {
        string connectionString = @"Data Source=DELL;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT MaKH as 'Mã Khách Hàng', Ho as 'Họ', Ten as 'Tên', Ngsinh as 'Ngày sinh'," +
                    "SoNha as 'Số nhà', Duong as 'Đường', Phuong as 'Phường', Quan as 'Quận', Tpho as 'Tỉnh/Thành phố', DienThoai as 'SĐT' " +
                    " FROM KhachHang where MaKH like '%'+@MaKH+'%' or Ten like '%'+@Ten+'%' or Ho like '%'+@Ho+'%'", SqlCon))
                {
                    cmd.Parameters.AddWithValue("MaKH", textBox1.Text);
                    cmd.Parameters.AddWithValue("Ho", textBox1.Text);
                    cmd.Parameters.AddWithValue("Ten", textBox1.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dtbl = new DataTable("KhachHang");
                    adapter.Fill(dtbl);
                    DataKhachHang.DataSource = dtbl;
                }
            }

        }
    }
}
