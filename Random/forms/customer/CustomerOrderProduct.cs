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
    public partial class CustomerOrderProduct : Form
    {
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
            // Get partner info
            string partnerIDStr = CustomerOrder.partnerIDStr;

            string connetionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

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

            // Get partner's products
            SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getProductPartner '" + partnerIDStr + "','" + searchProduct.Text + "'", cnn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            listProduct.DataSource = dt1;
        }

        private void clickBack(object sender, EventArgs e)
        {
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
            CustomerOrderPayment orderPayment = new CustomerOrderPayment();
            orderPayment.Show();
            this.Close();

            string randomOrderID = "DH";

            Random rnd = new Random();
            int num = rnd.Next();

        }
    }
}
