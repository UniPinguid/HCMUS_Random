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
    public partial class XoaHD : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DELL;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        public XoaHD()
        {
            InitializeComponent();
        }

        private void XoaHD_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
        }

        public void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM HoaDon WHERE MaHD = '" + tb_maHD.Text + "'";

            dataAdapter.SelectCommand = command;
            dataTable.Clear();

            dataAdapter.Fill(dataTable);
            dgv_hd.DataSource = dataTable;
        }

        public void loadCTHD(string inputMaHD)
        {
            using (SqlConnection SqlCon = new SqlConnection(str))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT MaHD as 'Mã Hóa Đơn', MaSP as 'Mã Sản Phẩm', SoLuong as 'Số Lượng', GiaBan as 'Giá', " +
                    "GiaGiam as 'Giá Giảm', ThanhTien as 'Thành Tiền' FROM CT_HoaDon ct where ct.MaHD like '%'+@MaHD+'%'", SqlCon))
                {
                    cmd.Parameters.AddWithValue("MaHD", inputMaHD);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dtbl = new DataTable("CT_HoaDon");
                    adapter.Fill(dtbl);
                    InfoCTHDXoaHD.DataSource = dtbl;
                }
            }
        }

        private void bt_xacnhan_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            try
            {
                command.CommandText = "DELETE FROM CT_HoaDon WHERE maHD = '" + tb_maHD.Text + "'";
                command.ExecuteNonQuery();

                command.CommandText = "DELETE FROM HoaDon WHERE maHD = '" + tb_maHD.Text + "'";
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Thông báo");
                loadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Xóa hóa đơn thất bại.", "Thông Báo");
            }
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_maHD_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(str))
            {
                // Lấy thông tin nhập từ textbox rồi in ra bảng Hóa Đơn
                using (SqlCommand cmd = new SqlCommand("SELECT TOP 100 hd.MaHD as 'Mã Hóa Đơn', MaKH as 'Mã Khách Hàng', NgayLap as 'Ngày Lập', " +
                    "TongTien as 'Tổng Tiền', count(ct.MaHD) as 'Số chi tiết' " +
                    "FROM HoaDon hd, CT_HoaDon ct " +
                    "where hd.MaHD = ct.MaHD and(hd.MaHD like '%' + 'a' + '%' or hd.MaKH like '%' + 'a' + '%') " +
                    "group by hd.MaHD, hd.MaKH, hd.NgayLap, hd.TongTien " +
                    "having count(ct.MaHD) >= 0", SqlCon))
                {
                    cmd.Parameters.AddWithValue("MaHD", tb_maHD.Text);
                    cmd.Parameters.AddWithValue("MaKH", tb_maHD.Text);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable dtbl = new DataTable("HoaDon");
                    adapter.Fill(dtbl);
                    dgv_hd.DataSource = dtbl;
                }
            }
        }

        private void dgv_hd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(str))
            {
                SqlCon.Open();
                if (dgv_hd.SelectedCells.Count > 0)
                {
                    int rowIndex = e.RowIndex;
                    DataGridViewRow selectedRow = dgv_hd.Rows[rowIndex];
                    dgv_hd.CurrentRow.Selected = true;

                    string val = selectedRow.Cells[0].Value + string.Empty;
                    val = val.Trim(' ');

                    tb_maHD.Text = val;

                    this.loadCTHD(val);
                }

                SqlCon.Close();
            }
        }
    }
}
