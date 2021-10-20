using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanHangApp
{
    public partial class ThemHoaDonMoi : Form
    {
        private string mess;
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DELL;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public ThemHoaDonMoi()
        {
            InitializeComponent();
        }

        public ThemHoaDonMoi(string ib) : this()
        {
            mess = ib;
        }

        private void ThemHoaDonMoi_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            try
            {
                command.CommandText = "INSERT INTO HoaDon (MaHD, MaKH, NgayLap, TongTien) VALUES ('" + tb_maHD.Text + "','" + tb_maKH.Text + "','" + dt_ngaylap.Text + "', 0)";
                command.ExecuteNonQuery();

                ThemChiTiet themCTHD = new ThemChiTiet(tb_maHD.Text);
                themCTHD.Show();
                this.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Thêm hóa đơn mới thất bại.\nHóa đơn trên của khách hàng tương ứng đã tồn tại hoặc Mã khách hàng không tồn tại.", "Thông Báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_maKH_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(str))
            {
                // Lấy thông tin nhập từ textbox rồi in ra bảng Hóa Đơn
                using (SqlCommand cmd = new SqlCommand("SELECT MaKH as 'Mã Khách Hàng', Ho as 'Họ', Ten as 'Tên', Ngsinh as 'Ngày sinh'," +
                    "SoNha as 'Số nhà', Duong as 'Đường', Phuong as 'Phường', Quan as 'Quận', Tpho as 'Tỉnh/Thành phố', DienThoai as 'SĐT' " +
                    " FROM KhachHang where MaKH like '%'+@MaKH+'%' or Ten like '%'+@Ten+'%' or Ho like '%'+@Ho+'%'", SqlCon))
                {
                    cmd.Parameters.AddWithValue("MaKH", tb_maKH.Text);
                    cmd.Parameters.AddWithValue("Ho", tb_maKH.Text);
                    cmd.Parameters.AddWithValue("Ten", tb_maKH.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dtbl = new DataTable("KhachHang");
                    adapter.Fill(dtbl);
                    InfoKhachHangThemHD.DataSource = dtbl;
                }
            }
        }

        private void InfoKhachHangThemHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(str))
            {
                if (InfoKhachHangThemHD.SelectedCells.Count > 0)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = InfoKhachHangThemHD.Rows[rowIndex];
                    InfoKhachHangThemHD.CurrentRow.Selected = true;

                    string val = selectedRow.Cells[0].Value.ToString();

                    tb_maKH.Text = val;
                }
            }
        }
    }
}
