
namespace RandomApp
{
    partial class CustomerOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchPartner = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.listPartner = new System.Windows.Forms.DataGridView();
            this.location = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.contactNumber = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.partnerID = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.partnerName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.productAmount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.noBranch = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.representative = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPartner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::RandomApp.Properties.Resources.title_bar;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-21, -25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1643, 240);
            this.panel1.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(56, 110);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(244, 65);
            this.label16.TabIndex = 15;
            this.label16.Text = "Đặt hàng";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Roboto Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(489, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(397, 56);
            this.label15.TabIndex = 2;
            this.label15.Text = "Xem danh sách các đối tác\r\nrồi tiến hành chọn sản phẩm đặt hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(56, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 23);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.clickBack);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(1558, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 40);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.clickClose);
            // 
            // searchPartner
            // 
            this.searchPartner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchPartner.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchPartner.ForeColor = System.Drawing.Color.DimGray;
            this.searchPartner.Location = new System.Drawing.Point(36, 430);
            this.searchPartner.Name = "searchPartner";
            this.searchPartner.PlaceholderText = "Tìm kiếm đối tác...";
            this.searchPartner.Size = new System.Drawing.Size(1477, 25);
            this.searchPartner.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Location = new System.Drawing.Point(23, 459);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1510, 2);
            this.label14.TabIndex = 19;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1545, 430);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.clickSearch);
            // 
            // listPartner
            // 
            this.listPartner.BackgroundColor = System.Drawing.Color.White;
            this.listPartner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listPartner.Location = new System.Drawing.Point(22, 470);
            this.listPartner.Name = "listPartner";
            this.listPartner.RowHeadersWidth = 51;
            this.listPartner.RowTemplate.Height = 29;
            this.listPartner.Size = new System.Drawing.Size(1555, 407);
            this.listPartner.TabIndex = 22;
            this.listPartner.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClickOrder);
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Cursor = System.Windows.Forms.Cursors.Default;
            this.location.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.location.ForeColor = System.Drawing.Color.DimGray;
            this.location.Location = new System.Drawing.Point(321, 373);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(258, 20);
            this.location.TabIndex = 31;
            this.location.Text = "Quận Bình Thạnh, TP Hồ Chí Minh";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Cursor = System.Windows.Forms.Cursors.Default;
            this.email.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.ForeColor = System.Drawing.Color.DimGray;
            this.email.Location = new System.Drawing.Point(322, 340);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(184, 20);
            this.email.TabIndex = 30;
            this.email.Text = "something@email.com";
            // 
            // contactNumber
            // 
            this.contactNumber.AutoSize = true;
            this.contactNumber.Cursor = System.Windows.Forms.Cursors.Default;
            this.contactNumber.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactNumber.ForeColor = System.Drawing.Color.DimGray;
            this.contactNumber.Location = new System.Drawing.Point(322, 309);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(109, 20);
            this.contactNumber.TabIndex = 29;
            this.contactNumber.Text = "0912347825";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(283, 366);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 32);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(282, 340);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(282, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // partnerID
            // 
            this.partnerID.AutoSize = true;
            this.partnerID.Cursor = System.Windows.Forms.Cursors.Default;
            this.partnerID.Font = new System.Drawing.Font("Roboto Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.partnerID.ForeColor = System.Drawing.Color.DimGray;
            this.partnerID.Location = new System.Drawing.Point(258, 273);
            this.partnerID.Name = "partnerID";
            this.partnerID.Size = new System.Drawing.Size(101, 24);
            this.partnerID.TabIndex = 25;
            this.partnerID.Text = "Mã đối tác";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.Location = new System.Drawing.Point(57, 235);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 160);
            this.panel4.TabIndex = 23;
            // 
            // partnerName
            // 
            this.partnerName.AutoSize = true;
            this.partnerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.partnerName.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.partnerName.ForeColor = System.Drawing.Color.DimGray;
            this.partnerName.Location = new System.Drawing.Point(252, 235);
            this.partnerName.Name = "partnerName";
            this.partnerName.Size = new System.Drawing.Size(187, 41);
            this.partnerName.TabIndex = 24;
            this.partnerName.Text = "Tên đối tác";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.productAmount);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.type);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.noBranch);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.representative);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel5.Location = new System.Drawing.Point(660, 225);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(670, 156);
            this.panel5.TabIndex = 32;
            // 
            // productAmount
            // 
            this.productAmount.AutoSize = true;
            this.productAmount.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productAmount.ForeColor = System.Drawing.Color.DimGray;
            this.productAmount.Location = new System.Drawing.Point(573, 83);
            this.productAmount.Name = "productAmount";
            this.productAmount.Size = new System.Drawing.Size(30, 22);
            this.productAmount.TabIndex = 7;
            this.productAmount.Text = "33";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(358, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "SL Đơn hàng mỗi ngày:";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.type.ForeColor = System.Drawing.Color.DimGray;
            this.type.Location = new System.Drawing.Point(462, 43);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(41, 22);
            this.type.TabIndex = 5;
            this.type.Text = "Sơn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(358, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Loại hàng:";
            // 
            // noBranch
            // 
            this.noBranch.AutoSize = true;
            this.noBranch.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noBranch.ForeColor = System.Drawing.Color.DimGray;
            this.noBranch.Location = new System.Drawing.Point(170, 84);
            this.noBranch.Name = "noBranch";
            this.noBranch.Size = new System.Drawing.Size(20, 22);
            this.noBranch.TabIndex = 3;
            this.noBranch.Text = "2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(37, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 23);
            this.label9.TabIndex = 2;
            this.label9.Text = "Số chi nhánh:";
            // 
            // representative
            // 
            this.representative.AutoSize = true;
            this.representative.Font = new System.Drawing.Font("Roboto", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.representative.ForeColor = System.Drawing.Color.DimGray;
            this.representative.Location = new System.Drawing.Point(181, 44);
            this.representative.Name = "representative";
            this.representative.Size = new System.Drawing.Size(156, 22);
            this.representative.TabIndex = 1;
            this.representative.Text = "Tên người đại diện";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(37, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Người đại diện:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.label17);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Location = new System.Drawing.Point(827, 373);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(318, 71);
            this.panel6.TabIndex = 33;
            this.panel6.Click += new System.EventHandler(this.clickChoose);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label17.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(96, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 24);
            this.label17.TabIndex = 34;
            this.label17.Text = "Chọn hợp tác";
            this.label17.Click += new System.EventHandler(this.clickChoose);
            // 
            // CustomerOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.location);
            this.Controls.Add(this.email);
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.partnerID);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.partnerName);
            this.Controls.Add(this.listPartner);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.searchPartner);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerOrder";
            this.Load += new System.EventHandler(this.CustomerOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listPartner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox searchPartner;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView listPartner;
        private System.Windows.Forms.Label location;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label contactNumber;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label partnerID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label partnerName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label productAmount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label noBranch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label representative;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label17;
    }
}