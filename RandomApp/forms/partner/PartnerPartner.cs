using System;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;

namespace RandomApp
{
    public partial class PartnerPartner : Form
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
        public PartnerPartner()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "EXEC XemDSDoiTac";
            _ = command.ExecuteNonQuery();
            dataAdapter.SelectCommand = command;
            dataTable.Clear();

            _ = dataAdapter.Fill(dataTable);
            dgv1.DataSource = dataTable;
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
            PartnerHomepage homepage = new PartnerHomepage();
            homepage.Show();
            this.Close();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv1.CurrentRow.Index;

            idDT.Text = dgv1.Rows[i].Cells[0].Value.ToString();
            tenDT.Text = dgv1.Rows[i].Cells[1].Value.ToString();
            ddien.Text = dgv1.Rows[i].Cells[2].Value.ToString();
            lhang.Text = dgv1.Rows[i].Cells[6].Value.ToString();
            soCN.Text = dgv1.Rows[i].Cells[4].Value.ToString();
            sldon.Text = dgv1.Rows[i].Cells[5].Value.ToString();
            sdt.Text = dgv1.Rows[i].Cells[8].Value.ToString();
            email.Text = dgv1.Rows[i].Cells[9].Value.ToString();
            tpho.Text = dgv1.Rows[i].Cells[3].Value.ToString();
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

        private void PartnerPartner_Load(object sender, EventArgs e)
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
    }
}
