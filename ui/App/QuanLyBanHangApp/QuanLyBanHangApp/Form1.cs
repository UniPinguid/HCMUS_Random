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
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DELL;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection SqlCon = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon where MaHD like '%'+@MaHD+'%' or MaKH like '%'+@MaKH+'%'", SqlCon))
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
    }
}
