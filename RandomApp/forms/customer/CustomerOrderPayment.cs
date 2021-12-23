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
    public partial class CustomerOrderPayment : Form
    {
        public static string customerID = "";
        public static string orderIDStr = "";
        public static string partnerID = "";
        public static string myProductID = "";

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
        public CustomerOrderPayment()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void CustomerOrderPayment_Load(object sender, EventArgs e)
        {
            orderIDStr = CustomerOrderProduct.randomOrderID;
            customerID = CustomerHomepage.IDString;
            partnerID = CustomerOrderProduct.partnerIDStr;

            string connectionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";

            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getDetailsFromOrder '" + orderIDStr + "'", cnn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            myOrder.DataSource = dt1;
            int sum = 0;
            int shippingFeeNum = 0;

            for (int i = 0; i < myOrder.Rows.Count; i++)
            {
                sum += Convert.ToInt32(myOrder.Rows[i].Cells[4].Value.ToString());
            }

            shippingFeeNum = ((sum * 2) / 100) *myOrder.Rows.Count;
            subTotal.Text = sum.ToString();
            shippingFee.Text = shippingFeeNum.ToString();
            total.Text = (sum + shippingFeeNum).ToString();
        }

        private void clickBack(object sender, EventArgs e)
        {
            CustomerOrderProduct orderProduct = new CustomerOrderProduct();
            orderProduct.Show();
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

        private void clickSubmit(object sender, EventArgs e)
        {
            int payment = -1;
            if (checkPayment0.Checked) payment = 0;
            if (checkPayment1.Checked) payment = 1;

            if (locationInput.Text.Equals(""))
                MessageBox.Show("Vui lòng nhập địa chỉ giao hàng", "Thông báo");
            else if (payment == -1)
                MessageBox.Show("Vui lòng hình thức thanh toán", "Thông báo");
            else
            {
                string connectionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
                string command = "EXEC submitOrder '" + customerID + "','" + partnerID + "','" + orderIDStr + "', N'" + locationInput.Text + "'," + payment + "," + Convert.ToInt32(subTotal.Text) + "," + Convert.ToInt32(shippingFee.Text);

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                CustomerOrderSuccess success = new CustomerOrderSuccess();
                success.Show();
                this.Close();
            }
        }

        private void clickRemove(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            string command = "EXEC removeProductFromCart '" + orderIDStr + "','" + myProductID + "'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(command, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getDetailsFromOrder '" + orderIDStr + "'", cnn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            myOrder.DataSource = dt1;
        }

        private void clickProductCell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                myProductID = myOrder.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
