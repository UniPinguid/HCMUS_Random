using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Random
{
    public partial class ShipperTakeOrderSuccess : Form
    {
        public ShipperTakeOrderSuccess()
        {
            InitializeComponent();
        }

        private void clickContinue(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
