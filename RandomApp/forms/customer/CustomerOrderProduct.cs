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
    public partial class CustomerOrderProduct : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyconnectionString"].ConnectionString;
        public static string customerID = "";
        public static string randomOrderID = "DH";
        public static string productID = "";
        public static string myProductID = "";
        public static string partnerIDStr = "";

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
        public CustomerOrderProduct()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void CustomerOrderProduct_Load(object sender, EventArgs e)
        {
            // Get order ID
            randomOrderID = CustomerOrder.randomOrderID;

            // Get user customer info
            customerID = CustomerHomepage.IDString;

            // Get partner info
            string partnerIDStr = CustomerOrder.partnerIDStr;

            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda = new SqlDataAdapter("EXEC getPartnerList '" + partnerIDStr + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            partnerID.Text = dt.Rows[0][0].ToString();
            partnerName.Text = dt.Rows[0][1].ToString();
            representative.Text = dt.Rows[0][2].ToString();
            location.Text = dt.Rows[0][4].ToString();
            noBranch.Text = dt.Rows[0][5].ToString();
            contactNumber.Text = dt.Rows[0][6].ToString();
            email.Text = dt.Rows[0][7].ToString();
            type.Text = dt.Rows[0][8].ToString();
            productAmount.Text = dt.Rows[0][9].ToString();

            partnerIDStr = partnerID.Text;

            // Get partner's products
            SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getProductPartner '" + partnerIDStr + "','" + searchProduct.Text + "'", cnn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            listProduct.DataSource = dt1;

            // Get list of my products
            SqlDataAdapter sda2 = new SqlDataAdapter("EXEC getDetailsFromOrder '" + randomOrderID + "'", cnn);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);

            selectedProduct.DataSource = dt2;
        }

        private void clickBack(object sender, EventArgs e)
        {
            // Remove order when clicking back
            string command = "EXEC removeOrder '" + randomOrderID + "'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(command, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            CustomerOrder order = new CustomerOrder();
            order.Show();
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

        private void clickProceedOrder(object sender, EventArgs e)
        {
            // Proceed to payment form
            CustomerOrderPayment orderPayment = new CustomerOrderPayment();
            orderPayment.Show();
            this.Close();
        }

        private void clickAddProduct(object sender, EventArgs e)
        {
            // Proceed to adding a new order
            string command = "EXEC addProductToCart '" + customerID + "','" + partnerID.Text + "','" + randomOrderID + "','" + productID + "', " + amount.Text + " ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(command, conn))
            {
                if (amount.Text.Equals(""))
                    MessageBox.Show("Xin vui lòng nhập số lượng đơn hàng", "Thông báo");
                else
                {
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể thêm sản phẩm vì đã có trong đơn hàng", "Thông báo");
                    }
                }
            }

            // Update selected list
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getDetailsFromOrder '" + randomOrderID + "'", cnn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            selectedProduct.DataSource = dt1;
        }

        private void cellProductClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                productID = listProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void clickSearch(object sender, EventArgs e)
        {
            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getProductPartner '" + partnerID.Text + "','" + searchProduct.Text + "'", cnn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            listProduct.DataSource = dt1;
        }

        private void clickRemove(object sender, EventArgs e)
        {
            string command = "EXEC removeProductFromCart '" + randomOrderID + "','" + myProductID + "'";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(command, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);

            SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getDetailsFromOrder '" + randomOrderID + "'", cnn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            selectedProduct.DataSource = dt1;
        }

        private void clickCellMyProduct(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                myProductID = selectedProduct.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
