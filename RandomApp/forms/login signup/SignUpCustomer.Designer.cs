
namespace RandomApp
{
    partial class SignUpCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpCustomer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.clickSucceed = new System.Windows.Forms.Panel();
            this.locationInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.contactNumberInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.clickSucceed);
            this.panel1.Controls.Add(this.locationInput);
            this.panel1.Controls.Add(this.emailInput);
            this.panel1.Controls.Add(this.contactNumberInput);
            this.panel1.Controls.Add(this.nameInput);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-21, -27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 913);
            this.panel1.TabIndex = 0;
            // 
            // clickSucceed
            // 
            this.clickSucceed.BackColor = System.Drawing.Color.Transparent;
            this.clickSucceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickSucceed.Location = new System.Drawing.Point(635, 510);
            this.clickSucceed.Name = "clickSucceed";
            this.clickSucceed.Size = new System.Drawing.Size(331, 65);
            this.clickSucceed.TabIndex = 9;
            this.clickSucceed.Click += new System.EventHandler(this.clickSubmit);
            // 
            // locationInput
            // 
            this.locationInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locationInput.ForeColor = System.Drawing.Color.DimGray;
            this.locationInput.Location = new System.Drawing.Point(615, 444);
            this.locationInput.Name = "locationInput";
            this.locationInput.PlaceholderText = "Nhập địa chỉ...";
            this.locationInput.Size = new System.Drawing.Size(391, 22);
            this.locationInput.TabIndex = 7;
            // 
            // emailInput
            // 
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailInput.ForeColor = System.Drawing.Color.DimGray;
            this.emailInput.Location = new System.Drawing.Point(615, 358);
            this.emailInput.Name = "emailInput";
            this.emailInput.PlaceholderText = "Nhập email...";
            this.emailInput.Size = new System.Drawing.Size(391, 22);
            this.emailInput.TabIndex = 6;
            // 
            // contactNumberInput
            // 
            this.contactNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactNumberInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactNumberInput.ForeColor = System.Drawing.Color.DimGray;
            this.contactNumberInput.Location = new System.Drawing.Point(615, 272);
            this.contactNumberInput.Name = "contactNumberInput";
            this.contactNumberInput.PlaceholderText = "Nhập số điện thoại...";
            this.contactNumberInput.Size = new System.Drawing.Size(391, 22);
            this.contactNumberInput.TabIndex = 5;
            // 
            // nameInput
            // 
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInput.ForeColor = System.Drawing.Color.DimGray;
            this.nameInput.Location = new System.Drawing.Point(615, 185);
            this.nameInput.Name = "nameInput";
            this.nameInput.PlaceholderText = "Nhập họ và tên...";
            this.nameInput.Size = new System.Drawing.Size(391, 22);
            this.nameInput.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(49, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 23);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.clickBack);
            // 
            // SignUpCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1045, 869);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpCustomer";
            this.Load += new System.EventHandler(this.SignUpCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox locationInput;
        public System.Windows.Forms.TextBox emailInput;
        public System.Windows.Forms.TextBox contactNumberInput;
        public System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Panel clickSucceed;
    }
}