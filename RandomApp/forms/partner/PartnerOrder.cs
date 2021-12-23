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
    public partial class PartnerOrder : Form
    {
        public static string partnerIDStr = "";
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
        public PartnerOrder()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickBack(object sender, EventArgs e)
        {
            PartnerHomepage homepage = new PartnerHomepage();
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

        private void clickUpdateOrder(object sender, EventArgs e)
        {
            // Check status
            int status = 0;
            if (checkStatus1.Checked) status = 1;
            if (checkStatus2.Checked) status = 2;
            if (checkStatus3.Checked) status = 3;
            if (checkStatus4.Checked) status = 4;
            if (checkStatus5.Checked) status = 5;

            // Update order
            string connectionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            string command = "EXEC updateOrder '" + orderIDStr + "','" + status + "'";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                PartnerProductUpdateSuccess success = new PartnerProductUpdateSuccess();
                success.ShowDialog();

                // Reupdate table after updating order status 
                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);

                SqlDataAdapter sda = new SqlDataAdapter("EXEC getOrderPartner '" + partnerIDStr + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                listOrder.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Không thể cập nhật đơn hàng vì đang có khách hàng theo dõi đơn hàng này.", "Thông báo");
            }
        }

        private void PartnerOrder_Load(object sender, EventArgs e)
        {
            partnerIDStr = PartnerHomepage.IDString;

            try
            {
                string connetionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
                SqlConnection cnn;
                cnn = new SqlConnection(connetionString);

                SqlDataAdapter sda = new SqlDataAdapter("EXEC getOrderPartner '" + partnerIDStr + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                listOrder.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Bạn chưa có đơn hàng nào!", "Thông báo");
            }
        }

        private void clickCellOrder(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                orderID.Text = listOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
                customerID.Text = listOrder.Rows[e.RowIndex].Cells[1].Value.ToString();
                location.Text = listOrder.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateOrdered.Text = listOrder.Rows[e.RowIndex].Cells[3].Value.ToString();
                payment.Text = listOrder.Rows[e.RowIndex].Cells[4].Value.ToString();
                if (payment.Text.Equals("False")) payment.Text = "Thanh toán bằng tiền mặt";
                if (payment.Text.Equals("True")) payment.Text = "Thanh toán bằng thẻ";

                orderIDStr = orderID.Text;
            }
        }

        private void clickSearch(object sender, EventArgs e)
        {
            string connetionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getOrderPartner '" + partnerIDStr + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            listOrder.DataSource = dt;
        }

        private void clickOrderDetails(object sender, EventArgs e)
        {
            ShipperOrderDetails orderDetails = new ShipperOrderDetails(orderIDStr);
            orderDetails.ShowDialog();
        }

        private void clickRefresh(object sender, EventArgs e)
        {
            string connetionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            if (Control.ModifierKeys == Keys.Shift)
            {
                SqlDataAdapter sda = new SqlDataAdapter("EXEC getOrderPartner_Fixed '" + partnerIDStr + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                listOrder.DataSource = dt;
            }
            else
            {
                SqlDataAdapter sda = new SqlDataAdapter("EXEC getOrderPartner '" + partnerIDStr + "'", cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                listOrder.DataSource = dt;
            }
        }
    }
}
