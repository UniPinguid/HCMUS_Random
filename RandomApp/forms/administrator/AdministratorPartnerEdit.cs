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
    public partial class AdministratorPartnerEdit : Form
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

        private string maDT;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable dataTable = new DataTable();
        public AdministratorPartnerEdit(string maDoiTac)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));

            maDT = maDoiTac;
        }

        private void clickClose(object sender, EventArgs e)
        {
            connection.Close();
            this.Close();
        }

        private void clickSubmit(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            if(Control.ModifierKeys == Keys.Shift)
            {
                try
                {
                    command.CommandText = "CapNhatTenDoiTac";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.Add("@idDoiTac", SqlDbType.Char).Value = maDT;
                    command.Parameters.Add("@newname", SqlDbType.Char).Value = tenDoiTac.Text;
                    _ = command.ExecuteNonQuery();
                    _ = MessageBox.Show("Cập nhật thành công!", "Thông báo");
                    
                }
                catch (Exception)
                {
                    _ = MessageBox.Show("Cập nhật thất bại!", "Thông Báo");
                    connection.Close();
                    Close();
                }
            }
            else
            {
                try
                {
                    command.CommandText = "CapNhatTenDoiTac_FIX";
                    command.CommandType= CommandType.StoredProcedure;
                    command.Connection = connection;
                    command.Parameters.Add("@idDoiTac", SqlDbType.Char).Value = maDT;
                    command.Parameters.Add("@newname", SqlDbType.Char).Value = tenDoiTac.Text;
                    _ = command.ExecuteNonQuery();
                    _ = MessageBox.Show("Cập nhật thành công!", "Thông báo");
                }
                catch (Exception)
                {
                    _ = MessageBox.Show("Cập nhật thất bại!", "Thông Báo");
                    connection.Close();
                    Close();
                }
            }
        }
        void loadData(string maDoiTac)
        {
            //command = connection.CreateCommand();
            //command.CommandText = "SELECT * FROM DOITAC WHERE ID = '" + maDoiTac+"'";
            //command.ExecuteNonQuery();
            //dataAdapter.SelectCommand = command;
            //dataTable.Clear();

            //dataAdapter.Fill(dataTable);
            //tenDoiTac.Text = dataTable.Rows[0][dataTable.Columns[1].ColumnName].ToString();
            //DaiDien.Text = dataTable.Rows[0][dataTable.Columns[2].ColumnName].ToString();
            //ThanhPho.Text = dataTable.Rows[0][dataTable.Columns[4].ColumnName].ToString();
            //DiaChi.Text = dataTable.Rows[0][dataTable.Columns[7].ColumnName].ToString();
            //SoChiNhanh.Text = dataTable.Rows[0][dataTable.Columns[4].ColumnName].ToString();
            //LoaiHang.Text = dataTable.Rows[0][dataTable.Columns[6].ColumnName].ToString();
            //SLDon.Text = dataTable.Rows[0][dataTable.Columns[5].ColumnName].ToString();
            //SoDienThoai.Text = dataTable.Rows[0][dataTable.Columns[8].ColumnName].ToString();
            //Email.Text = dataTable.Rows[0][dataTable.Columns[9].ColumnName].ToString();
            //dgv_ct.DataSource = dataTable;
            tenDoiTac.Text = AdministratorPartner.name;
            DaiDien.Text = AdministratorPartner.daidien;
            ThanhPho.Text = AdministratorPartner.city;
            DiaChi.Text = AdministratorPartner.address;
            SoChiNhanh.Text = AdministratorPartner.sochinhanh;
            LoaiHang.Text = AdministratorPartner.lhang;
            SLDon.Text = AdministratorPartner.slDon;
            SoDienThoai.Text = AdministratorPartner.phonenumber;
            Email.Text= AdministratorPartner.mail;


        }
        private void AdministratorPartnerEdit_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            loadData(maDT);
        }
    }
}
