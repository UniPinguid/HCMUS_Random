using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Random
{
    public partial class CreateContractSuccess : Form
    {
        public CreateContractSuccess()
        {
            InitializeComponent();
        }

        private void clickContinue(object sender, EventArgs e)
        {
            PartnerContract contract = new PartnerContract();
            contract.Show();
            this.Close();
        }
    }
}
