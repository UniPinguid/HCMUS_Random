using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RandomApp
{
    public partial class StartUp : Form
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

        public StartUp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 36, 36));
        }

        private void clickClose(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn chắc là muốn thoát không?", "Thoát", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void clickLogin(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void clickSignUp(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void enterLogin(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"..\..\..\icons\login hover.png");
        }

        private void leaveLogin(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"..\..\..\icons\login button.png");
        }

        private void enterSignUp(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"..\..\..\icons\signup hover.png");
        }

        private void leaveSignUp(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"..\..\..\icons\signup button.png");
        }

        private void closeHover(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"..\..\..\icons\close hover.png");
        }

        private void closeLeave(object sender, EventArgs e)
        {
            (sender as PictureBox).Image = Image.FromFile(@"..\..\..\icons\close.png");
        }
    }
}
