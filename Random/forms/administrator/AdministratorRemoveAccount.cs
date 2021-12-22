using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandomApp
{
    public partial class AdministratorRemoveAccount : Form
    {
        public AdministratorRemoveAccount()
        {
            InitializeComponent();
        }

        private void clickClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clickSubmit(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn xóa đối tác này không?", "Xóa đối tác", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Do something...
                MessageBox.Show("Tài khoản đã xóa thành công!", "Thông báo");
                this.Close();
                this.Close();
            }
        }
    }
}
