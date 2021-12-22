using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RandomApp
{
    public partial class PartnerProduct : Form
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
        public PartnerProduct()
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

        private void clickAddProduct(object sender, EventArgs e)
        {
            PartnerProductAdd productAdd = new PartnerProductAdd();
            productAdd.ShowDialog();
        }

        private void clickUpdateProduct(object sender, EventArgs e)
        {
            PartnerProductUpdate productUpdate = new PartnerProductUpdate();
            productUpdate.ShowDialog();
        }

        private void clickDeleteProduct(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc là muốn xóa sản phẩm này không?", "Xóa sản phẩm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Do something...
            }
        }
    }
}
