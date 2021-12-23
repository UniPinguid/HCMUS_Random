using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandomApp
{
    public partial class AdministratorLockAccount : Form
    {
        public AdministratorLockAccount()
        {
            InitializeComponent();
        }

        private void clickClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clickSubmit(object sender, EventArgs e)
        {
            MessageBox.Show("Tài khoản đã khóa thành công!", "Thông báo");
            this.Close();
        }
    }
}
