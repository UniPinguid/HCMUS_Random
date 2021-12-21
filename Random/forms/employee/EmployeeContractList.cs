using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Random
{
    public partial class EmployeeContractList : Form
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
        public EmployeeContractList()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickApprove(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn duyệt hợp đồng này không?", "Duyệt hợp đồng", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                EmployeeContractApprove success = new EmployeeContractApprove();
                success.ShowDialog();
            }
        }

        private void clickExtend(object sender, EventArgs e)
        {
            EmployeeContractExtend extend = new EmployeeContractExtend();
            extend.ShowDialog();
        }

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clickBack(object sender, EventArgs e)
        {
            EmployeeContract contract = new EmployeeContract();
            contract.Show();
            this.Close();
        }

        private void clickViewInfo(object sender, EventArgs e)
        {
            Contract contract = new Contract();
            contract.ShowDialog();
        }
    }
}
