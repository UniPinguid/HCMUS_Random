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
    public partial class CreateContract : Form
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
        public CreateContract()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void clickBack(object sender, EventArgs e)
        {
            PartnerContract contract = new PartnerContract();
            contract.Show();
            this.Close();
        }

         private void clickCreate(object sender, EventArgs e)
         {
             /*using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=ONLINE_STORE;Integrated Security=True"))
             {
                 using (SqlCommand cmd = new SqlCommand("sp_DangKiHopDong", con))
                 {
                     cmd.CommandType = CommandType.StoredProcedure;
                     cmd.Parameters.AddWithValue("@TenSP", Name.Text);
                     cmd.Parameters.AddWithValue("@Gia", GiaNV.Text);
                     cmd.Parameters.AddWithValue("@MoTa", moTa.Text);
                     cmd.Parameters.AddWithValue("@GiaTieuChuan", GiaTC.Text);
                     con.Open();
                     cmd.ExecuteNonQuery();
                 }
                 ;
             }*/
         }
    }
}
