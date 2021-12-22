using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace RandomApp
{
    public partial class ShipperTakeOrder : Form
    {
        public static string orderIDStr = "";
        public static string shipperID = "";
        public static int shippingFeeNum = 0;

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
        public ShipperTakeOrder()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void ShipperTakeOrder_Load(object sender, EventArgs e)
        {
            shipperID = ShipperHomepage.IDString;

            string connetionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getOrderPending '" + searchOrder.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            listPendingOrder.DataSource = dt;
        }

        private void clickOrderDetails(object sender, EventArgs e)
        {
            ShipperOrderDetails orderDetails = new ShipperOrderDetails(orderIDStr);
            orderDetails.ShowDialog();
        }

        private void clickTakeOrder(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            string command = "EXEC takeOrder_Fixed '" + orderIDStr + "','" + shipperID + "','" + shippingFeeNum + "'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(command, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            ShipperTakeOrderSuccess success = new ShipperTakeOrderSuccess();
            success.ShowDialog();
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

        private void clickSearch(object sender, EventArgs e)
        {
            string connetionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getOrderPending '" + searchOrder.Text + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            listPendingOrder.DataSource = dt;
        }

        private void clickCellOrder(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                orderID.Text = listPendingOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                customerID.Text = listPendingOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                partnerID.Text = listPendingOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
                location.Text = listPendingOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
                dateOrdered.Text = listPendingOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
                payment.Text = listPendingOrder.Rows[e.RowIndex].Cells[5].Value.ToString();

                orderIDStr = orderID.Text;
            }
        }
    }
}
