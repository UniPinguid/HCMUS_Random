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
    public partial class AdministratorManagement : Form
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
        public AdministratorManagement()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
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

        private void clickEdit(object sender, EventArgs e)
        {
            //// If selected user is a Partner role
            //AdministratorPartnerEdit partnerEdit = new AdministratorPartnerEdit();
            //partnerEdit.ShowDialog();

            // If selected user is a Customer role
            AdministratorCustomerEdit customerEdit = new AdministratorCustomerEdit();
            customerEdit.ShowDialog();

            //// If selected user is a Shipper role
            //AdministratorShipperEdit shipperEdit = new AdministratorShipperEdit();
            //shipperEdit.ShowDialog();

            //// If selected user is an Employee role
            //AdministratorEmployeeEdit employeeEdit = new AdministratorEmployeeEdit();
            //employeeEdit.ShowDialog();

            //// If selected user is an Administrator role
            //AdministratorAdminEdit adminEdit = new AdministratorAdminEdit();
            //adminEdit.ShowDialog();
        }

        private void clickLockAccount(object sender, EventArgs e)
        {
            AdministratorLockAccount lockAccount = new AdministratorLockAccount();
            lockAccount.ShowDialog();
        }

        private void clickUnlock(object sender, EventArgs e)
        {
            AdministratorUnlockAccount unlockAccount = new AdministratorUnlockAccount();
            unlockAccount.ShowDialog();
        }

        private void clickGrantPermission(object sender, EventArgs e)
        {
            AdministratorGrantPermission grantPermission = new AdministratorGrantPermission();
            grantPermission.ShowDialog();
        }

        private void clickRemove(object sender, EventArgs e)
        {
            AdministratorRemoveAccount removeAccount = new AdministratorRemoveAccount();
            removeAccount.ShowDialog();
        }
    }
}
