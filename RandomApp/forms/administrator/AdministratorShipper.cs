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
    public partial class AdministratorShipper : Form
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
        public AdministratorShipper()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickEdit(object sender, EventArgs e)
        {
            AdministratorShipperEdit shipperEdit = new AdministratorShipperEdit();
            shipperEdit.ShowDialog();
        }

        private void clickDelete(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn xóa đối tác này không?", "Xóa đối tác", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Do something...
            }
        }

        private void clickBack(object sender, EventArgs e)
        {
            AdministratorHomepage homepage = new AdministratorHomepage();
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
    }
}
