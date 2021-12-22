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
    public partial class ShipperOrderDetails : Form
    {
        public static string shippingFeeStr = "";
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
        public ShipperOrderDetails(string orderID)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));

            string connetionString = @"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True";
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            // Read details list
            SqlDataAdapter sda = new SqlDataAdapter("EXEC getDetailsFromOrder '" + orderID + "'", cnn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            listDetails.DataSource = dt;

            // Read other information
            SqlDataAdapter sda1 = new SqlDataAdapter("EXEC getOrderTotal '" + orderID + "'", cnn);
            DataTable dt1 = new DataTable();
            sda1.Fill(dt1);

            totalAmount.Text = dt1.Rows[0][3].ToString();
            subTotal.Text = dt1.Rows[0][0].ToString();
            shippingFee.Text = dt1.Rows[0][1].ToString();
            total.Text = dt1.Rows[0][2].ToString();

            shippingFeeStr = shippingFee.Text;
        }

        private void clickClose(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
