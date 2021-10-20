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
    public partial class ThemChiTiet : Form
    {
        string mess = "";
        string selectedMaHD;
        string selectedMaSP;

        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DELL;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();

        public ThemChiTiet()
        {
            InitializeComponent();
        }

        public ThemChiTiet(string ib):this()
        {
            mess = ib;
        }

        public void loadCT_HoaDon()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM CT_HoaDon WHERE MaHD = '" + mess + "'";

            dataAdapter.SelectCommand = command;
            dataTable.Clear();

            dataAdapter.Fill(dataTable);
            dgv_cthd.DataSource = dataTable;
        }

        private void ThemChiTiet_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadCT_HoaDon();
        }

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            int GiaBan;
            using (SqlConnection SqlCon = new SqlConnection(str))
            {
                // Lấy giá trị sản phẩm
                using (SqlCommand cmd = new SqlCommand("SELECT Gia FROM SanPham sp WHERE sp.MaSP = @MaSP", SqlCon))
                {
                    SqlCon.Open();
                    cmd.Parameters.AddWithValue("MaSP", tb_MaSP.Text);

                    cmd.ExecuteNonQuery();

                    object result = cmd.ExecuteScalar();
                    GiaBan = Convert.ToInt32(result);

                    SqlCon.Close();

                }

                SqlCon.Open();
                command = connection.CreateCommand();
                try
                {

                    command.CommandText = "INSERT INTO CT_HoaDon (MaHD, MaSP, SoLuong, GiaBan, GiaGiam) VALUES ('" + mess + "','" + tb_MaSP.Text + "','" + tb_SL.Text + "'," + GiaBan + "," + tb_GiaGiam.Text + ")";
                    command.ExecuteNonQuery();

                    MessageBox.Show("Thêm chi tiết thành công", "Thông báo");
                    loadCT_HoaDon();
                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm hóa đơn mới thất bại.\n Mã sản phẩm trên đã tồn tại trong hóa đơn hoặc Mã sản phẩm không tồn tại.", "Thông Báo");
                }
                SqlCon.Close();
            }
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_MaSP_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT Gia FROM SanPham sp WHERE sp.MaSP = @MaSP", SqlCon))
                {
                    SqlCon.Open();
                    cmd.Parameters.AddWithValue("MaSP", tb_MaSP.Text);

                    cmd.ExecuteNonQuery();

                    object result = cmd.ExecuteScalar();

                    GiaBanMaSP.Text = Convert.ToString(result);

                    if (GiaBanMaSP.Text == "")
                    {
                        GiaBanMaSP.Text = "N/A";
                    }
                    SqlCon.Close();

                }

                using (SqlCommand cmd = new SqlCommand("SELECT MaSP as 'Mã Sản Phẩm', TenSP as 'Tên', SoLuongTon as 'Số Lượng Tồn'," +
                    "Mota as 'Mô tả', Gia as 'Giá' " +
                    "FROM SanPham where MaSP like '%'+@MaSP+'%' or TenSP like '%'+@TenSP+'%'", SqlCon))
                {
                    cmd.Parameters.AddWithValue("MaSP", tb_MaSP.Text);
                    cmd.Parameters.AddWithValue("TenSP", tb_MaSP.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dtbl = new DataTable("SanPham");
                    adapter.Fill(dtbl);
                    InfoSanPhamThemHD.DataSource = dtbl;
                }
            }

        }

        private void InfoSanPhamThemHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(str))
            {
                if (InfoSanPhamThemHD.SelectedCells.Count > 0)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = InfoSanPhamThemHD.Rows[rowIndex];
                    InfoSanPhamThemHD.CurrentRow.Selected = true;

                    string val = selectedRow.Cells[0].Value.ToString();
                    val = val.Trim(' ');

                    tb_MaSP.Text = val;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(str))
            {
                SqlCon.Open();
                command = connection.CreateCommand();
                try
                {
                    command.CommandText = "DELETE FROM CT_HoaDon WHERE MaSP like '%'+'" + selectedMaSP + "'+'%' and MaHD like '%'+'" + selectedMaHD + "'+'%';";
                    command.ExecuteNonQuery();

                    MessageBox.Show("Xoá chi tiết thành công", "Thông báo");
                    loadCT_HoaDon();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa chi tiết.\nKhông tìm thấy mã sản phẩm phù hợp.", "Thông Báo");
                }
                SqlCon.Close();
            }
        }

        private void dgv_cthd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(str))
            {
                if (dgv_cthd.SelectedCells.Count > 0)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = dgv_cthd.Rows[rowIndex];
                    dgv_cthd.CurrentRow.Selected = true;

                    selectedMaHD = selectedRow.Cells[0].Value.ToString();
                    selectedMaHD = selectedMaHD.Trim(' ');

                    selectedMaSP = selectedRow.Cells[1].Value.ToString();
                    selectedMaSP = selectedMaSP.Trim(' ');
                }
            }
        }
    }
}
