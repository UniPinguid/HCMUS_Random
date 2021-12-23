using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RandomApp
{
    public partial class PartnerProductUpdateSuccess : Form
    {
        public PartnerProductUpdateSuccess()
        {
            InitializeComponent();
        }

        private void clickContinue(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
