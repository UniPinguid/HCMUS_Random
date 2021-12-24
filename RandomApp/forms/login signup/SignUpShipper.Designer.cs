
namespace RandomApp
{
    partial class SignUpShipper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpShipper));
            this.panel1 = new System.Windows.Forms.Panel();
            this.locationInput = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bankAccountInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.areaInput = new System.Windows.Forms.TextBox();
            this.numberPlateInput = new System.Windows.Forms.TextBox();
            this.contactNumberInput = new System.Windows.Forms.TextBox();
            this.citizenIDInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.locationInput);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bankAccountInput);
            this.panel1.Controls.Add(this.emailInput);
            this.panel1.Controls.Add(this.areaInput);
            this.panel1.Controls.Add(this.numberPlateInput);
            this.panel1.Controls.Add(this.contactNumberInput);
            this.panel1.Controls.Add(this.citizenIDInput);
            this.panel1.Controls.Add(this.nameInput);
            this.panel1.Location = new System.Drawing.Point(-20, -27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 900);
            this.panel1.TabIndex = 0;
            // 
            // locationInput
            // 
            this.locationInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locationInput.ForeColor = System.Drawing.Color.DimGray;
            this.locationInput.Location = new System.Drawing.Point(614, 446);
            this.locationInput.Name = "locationInput";
            this.locationInput.PlaceholderText = "Nhập địa chỉ...";
            this.locationInput.Size = new System.Drawing.Size(389, 22);
            this.locationInput.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(634, 775);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 70);
            this.panel3.TabIndex = 13;
            this.panel3.Click += new System.EventHandler(this.clickSubmit);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(48, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 23);
            this.panel2.TabIndex = 12;
            this.panel2.Click += new System.EventHandler(this.clickBack);
            // 
            // bankAccountInput
            // 
            this.bankAccountInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bankAccountInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bankAccountInput.ForeColor = System.Drawing.Color.DimGray;
            this.bankAccountInput.Location = new System.Drawing.Point(616, 708);
            this.bankAccountInput.Name = "bankAccountInput";
            this.bankAccountInput.PlaceholderText = "Nhập số tài khoản ngân hàng...";
            this.bankAccountInput.Size = new System.Drawing.Size(389, 22);
            this.bankAccountInput.TabIndex = 12;
            // 
            // emailInput
            // 
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailInput.ForeColor = System.Drawing.Color.DimGray;
            this.emailInput.Location = new System.Drawing.Point(616, 622);
            this.emailInput.Name = "emailInput";
            this.emailInput.PlaceholderText = "Nhập email...";
            this.emailInput.Size = new System.Drawing.Size(389, 22);
            this.emailInput.TabIndex = 11;
            // 
            // areaInput
            // 
            this.areaInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.areaInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.areaInput.ForeColor = System.Drawing.Color.DimGray;
            this.areaInput.Location = new System.Drawing.Point(808, 535);
            this.areaInput.Name = "areaInput";
            this.areaInput.PlaceholderText = "Tam Kỳ";
            this.areaInput.Size = new System.Drawing.Size(195, 22);
            this.areaInput.TabIndex = 10;
            // 
            // numberPlateInput
            // 
            this.numberPlateInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numberPlateInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberPlateInput.ForeColor = System.Drawing.Color.DimGray;
            this.numberPlateInput.Location = new System.Drawing.Point(616, 535);
            this.numberPlateInput.Name = "numberPlateInput";
            this.numberPlateInput.PlaceholderText = "55AB-123.45";
            this.numberPlateInput.Size = new System.Drawing.Size(122, 22);
            this.numberPlateInput.TabIndex = 9;
            // 
            // contactNumberInput
            // 
            this.contactNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactNumberInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactNumberInput.ForeColor = System.Drawing.Color.DimGray;
            this.contactNumberInput.Location = new System.Drawing.Point(615, 359);
            this.contactNumberInput.Name = "contactNumberInput";
            this.contactNumberInput.PlaceholderText = "Nhập số điện thoại...";
            this.contactNumberInput.Size = new System.Drawing.Size(389, 22);
            this.contactNumberInput.TabIndex = 7;
            // 
            // citizenIDInput
            // 
            this.citizenIDInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.citizenIDInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.citizenIDInput.ForeColor = System.Drawing.Color.DimGray;
            this.citizenIDInput.Location = new System.Drawing.Point(615, 271);
            this.citizenIDInput.Name = "citizenIDInput";
            this.citizenIDInput.PlaceholderText = "Nhập số CMND hoặc CCCD...";
            this.citizenIDInput.Size = new System.Drawing.Size(389, 22);
            this.citizenIDInput.TabIndex = 6;
            // 
            // nameInput
            // 
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInput.ForeColor = System.Drawing.Color.DimGray;
            this.nameInput.Location = new System.Drawing.Point(615, 186);
            this.nameInput.Name = "nameInput";
            this.nameInput.PlaceholderText = "Nhập họ và tên...";
            this.nameInput.Size = new System.Drawing.Size(389, 22);
            this.nameInput.TabIndex = 5;
            // 
            // SignUpShipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 870);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpShipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpShipper";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox bankAccountInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox areaInput;
        private System.Windows.Forms.TextBox numberPlateInput;
        private System.Windows.Forms.TextBox contactNumberInput;
        private System.Windows.Forms.TextBox citizenIDInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox locationInput;
    }
}