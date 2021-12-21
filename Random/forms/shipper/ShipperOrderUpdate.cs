using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Random
{
    public partial class ShipperOrderUpdate : Form
    {
        public static string IDString = "";
        public static string orderIDStr = "";

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
        public ShipperOrderUpdate()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickBack(object sender, EventArgs e)
        {
            ShipperHomepage homepage = new ShipperHomepage();
            homepage.Show();
            this.Close();
        }

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clickUpdate(object sender, EventArgs e)
        {
            PartnerProductUpdateSuccess success = new PartnerProductUpdateSuccess();
            success.ShowDialog();
        }

        private void clickOrderDetails(object sender, EventArgs e)
        {
            ShipperOrderDetails orderDetails = new ShipperOrderDetails(IDString);
            orderDetails.ShowDialog();
        }

        private void ShipperOrderUpdate_Load(object sender, EventArgs e)
        {
            IDString = Login.IDString;

            string connetionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getOrderTaken '" + IDString + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            listOrder.DataSource = dt;

        }

        private void clickCellOrder(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                orderID.Text = listOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                customerID.Text = listOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                partnerID.Text = listOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
                location.Text = listOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateOrdered.Text = listOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
                payment.Text = listOrder.Rows[e.RowIndex].Cells[5].Value.ToString();

                orderIDStr = orderID.Text;
            }
        }
    }
}
