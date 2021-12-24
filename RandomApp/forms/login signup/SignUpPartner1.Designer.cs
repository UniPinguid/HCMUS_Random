
namespace RandomApp
{
    partial class SignUpPartner1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpPartner1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.province = new System.Windows.Forms.ComboBox();
            this.district = new System.Windows.Forms.ComboBox();
            this.locationInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.contactNumberInput = new System.Windows.Forms.TextBox();
            this.representativeInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.province);
            this.panel1.Controls.Add(this.district);
            this.panel1.Controls.Add(this.locationInput);
            this.panel1.Controls.Add(this.emailInput);
            this.panel1.Controls.Add(this.contactNumberInput);
            this.panel1.Controls.Add(this.representativeInput);
            this.panel1.Controls.Add(this.nameInput);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-19, -27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 903);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(636, 702);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 61);
            this.panel3.TabIndex = 12;
            this.panel3.Click += new System.EventHandler(this.clickContinue);
            // 
            // province
            // 
            this.province.DropDownHeight = 150;
            this.province.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.province.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.province.ForeColor = System.Drawing.Color.DimGray;
            this.province.FormattingEnabled = true;
            this.province.IntegralHeight = false;
            this.province.Items.AddRange(new object[] {
            "Hà Nội",
            "Thành phố Hồ Chí Minh",
            "An Giang",
            "Bà Rịa - Vũng Tàu",
            "Bạc Liêu",
            "Bắc Giang",
            "Bắc Kạn",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Dương",
            "Bình Định",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cao Bằng",
            "Cần Thơ",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam",
            "Hà Tĩnh",
            "Hải Dương",
            "Hải Phòng",
            "Hậu Giang",
            "Hòa Bình",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum",
            "Lai Châu",
            "Lạng Sơn",
            "Lào Cai",
            "Lâm Đồng",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.province.Location = new System.Drawing.Point(814, 625);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(196, 30);
            this.province.TabIndex = 11;
            // 
            // district
            // 
            this.district.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.district.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.district.ForeColor = System.Drawing.Color.DimGray;
            this.district.FormattingEnabled = true;
            this.district.Items.AddRange(new object[] {
            "Quận 1",
            "Quận 2",
            "Quận 3",
            "Quận 4",
            "Quận 5",
            "Quận 6",
            "Quận 7",
            "Quận 8",
            "Quận 9",
            "Quận 10",
            "Quận 11",
            "Quận Bình Tân",
            "Quận Bình Thạnh",
            "Thành phố Thủ Đức"});
            this.district.Location = new System.Drawing.Point(608, 625);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(151, 30);
            this.district.TabIndex = 10;
            // 
            // locationInput
            // 
            this.locationInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.locationInput.ForeColor = System.Drawing.Color.DimGray;
            this.locationInput.Location = new System.Drawing.Point(616, 543);
            this.locationInput.Name = "locationInput";
            this.locationInput.PlaceholderText = "Nhập địa chỉ...";
            this.locationInput.Size = new System.Drawing.Size(391, 22);
            this.locationInput.TabIndex = 9;
            // 
            // emailInput
            // 
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailInput.ForeColor = System.Drawing.Color.DimGray;
            this.emailInput.Location = new System.Drawing.Point(616, 454);
            this.emailInput.Name = "emailInput";
            this.emailInput.PlaceholderText = "Nhập email...";
            this.emailInput.Size = new System.Drawing.Size(391, 22);
            this.emailInput.TabIndex = 8;
            // 
            // contactNumberInput
            // 
            this.contactNumberInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactNumberInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactNumberInput.ForeColor = System.Drawing.Color.DimGray;
            this.contactNumberInput.Location = new System.Drawing.Point(616, 369);
            this.contactNumberInput.Name = "contactNumberInput";
            this.contactNumberInput.PlaceholderText = "Nhập số điện thoại...";
            this.contactNumberInput.Size = new System.Drawing.Size(391, 22);
            this.contactNumberInput.TabIndex = 7;
            // 
            // representativeInput
            // 
            this.representativeInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.representativeInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.representativeInput.ForeColor = System.Drawing.Color.DimGray;
            this.representativeInput.Location = new System.Drawing.Point(616, 280);
            this.representativeInput.Name = "representativeInput";
            this.representativeInput.PlaceholderText = "Nhập tên người đại diện...";
            this.representativeInput.Size = new System.Drawing.Size(391, 22);
            this.representativeInput.TabIndex = 6;
            // 
            // nameInput
            // 
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInput.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameInput.ForeColor = System.Drawing.Color.DimGray;
            this.nameInput.Location = new System.Drawing.Point(616, 187);
            this.nameInput.Name = "nameInput";
            this.nameInput.PlaceholderText = "Nhập họ và tên...";
            this.nameInput.Size = new System.Drawing.Size(391, 22);
            this.nameInput.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(48, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 23);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.clickBack);
            // 
            // SignUpPartner1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 872);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpPartner1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpPartner1";
            this.Load += new System.EventHandler(this.SignUpPartner1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox province;
        private System.Windows.Forms.ComboBox district;
        private System.Windows.Forms.TextBox locationInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.TextBox contactNumberInput;
        private System.Windows.Forms.TextBox representativeInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Panel panel3;
    }
}